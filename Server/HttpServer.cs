using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

class HttpServer
{
	static void Main(string[] args)
	{
		int SERVICE_PORT = 8100;
		if (1 == args.Length)
		{
			Int32.TryParse(args[0], out SERVICE_PORT);
		}
		const string SERVICE_NAME = "mathService";
		BrokerHelper brokerHelper = new BrokerHelper();
		HttpChannel channel = new HttpChannel(SERVICE_PORT);
		ChannelServices.RegisterChannel(channel, false);

		RemotingConfiguration.RegisterWellKnownServiceType(
		   typeof(MathServiceImp),
		   SERVICE_NAME,
		   WellKnownObjectMode.Singleton);

		string serverLocation = string.Format("http://localhost:{0}/{1}", SERVICE_PORT, SERVICE_NAME);
		Console.WriteLine("Server run at location: {0}", serverLocation);
		// register itself to Broker
		brokerHelper.registerServer(SERVICE_NAME, serverLocation);
		Console.WriteLine("Press a key to exit");
		Console.ReadLine();
		brokerHelper.unregisterServer(SERVICE_NAME);
		ChannelServices.UnregisterChannel(channel);
	}
}

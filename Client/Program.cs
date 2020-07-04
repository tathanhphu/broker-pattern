using System;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
class Program
{
	[STAThread]
	static void Main(string[] args)
	{
		HttpChannel channel = new HttpChannel();
		const string SERVICE_NAME = "mathService";

		ChannelServices.RegisterChannel(channel, false);
		BrokerHelper brokerHelper = new BrokerHelper();
		// connect to Broker
		string serverLocation = brokerHelper.locateServer(SERVICE_NAME);
		Console.WriteLine("Try to connect to server from location: " + serverLocation);

		IMathService clientProxy = (IMathService)
		   Activator.GetObject(typeof(IMathService),
		   serverLocation);
		Console.WriteLine("Client.main(): Reference acquired");

		dynamic total = clientProxy.Sum(99, 1);
		Console.WriteLine("Calling remote method {0} + {1} = {2}", 99, 1, total);
	}
}

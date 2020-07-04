using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		const string BROKER_SERVICE_NAME = "BrokerService";
		const int BROKER_PORT = 9999;
		HttpChannel channel = new HttpChannel(BROKER_PORT);
		ChannelServices.RegisterChannel(channel, false);

		RemotingConfiguration.RegisterWellKnownServiceType(
			typeof(BrokerImp),
			BROKER_SERVICE_NAME,
			WellKnownObjectMode.Singleton);
		Console.WriteLine("Broker is available at port: " + BROKER_PORT);
		Console.WriteLine("Press a key to exit");
		Console.ReadLine();
		ChannelServices.UnregisterChannel(channel);
	}
}


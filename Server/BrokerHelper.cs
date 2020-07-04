using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BrokerHelper
{
	const string BROKER_WELL_KNOW_LOCATION = "http://localhost:9999/BrokerService";
	IBrokerService broker;
	public BrokerHelper()
	{
		broker = (IBrokerService)Activator.GetObject(typeof(IBrokerService), BROKER_WELL_KNOW_LOCATION);
	}

	public void registerServer(string serviceName, string location)
	{
		Console.WriteLine("Register server to Broker");
		broker.registerServer(serviceName, location);
	}

	public void unregisterServer(string serviceName)
	{
		Console.WriteLine("Unregister server to Broker");
		broker.unregisterService(serviceName);
	}	
}


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

	public string locateServer(string serviceName)
	{
		Console.WriteLine("Locate server from Broker");
		return broker.locateServer(serviceName);
	}
	
}


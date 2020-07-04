using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BrokerImp : MarshalByRefObject, IBrokerService
{
	Dictionary<string, string> serviceLocationMap = new Dictionary<string, string>();
	public string locateServer(string serviceName)
	{
		string serviceLocation = String.Empty;
		serviceLocationMap.TryGetValue(serviceName, out serviceLocation);
		if (String.IsNullOrEmpty(serviceLocation))
		{
			throw new Exception("No server available for the service " + serviceName);
		}
		return serviceLocation;
	}

	public void registerServer(string serviceName, string location)
	{
		serviceLocationMap.Add(serviceName, location);
		Console.WriteLine("A server is registered: service name {0}, server location {1}", serviceName, location);
	}

	public void unregisterService(string serviceName)
	{
		serviceLocationMap.Remove(serviceName);
		Console.WriteLine("A server is un-registered: service name {0}", serviceName);
	}
}

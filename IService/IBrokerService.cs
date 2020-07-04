using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBrokerService
{
	// For servers
	void registerServer(string serviceName, string location);
	void unregisterService(string serviceName);

	// For clients
	string locateServer(string serviceName);
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;

public class MathServiceImp: MarshalByRefObject, IMathService
{
	public MathServiceImp()
	{
//		RemotingConfiguration.Configure()
	}
	public override object InitializeLifetimeService()
	{
		ILease lease = (ILease)base.InitializeLifetimeService();

		if (lease.CurrentState == LeaseState.Initial)
		{
			// set times very short for demonstration purposes
			lease.InitialLeaseTime = TimeSpan.FromSeconds(25);
			lease.SponsorshipTimeout = TimeSpan.FromSeconds(25);
			lease.RenewOnCallTime = TimeSpan.FromSeconds(20);
		}
		return lease;
	}
	public override ObjRef CreateObjRef(Type requestedType)
	{
		ObjRef objRef = base.CreateObjRef(requestedType);
		return objRef;
	}
	public int Sum(int a, int b)
	{
		return a + b;
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSample.Service
{
	[ServiceContract]
	public interface IGreetingService
	{
		[OperationContract]
		string Greet(string name);
	}
}

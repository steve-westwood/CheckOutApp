using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using CheckOutApp.Core;
using CheckOutApp.Core.PricingStrategies;

namespace CheckOutApp.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Registering
			var container = new WindsorContainer().Install(FromAssembly.This());
			// Resolving
			var pricingService = container.Resolve<IPricingService>();

			// CheckOut
			var co = new CheckOut(pricingService);
			co.Scan('A');
			co.Scan('A');
			var runningCost = co.Total();
			co.Scan('A');
			runningCost = co.Total();
			co.Scan('A');
			runningCost = co.Total();
			co.Scan('B');
			runningCost = co.Total();
			co.Scan('B');
			runningCost = co.Total();
			co.Scan('B');
			runningCost = co.Total();
			co.Void('B');
			runningCost = co.Total();
		}
	}
}

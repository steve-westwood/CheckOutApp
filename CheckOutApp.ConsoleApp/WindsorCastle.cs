using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CheckOutApp.Core.PricingStrategies;

namespace CheckOutApp.ConsoleApp
{
	public class WindsorInstaller : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<IPricingService>().ImplementedBy<PricingService>().LifestyleTransient());
			container.Register(Component.For<IPriceRules>().ImplementedBy<SpringPricing>().LifestyleTransient());
		}
	}
}

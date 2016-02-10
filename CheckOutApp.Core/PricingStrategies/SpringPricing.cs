using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public class SpringPricing : IPriceRules
	{
		private List<IPricingStrategy> _rules = new List<IPricingStrategy>();
		public SpringPricing()
		{
			_rules.Add(new SingleUnitPrice
			{
				Item = 'A',
				Price = 50
			});
			_rules.Add(new SingleUnitPrice
			{
				Item = 'B',
				Price = 30
			});
			_rules.Add(new SingleUnitPrice
			{
				Item = 'C',
				Price = 20
			});
			_rules.Add(new SingleUnitPrice
			{
				Item = 'D',
				Price = 15
			});
			_rules.Add(new MultiBuy
			{
				Item = 'A',
				Multiplier = 3,
				Price = 130
			});
			_rules.Add(new MultiBuy
			{
				Item = 'B',
				Multiplier = 2,
				Price = 45
			});
		}
		public List<IPricingStrategy> GetRules()
		{
			return _rules;
		}
	}
}

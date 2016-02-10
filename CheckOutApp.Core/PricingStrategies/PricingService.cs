using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public class PricingService : IPricingService
	{
		List<IPricingStrategy> _rules = new List<IPricingStrategy>();
		public PricingService(IPriceRules rules)
		{
			_rules.AddRange(rules.GetRules());
		}
		public int GetPrice(char item, int numOfItems)
		{
			var total = 0;
			var multiplierRules = _rules.OrderByDescending(x => x.Multiplier)
								.Where(x => x.Item == item);
			foreach (var rule in multiplierRules)
			{
				if (numOfItems >= rule.Multiplier)
				{
					total += rule.Calculate(out numOfItems, numOfItems);
				}
			}
			return total;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public interface IPricingStrategy
	{
		char Item { get; set; }
		bool IsBlanket();
		int Multiplier { get; set; }
		int Price { get; set; }
		int Calculate(out int numLeft, int numIn);
	}
}

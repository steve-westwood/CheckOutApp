using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public class MultiBuy: IPricingStrategy
	{
		public char Item { get; set; }
		public int Multiplier { get; set; }
		public int Price { get; set; }

		public int Calculate(out int numLeft, int numIn)
		{
			numLeft = numIn;
			var subTotal = 0;
			if (numLeft >= Multiplier)
			{
				subTotal += Price * (numLeft / Multiplier);
				numLeft = numLeft - ((numLeft / Multiplier) * Multiplier);
			}
			return subTotal;
		}

		public bool IsBlanket()
		{
			return false;
		}
	}
}

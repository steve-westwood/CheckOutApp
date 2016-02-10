using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public class SingleUnitPrice : IPricingStrategy
	{
		private int _multiplier = 1;
		public char Item { get; set; }
		public int Price { get; set; }

		public int Calculate(out int numLeft, int numIn)
		{
			numLeft = numIn;
			var subTotal = Price * numLeft;
			numLeft = 0;
			return subTotal;
		}

		public bool IsBlanket()
		{
			return false;
		}


		public int Multiplier
		{
			get
			{
				return _multiplier;
			}
			set
			{
				_multiplier =  1;
			}
		}
	}
}

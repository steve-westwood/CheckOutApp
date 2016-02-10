﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutApp.Core.PricingStrategies
{
	public interface IPriceRules
	{
		List<IPricingStrategy> GetRules();
	}
}

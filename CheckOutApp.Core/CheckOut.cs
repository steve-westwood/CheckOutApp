using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOutApp.Core.PricingStrategies;

namespace CheckOutApp.Core
{
    public class CheckOut
    {
		public List<char> _items = new List<char>();
		private IPricingService _pricingService;
		private PricingStrategies.IPricingService pricingService;
		public CheckOut(IPricingService pricingService)
		{
			_pricingService = pricingService;
		}

		public void Scan(char itemScanned)
		{
			_items.Add(itemScanned);
		}

		public void Void(char itemToVoid)
		{
			if (_items.Contains(itemToVoid))
			{
				_items.Remove(itemToVoid);
			}
		}

		public int Total()
		{
			int total = 0;

			var itemGroups = from i in _items
					group i by i into counts
					select new { Count = counts.Count(), Group = counts.Key };

			foreach(var item in itemGroups)
			{
				total += _pricingService.GetPrice(item.Group, item.Count);
			}

			return total;
		}
    }
}

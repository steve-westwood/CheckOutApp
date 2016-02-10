using System;
using Moq;
using NUnit.Framework;
using CheckOutApp.Core.PricingStrategies;
namespace CheckOutApp.Tests
{
	[TestFixture]
	public class SingleUnitStrategyTests
	{
		private SingleUnitPrice _testSubject;

		[SetUp]
		public void SetUp()
		{
			_testSubject = new SingleUnitPrice
			{
				Item = 'A',
				Price = 50,
			};
		}

		[Test]
		public void Ensure_single_unit_pricing_returns_correct_value_for_1_items()
		{
			var expectedCost = 50;
			int numleft = 0;
			int numberOfItems = 1;
			var actualCost = _testSubject.Calculate(out numleft, numberOfItems);
			Assert.AreEqual(expectedCost, actualCost);
		}

		[Test]
		public void Ensure_single_unit_pricing__returns_correct_value_for_4_items()
		{
			var expectedCost = 200;
			int numleft = 0;
			int numberOfItems = 4;
			var actualCost = _testSubject.Calculate(out numleft, numberOfItems);
			Assert.AreEqual(expectedCost, actualCost);
		}
	}
}
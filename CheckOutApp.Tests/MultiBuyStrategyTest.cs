using System;
using Moq;
using NUnit.Framework;
using CheckOutApp.Core.PricingStrategies;

namespace CheckOutApp.Tests
{
	[TestFixture]
	public class EventSearchFilterServiceTests
	{
		private MultiBuy _testSubject;

		[SetUp]
		public void SetUp()
		{
			_testSubject = new MultiBuy
			{
				Item = 'A',
				Price = 130,
				Multiplier = 3
			};
		}

		[Test]
		public void Ensure_multibuy_returns_correct_value_for_3_items()
		{
			var expectedCost = 130;
			int numleft = 0;
			int numberOfItems = 3;
			var actualCost = _testSubject.Calculate(out numleft, numberOfItems);
			Assert.AreEqual(expectedCost, actualCost);
		}

		[Test]
		public void Ensure_multibuy_returns_correct_value_for_4_items()
		{
			var expectedCost = 130;
			int numleft = 0;
			int numberOfItems = 4;
			var actualCost = _testSubject.Calculate(out numleft, numberOfItems);
			Assert.AreEqual(expectedCost, actualCost);
		}

		[Test]
		public void Ensure_multibuy_returns_correct_value_for_11_items()
		{
			var expectedCost = 390;
			int numleft = 0;
			int numberOfItems = 11;
			var actualCost = _testSubject.Calculate(out numleft, numberOfItems);
			Assert.AreEqual(expectedCost, actualCost);
		}
	}
}
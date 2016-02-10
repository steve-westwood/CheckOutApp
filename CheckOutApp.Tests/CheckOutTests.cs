using System;
using Moq;
using NUnit.Framework;
using CheckOutApp.Core;
using CheckOutApp.Core.PricingStrategies;
using System.Collections.Generic;

namespace CheckOutApp.Tests
{
	[TestFixture]
	public class CheckOutTests
	{
		private CheckOut _testSubject;
		private Mock<IPricingService> _mockPriceService = new Mock<IPricingService>();

		[SetUp]
		public void SetUp()
		{
			_testSubject = new CheckOut(_mockPriceService.Object);
		}

		[Test]
		public void Ensure_when_you_add_a_item_it_is_saved_in_list()
		{
			List<char> expected = new List<char>();
			expected.Add('A');
			_testSubject.Scan('A');
			Assert.AreEqual(expected, _testSubject._items);
		}

		[Test]
		public void Ensure_when_you_add_several_items_they_are_saved_in_list()
		{
			List<char> expected = new List<char>();
			expected.Add('A');
			expected.Add('B');
			expected.Add('C');
			_testSubject.Scan('A');
			_testSubject.Scan('B');
			_testSubject.Scan('C');
			Assert.AreEqual(expected, _testSubject._items);
		}

		[Test]
		public void Ensure_when_you_remove_an_item_it_is_no_longer_in_list()
		{
			_testSubject.Scan('A');
			_testSubject.Scan('B');
			_testSubject.Scan('C');
			_testSubject.Void('A');
			Assert.IsFalse(_testSubject._items.Contains('A'));
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171018_CreatePhoneNumber
{
    [TestClass]
    public class CreatePhoneNumberTests
    {
        [TestMethod]
        public void PhoneNumberAll_1()
        {
            var kata = new Kata();
            var result = kata.CreatePhoneNumber(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.AreEqual("(111) 111-1111", result);
        }

        [TestMethod]
        public void PhoneNumber()
        {
            var kata = new Kata();
            var result = kata.CreatePhoneNumber(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Assert.AreEqual("(123) 456-7890", result);
        }
    }

    public class Kata
    {
        public string CreatePhoneNumber(int[] numbers)
        {
            return $"({JoinString(numbers, 0, 3)}) {JoinString(numbers, 3, 3)}-{JoinString(numbers, 6, 4)}";
        }

        private string JoinString(IEnumerable<int> nums, int skip, int take)
        {
            return string.Concat(nums.Skip(skip).Take(take));
        }
    }
}

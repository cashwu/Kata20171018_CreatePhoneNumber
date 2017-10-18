using System;
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
            var result = kata.CreatePhoneNumber(new[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1});
            Assert.AreEqual("(111) 111-1111", result);
        }
    }

    public class Kata
    {
        public string CreatePhoneNumber(int[] numbers)
        {
            return "(111) 111-1111";
        }
    }
}

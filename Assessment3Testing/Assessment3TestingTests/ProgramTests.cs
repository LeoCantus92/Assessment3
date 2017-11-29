using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment3Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Testing.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program test = new Program();
        [TestMethod()]
        public void Add2IntTest()
        {
            int result = test.Add2Int(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void SubtractIntTest()
        {
            int result = test.SubtractInt(10, 6);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void Concat2StringsTest()
        {
            string result = test.Concat2Strings("Cat", "Dog");
            Assert.AreEqual("CatDog", result);
        }

        [TestMethod()]
        public void LoginTest()
        {
            bool result = test.Login("User","Pass123");
            Assert.IsTrue(result);
        }
    }
}
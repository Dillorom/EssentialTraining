using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SampleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SampleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[1], "Tomatoes");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SampleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}

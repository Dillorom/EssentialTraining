using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class CutePetsTEst
    {
        [TestMethod]
        public void IsPetCute()
        {
            var testInstance = new CutePets();
            testInstance.Pets.Add("Cat");
            testInstance.Pets.Add("Puppy");
            testInstance.Pets.Add("Bunny");

            Assert.IsTrue(testInstance.IsCute("Cat"));
            Assert.IsFalse(testInstance.IsCute("Raccoon"));
        }
    }
}

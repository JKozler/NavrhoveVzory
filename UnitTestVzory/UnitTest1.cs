using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NavrhoveVzory.Validators;

namespace UnitTestVzory
{
    [TestClass]
    public class UnitTest1
    {
        AgeValidator age;
        BornNumberValidator bornNumber;
        NameValidator nameValidator;
        public UnitTest1()
        {
            age = new AgeValidator();
            bornNumber = new BornNumberValidator();
            nameValidator = new NameValidator();
        }
        [TestMethod]
        public void TestAgeGiveWrong_ReturnsFalse()
        {
            DateTime narozeni = new DateTime(1800, 1, 1);

            var result = age.IsValid(narozeni);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestAgeGiveAccepted_ReturnsTrue()
        {
            DateTime narozeni = new DateTime(1954, 1, 1);

            var result = age.IsValid(narozeni);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNameWrong_ReturnsFalse()
        {
            string name = "a";

            var result = nameValidator.IsValid(name);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestNameAccepted_ReturnsTrue()
        {
            string name = "Alan";

            var result = nameValidator.IsValid(name);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBornNumberWrongAfter1954_ReturnsFalse()
        {
            DateTime date = new DateTime(1985,11,11);
            string bornN = "85111/1111";

            var result = bornNumber.IsValid(bornN, date.Year);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestBornNumberAcceptedAfter1954_ReturnsTrue()
        {
            DateTime date = new DateTime(1985, 11, 11);
            string bornN = "851111/1111";

            var result = bornNumber.IsValid(bornN, date.Year);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBornNumberWrongBefore1954_ReturnsFalse()
        {
            DateTime date = new DateTime(1947, 11, 11);
            string bornN = "471111/1111";

            var result = bornNumber.IsValid(bornN, date.Year);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestBornNumberAcceptedBefore1954_ReturnsTrue()
        {
            DateTime date = new DateTime(1947, 11, 11);
            string bornN = "471111/111";

            var result = bornNumber.IsValid(bornN, date.Year);

            Assert.IsTrue(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Project;
using System;

namespace UnitTestDefault
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void initialize()
        {
            //Objeto obj = new Objeto();
        }

        [TestMethod]
        public void TestIsRightKeyword_WordLol_ResultTrue()
        {
            string key = "lol";
            bool resultado = Helper.IsRightKeyword(key);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestIsRightKeyword_WordTryHard_ResultFalse()
        {
            string key = "try hard";
            bool resultado = Helper.IsRightKeyword(key);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void IsOfAge_Age18_ResultTrue()
        {
            int age = 18;
            bool result = Helper.IsOfAge(age);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOfAge_Age18_ResultFalse()
        {
            int age = 15;
            bool result = Helper.IsOfAge(age);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(20)]
        [DataRow(30)]
        [DataRow(40)]
        [DataRow(50)]
        [DataRow(60)]
        [DataRow(70)]
        public void IsOfAge(int age)
        {
            bool result = Helper.IsOfAge(age);
            Assert.IsTrue(result);
        }
    }
}

using NUnit.Framework;
using Shared.Project;

namespace NUnitTestDefault
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestIsRightKeyword_WordLol_ResultTrue()
        {
            string key = "lol";
            bool resultado = Helper.IsRightKeyword(key);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestIsRightKeyword_WordTryHard_ResultFalse()
        {
            string key = "try hard";
            bool resultado = Helper.IsRightKeyword(key);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void IsOfAge_Age18_ResultTrue()
        {
            int age = 18;
            bool result = Helper.IsOfAge(age);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsOfAge_Age18_ResultFalse()
        {
            int age = 15;
            bool result = Helper.IsOfAge(age);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(40)]
        [TestCase(50)]
        [TestCase(60)]
        [TestCase(70)]
        public void IsOfAge(int age)
        {
            bool result = Helper.IsOfAge(age);
            Assert.IsTrue(result);
        }
    }
}
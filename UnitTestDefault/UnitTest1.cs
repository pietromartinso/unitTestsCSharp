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
        public void VerificaIdadeDeRisco_Idade18Anos_ResultadoTrue()
        {
            int idade = 18;
            bool resultado = Helper.VerificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificaIdadeDeRisco_Idade15Anos_ResultadoFalse()
        {
            int idade = 15;
            bool resultado = Helper.VerificaIdadeDeRisco(idade);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestarNomeRisco()
        {
            string nome = "thiago";
            bool resultado = Helper.VerificaNomeDeRisco(nome);
            Assert.IsTrue(resultado);

        }
    }
}

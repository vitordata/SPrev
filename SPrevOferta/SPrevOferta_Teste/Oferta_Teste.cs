using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPrevOferta;

namespace SPrevOferta_Teste
{
    [TestClass]
    public class Oferta_Teste
    {
        [TestMethod]
        public void Testar_Cadastro_Oferta()
        {
            string nomeoferta = "Curso SPrev 2019";

            Oferta oferta = new Oferta(nomeoferta);

            Assert.IsNotNull(oferta);
            Assert.IsTrue(oferta.nomeoferta == nomeoferta);
        }
        [TestMethod]
        public void Verificar_Oferta_Obrigatoria()
        {
            string nomeoferta = "Curso SPrev 2019";
            Oferta oferta = new Oferta(nomeoferta);
        }
    }
}

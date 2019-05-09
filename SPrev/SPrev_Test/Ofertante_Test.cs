using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPrev;

namespace SPrev_Test
{
    [TestClass]
    public class Ofertante_Test
    {
        [TestMethod]
        public void Testar_Cadastro_de_Ofertante()
        {
            string nome = "Escola X";

            Ofertante ofertante = new Ofertante(nome);

            Assert.IsNotNull(ofertante);
            Assert.IsTrue(ofertante.nome == nome);

        }
        [TestMethod]
        public void Verificar_Ofertante_Obrigatorio()
        {
            string nome = "Escola X";
            Ofertante ofertante = new Ofertante(nome);


        }
    }
}
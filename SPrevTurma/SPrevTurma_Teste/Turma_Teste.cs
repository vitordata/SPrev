using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPrevTurma;

namespace SPrevTurma_Teste
{
    [TestClass]
    public class Turma_Teste
    {
        [TestMethod]
        public void Testar_Cadastro_Turma()
        {
            string nometurma = "Turma de Física";

            Turma turma = new Turma(nometurma);

            Assert.IsNotNull(turma);
            Assert.IsTrue(turma.nometurma == nometurma);
        }
    }
}
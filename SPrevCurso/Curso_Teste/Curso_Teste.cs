using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPrevCurso;

namespace Curso_Teste
{
    [TestClass]
    public class Curso_Teste
    {
        [TestMethod]
        public void Testar_Cadastro_Curso()
        {
            string nomecurso = "Física";

            Curso curso = new Curso(nomecurso);

            Assert.IsNotNull(curso);
            Assert.IsTrue(curso.nomecurso == nomecurso);

        }
        [TestMethod]
        public void Verificar_Curso_Obrigatorio()
        {
            string nomecurso = "Física";
            Curso curso = new Curso(nomecurso);
        }
    }
}

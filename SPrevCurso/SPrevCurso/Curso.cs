using System;

namespace SPrevCurso
{
    public class Curso
    {
        public Curso(string nomecurso)
        {
            if (string.IsNullOrEmpty(nomecurso))
            {
                throw new Exception("Nome do curso nulo ou vazio");
            }

            this.nomecurso = nomecurso;
        }
        public string nomecurso { get; set; }
    }
}

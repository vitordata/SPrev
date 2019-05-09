using System;

namespace SPrevTurma
{
    public class Turma
    {
        public Turma(string nometurma)
        {
            if (string.IsNullOrEmpty(nometurma))
            {
                throw new Exception("Nome da turma inválido!");
            }

            this.nometurma = nometurma;

        }
        public string nometurma { get; set; }
    }
}
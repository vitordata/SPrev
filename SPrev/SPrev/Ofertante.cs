using System;
using System.Collections.Generic;
using System.Text;

namespace SPrev
{
    public class Ofertante
    {
        public Ofertante(string nome)
        {

            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome nulo ou vazio");
            }
            
            this.nome = nome;

        }
        public string nome { get; set; }
    }
}
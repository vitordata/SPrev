using System;

namespace SPrevOferta
{
    public class Oferta
    {
        public Oferta(string nomeoferta)
        {
            if (string.IsNullOrEmpty(nomeoferta))
            {
                throw new Exception("Oferta inválida!");
            }
         
            this.nomeoferta = nomeoferta;
        }
        public string nomeoferta { get; set; }
    }
}

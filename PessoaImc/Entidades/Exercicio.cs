using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaImc.Entidades
{
    class Exercicio
    {
        public string Tipo { get; set; }
        public int Tempo { get; set; }

        public Exercicio()
        {


        }

        public Exercicio(string tipo, int tempo)
        {
            Tipo = tipo;
            Tempo = tempo;
        }
    }
    
}

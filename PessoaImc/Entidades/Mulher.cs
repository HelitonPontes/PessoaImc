using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaImc.Entidades
{
    class Mulher : PessoaImc
    {
        public string Signo { get; set; }

        public Mulher()
        {

        }

        public Mulher(string nome, int idade, double peso, double altura, string signo)
            : base(nome, idade, peso, altura )
        {
            Signo = signo;
        }

        public override string ResultadoIMC()
        {
       
            if (CalcularIMC() < 19)
            {
                return "Abaixo do Peso Ideal";
            }
            else if (CalcularIMC() >19 && CalcularIMC()<25.8)
            {
                return "Peso Ideal";

            }
            else
                return "Acima do Peso";

        }
    }
}

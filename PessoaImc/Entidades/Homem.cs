using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaImc.Entidades
{
    class Homem : PessoaImc
    {
        public string Time { get; set; }

        public Homem()
        {

        }

        public Homem(string nome, int idade, double peso, double altura, string time)
            :base (nome, idade, peso, altura)
        {
            Time = time;
        }

        public override string ResultadoIMC()
        {
            if (CalcularIMC() < 20.7)
            {
                return "Abaixo do Peso Ideal";
            }
            else if (CalcularIMC() > 20.7 && CalcularIMC() < 26.4)
            {
                return "Peso Ideal";

            }
            else
                return "Acima do Peso";
        }
        
       

    }
}

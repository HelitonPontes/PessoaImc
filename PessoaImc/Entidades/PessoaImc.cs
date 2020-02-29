using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaImc.Entidades;


namespace PessoaImc.Entidades
{
    abstract class PessoaImc : Pessoa
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public Exercicio exercicio { get; set; }

        public PessoaImc()
        {

        }

        protected PessoaImc(string nome, int idade,double peso, double altura)
            :base (nome, idade)
        {
            Peso = peso;
            Altura = altura;
            //this.exercicio = exercicio;
        }

        protected PessoaImc(double peso, double altura, Exercicio exercicio)
        {
            Peso = peso;
            Altura = altura;
            this.exercicio = exercicio;
        }

        public double CalcularIMC()
        {
            return Peso / (Altura*Altura);
        }


        public abstract string ResultadoIMC();

       



    }
}

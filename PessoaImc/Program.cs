using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaImc.Entidades;

namespace PessoaImc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXXXX----IMC----XXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            List<Pessoa> Lista = new List<Pessoa>();
            List<Homem> ListaH = new List<Homem>();
            List<Mulher> ListaM = new List<Mulher>();



            Console.Write("Quantos IMC vai Calcular: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();


            for (int i = 0; n > i; i++)
            {
                Console.WriteLine($"Index {i}");
                Console.WriteLine("Escolha o genero (1)masculino e (2 feminino)");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();

                if (n1 == 1)
                {
                    Console.WriteLine("Genero Masculino");
                    Console.Write("Nome>: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade>: ");
                    int idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Peso>: ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura>:");
                    double altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                    Console.Write("Exercicio>: ");
                    string exe = Console.ReadLine();
                    Console.Write("Time>: ");
                    string time = Console.ReadLine();

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                    ListaH.Add(new Homem(nome, idade, peso, altura, time));

                    Lista.Add(new Pessoa(nome, idade));

                    foreach (Homem homem in ListaH)
                    {
                        Console.WriteLine(homem.Nome);
                        Console.WriteLine(homem.Idade);
                        Console.WriteLine(homem.Peso);
                        Console.WriteLine(homem.Altura);
                       // Console.WriteLine(homem.exercicio.Tipo);
                       // Console.WriteLine(homem.exercicio.Tempo);
                        Console.WriteLine(homem.Time);
                       
                    }
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();

                    

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                }
                else if (n1 == 2)
                {
                    Console.WriteLine("Genero Feminino");
                    Console.Write("Nome>: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade>: ");
                    int idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Peso>: ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura>:");
                    double altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                    //Console.Write("Exercicio>: ");
                    //string exercicio = Console.ReadLine();
                    Console.Write("Signo>: ");
                    string signo = Console.ReadLine();

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                    ListaM.Add(new Mulher(nome, idade, peso, altura, signo));

                    Lista.Add(new Pessoa(nome, idade));

                    foreach (Mulher mulher in ListaM)
                    {
                        Console.WriteLine(mulher.Nome);
                        Console.WriteLine(mulher.Idade);
                        Console.WriteLine(mulher.Peso);
                        Console.WriteLine(mulher.Altura);
                        Console.WriteLine(mulher.Signo);
                       
                    }
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();


                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine();





                }
                else

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Opção Inesxistemte!!!");


            }

            foreach (Pessoa pessoa in Lista)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Idade);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();

            }

            foreach (Homem homem in ListaH)
            {
                Console.WriteLine(homem.Nome);
                Console.WriteLine(homem.Idade);
                Console.WriteLine(homem.Peso);
                Console.WriteLine(homem.Altura);
                Console.WriteLine(homem.Time);
                Console.WriteLine(homem.CalcularIMC());
                Console.WriteLine(homem.ResultadoIMC());

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();


            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();




            foreach (Mulher mulher in ListaM)
            {
                Console.WriteLine(mulher.Nome);
                Console.WriteLine(mulher.Idade);
                Console.WriteLine(mulher.Peso);
                Console.WriteLine(mulher.Altura);
                Console.WriteLine(mulher.Signo);
                Console.WriteLine(mulher.CalcularIMC());
                Console.WriteLine(mulher.ResultadoIMC());

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();


            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();





            Console.ReadLine();
            
        }
    }
}
   



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    public class Program
    {
        public static List<Nomedocliente> Nomes = new List<Nomedocliente>();
        static void Main(string[] args)
        {
            Nomes.Add(new Nomedocliente { Clientname = "Haimon", Sexo = "Masculino" });

            Cliente();
            Console.ReadKey();
        }
        public static void Cliente()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            string sexo = Console.ReadLine();
            Nomedocliente cliente = null;

            foreach(Nomedocliente ndc in Nomes)
            {
                if (ndc.Clientname == nome && ndc.Sexo == sexo)
                {
                    cliente = ndc;
                    Console.WriteLine($"\n{cliente.Clientname} acabou de logar!!!\n");

                    foreach (var dados in Nomes) //Apenas uma confirmação que o usuario logou!
                    {
                        Console.WriteLine(dados.Clientname);
                        Console.WriteLine(dados.Sexo);
                    }
                }         
            }
        }
    }
    public class Nomedocliente
    {
        public string Clientname { get; set; }
        public string Sexo { get; set; }

        public Nomedocliente()
        {

        }
        public Nomedocliente(string clientname, string sexo) : this()
        {
            Clientname = clientname;
            Sexo = sexo;
        }
    }
}

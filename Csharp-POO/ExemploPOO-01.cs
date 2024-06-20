using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO_01
{
    internal class Carro
    {
            string modelo="Fusca 1600", fabricante ="Volkswagem", nome ="Fusca", cor ="Azul";
            int ano = 1974;
        public static void Main(string[] args)
        {
            Carro carro01 = new Carro();
            Carro carro02 = new Carro();

            Console.WriteLine(carro01.nome);
            Console.WriteLine(carro02.nome);
            Console.WriteLine(carro01.modelo);
            Console.WriteLine(carro02.modelo);
            Console.WriteLine(carro01.cor);
            Console.WriteLine(carro02.cor);
            Console.WriteLine(carro01.fabricante);
            Console.WriteLine(carro02.fabricante);
            Console.WriteLine(carro01.ano);
            Console.WriteLine(carro02.ano);
        }
    }
}

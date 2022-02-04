using System;

namespace Imobiliaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um 
            algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
             */
            double largura=0, comprimento =0, resultado =0; 

            Console.WriteLine("Informe o Comprimento do terreno:");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura do terreno:");
            comprimento = Convert.ToDouble(Console.ReadLine());

            resultado = comprimento * largura;

            Console.WriteLine("A Area eh: "+ resultado+"²");

            Console.ReadLine();

        }
    }
}

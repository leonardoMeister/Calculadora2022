using System;

namespace DiasDeVida2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir 
            quantos dias de vidaela possui. Considere sempre anos completos, e que um 
            ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
            um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
            */

            Console.WriteLine("Informe a idade em anos:");
            double idade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seus dias vividos: "+idade*365);
            Console.ReadLine();

        }
    }
}

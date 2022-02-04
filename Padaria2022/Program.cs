using System;

namespace Padaria2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A padaria Hotpão vende uma certa quantidade de pães franceses e uma
                quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
                1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães 
                e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
                arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
                nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
                depois calcularos dados solicitados. 
             */
            double porcentagem=0, broa=0, paes=0, soma = 0;

            Console.WriteLine("informe o numero de pães vendidos: ");
            paes = Convert.ToDouble(Console.ReadLine())*0.12;
            Console.WriteLine("informe o numero de broas vendidas: ");
            broa = Convert.ToDouble(Console.ReadLine()) *1.50;

            soma = paes + broa;
            porcentagem = soma * 0.1;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Resultados:\nBroa: {broa}$\nPaes: {paes}$\nTotal: {soma}$\n10 % do total: {porcentagem}$");
            Console.ReadLine();
            
        }
    }
}

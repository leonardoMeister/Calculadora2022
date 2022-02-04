using System;

namespace Calcula2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado =0;
            Console.WriteLine("Seja Bem Vindo: " + Environment.UserName+"\n");
            do
            {
                string opcao = "";

                //----------------------------------------------PEGANDO OPÇÃO DO MENU
                Console.WriteLine("Selecione a opcao desejada:\n (1) Somar\n (2) Subtrair\n" +
                " (3) Dividir\n (4) Multiplicar\n (S) Sair");
                opcao = Console.ReadLine();
                
                //--------------------------------------------BUG MENU
                if( !(opcao == "1" || opcao =="2" ||opcao =="3"|| opcao=="4" || opcao.ToLower() =="s" ) )
                {
                    Console.WriteLine("Opção invalida, favor tentar novamente.\n Press enter...");
                    Console.ReadLine();
                    continue;
                } 
                //------------------------------------------SAINDO CASO OPÇÃO SEJA S
                if (opcao.ToLower() == "s") break;

                //--------------------------------------PEGANDO PRIMEIRO VALOR
                Console.WriteLine("Informe o primeiro valor: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                //------------------------------------------BUG DO ZERO
                do
                {
                    //--------------------------------------PEGANDO SEGUNDO VALOR
                    Console.WriteLine("Informe o segundo valor: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    if (opcao == "3" && numero2 == 0)
                    {
                        Console.WriteLine("Valor invalido, Favor não usar 0.\n Press Enter...");
                        Console.ReadLine();
                    }
                    else break;
                    
                } while (true);
                
                //---------------------------------------------REALIZANDO A CONTA
                if (opcao == "1") resultado = numero1+ numero2;
                if (opcao == "2") resultado = numero1 - numero2;
                if (opcao == "3") resultado = numero1 / numero2;
                if (opcao == "4") resultado = numero1 * numero2;

                //---------------------------------------------MOSTRANDO RESULTADO
                Console.WriteLine("O resultado eh: "+resultado+"\n Press Enter...");
                Console.ReadLine();

            } while (true);
        }
    }
}

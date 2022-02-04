using System;

namespace SalariaComImposto2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
              Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
              com o aumento e o salário final.
             */

            Console.WriteLine("Informe o salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salario15 = salario * 1.15;
            double salario15Menos8 = salario15 - salario15 * 0.08;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Resultados: \nSalario Inicial: {salario}\nSalario aumentado: {salario15}\nSalario Final: {salario15Menos8}");

        }
    }
}

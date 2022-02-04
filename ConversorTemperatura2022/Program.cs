using System;

namespace ConversorTemperatura2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              Alguns países medem temperaturas em graus Celsius, e outros em graus
              Fahrenheit. Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
              Fahrenheit (pesquise como fazer estetipo de conversão).
             */

            Console.WriteLine("Informe a temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            double resultado = ((temperatura * 9) / 5) + 32;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}

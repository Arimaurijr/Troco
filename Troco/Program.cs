using System;
using System.Globalization;
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double conta = 0.0, valor = 0.0;
            int quociente = 0, resto = 0;
            Console.WriteLine("Digite o valor da conta:");
            conta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor recebido:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor = valor - conta;
            if (valor >= 100.00)
            {
                quociente = (int)valor / 100;
                Console.WriteLine("quantidade de notas de 100: " + quociente);
                valor = valor % 100;
            }
            if (valor >= 50.00)
            {
                quociente = (int)valor / 50;
                Console.WriteLine("quantidade de notas de 50: " + quociente);
                valor = valor % 50;
            }
            if (valor >= 20.00)
            {
                quociente = (int)valor / 20;
                Console.WriteLine("quantidade de notas de 20: " + quociente);
                valor = valor % 20;
            }
            if (valor >= 10)
            {
                quociente = (int)valor / 10;
                Console.WriteLine("quantidade de notas de 10: " + quociente);
                valor = valor % 10;
            }
            if (valor >= 5)
            {
                quociente = (int)valor / 5;
                Console.WriteLine("quantidade de notas de 5: " + quociente);
                valor = valor % 5;
            }
            if (valor >= 2)
            {
                quociente = (int)valor / 2;
                Console.WriteLine("quantidade de notas de 2: " + quociente);
                valor = valor % 2;
            }
            if (valor == 1)
            {
                Console.WriteLine("E uma moeda de 1 real");
            }
        }
    }
}

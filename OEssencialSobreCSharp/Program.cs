using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEssencialSobreCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2, resultado;
            //char operacao;

            //Console.Write("Informe o primeiro número: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Informe a operação(+,-,/,*): ");
            //operacao = Convert.ToChar(Console.ReadLine());

            //Console.Write("Informe o segundo número: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (operacao == '+')
            //    resultado = num1 + num2;
            //else if (operacao == '-')
            //    resultado = num1 - num2;
            //else if (operacao == '/')
            //    resultado = num1 / num2;
            //else
            //    resultado = num1 * num2;

            //Console.WriteLine($"{num1} {operacao} {num2} = {resultado}");

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i+1);
            //}

            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe o elemento da posição {i}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }


                Console.ReadKey();
        }
    }
}

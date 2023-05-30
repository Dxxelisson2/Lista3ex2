using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor1;
            double valor2;


            
                Console.WriteLine("Digite o valor 1 ");
                valor1 = double.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("Digite o Valor 2 ");
                valor2 = double.Parse(Console.ReadLine());


                if (valor1 >= valor2)
                {

                    Console.WriteLine("valor 1 e maior que o 2 Erro ");
                }
                else
                    Console.WriteLine("Parabens valor 2 e maior ");
            }
            while (valor1 >= valor2);
            
        }
    }
}

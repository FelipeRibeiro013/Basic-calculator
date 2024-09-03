using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {//start


            double result = 0;
            double high = 2;
            double num2 = 0;

            Console.WriteLine("Digite o primeiro numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a operação (+, -, *, /, ²)");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (op == '²'){
                result = num1 * high;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Digite o segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine();
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine();
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine();
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine();
                    break;
                case '²':
                    break;

                default:
                    Console.WriteLine("Essa operação não existe");
                    break;
            }

            Console.WriteLine("RESULTADO: " + result);
            Console.ReadKey(); 
            
        }//end
    }
}

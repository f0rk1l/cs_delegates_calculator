using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalculator
{
    class Program
    {

        public delegate int CalculatorDelegate(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            CalculatorDelegate calculatorDelegate;

            while (true)
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int second_number = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n\nChoose action:\n\n[1] +\n\n[2] -\n\n[3] *\n\n[4] /\n\nChoose: ");
                int Choose = Convert.ToInt32(Console.ReadLine());

                switch (Choose)
                {
                    case 1:

                        calculatorDelegate = new CalculatorDelegate(Add);

                        Console.WriteLine($"\nResult: {calculatorDelegate(number, second_number)}\n");

                        break;

                    case 2:

                        calculatorDelegate = new CalculatorDelegate(Minus);

                        Console.WriteLine($"\nResult: {calculatorDelegate(number, second_number)}\n");

                        break;

                    case 3:

                        calculatorDelegate = new CalculatorDelegate(Mult);

                        Console.WriteLine($"\nResult: {calculatorDelegate(number, second_number)}\n");

                        break;

                    case 4:

                        calculatorDelegate = new CalculatorDelegate(Divide);

                        Console.WriteLine($"\nResult: {calculatorDelegate(number, second_number)}\n");

                        break;

                    default:

                        Console.WriteLine("\n\nIncorrect choose!\n");

                        break;

                }

                Console.Write("Press some button to clear button...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

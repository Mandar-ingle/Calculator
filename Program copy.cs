using System;

namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double firstnumber;
            double secondnumber;
            double answer;
            String operation;

            Console.WriteLine("Calculator");
            Console.WriteLine("*************************");

            Console.WriteLine("Enter first number\n");
            firstnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("select operation:(+,-,*,/,%,^)\n");
            operation = Console.ReadLine();

            Console.WriteLine("Enter second number\n");
            secondnumber = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (operation=="+")
            {
                answer = firstnumber + secondnumber;
                Console.Write("="+answer);
            }
            if (operation == "-")
            {
                answer = firstnumber - secondnumber;
                Console.Write("=" + answer);
            }
            if (operation == "*")
            {
                answer = firstnumber * secondnumber;
                Console.Write("=" + answer);
            }
            if (operation == "/")
            {
                answer = firstnumber / secondnumber;
                Console.Write("=" + answer);
            }
            if (operation == "%")
            {
                answer = firstnumber % secondnumber;
                Console.Write("=" + answer);
            }
            Console.Write("\n" + "press key to exit");
            Console.ReadKey();

        }
    }
}

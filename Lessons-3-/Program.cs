using System;
namespace lessons
{
    /*
       *Сalculator
       */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondVale;
                string action;

                try
                {
                    Console.WriteLine("Enter number 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number 2");
                    secondVale = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid format");
                    Console.ReadLine();
                }

                Console.WriteLine("Choose an operation '+' '-' '*' '/' ");
                action = Console.ReadLine();
                continue;

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondVale);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondVale);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondVale);
                        break;
                    case "/":
                        if (secondVale == 0)
                        {
                            Console.WriteLine(0);

                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondVale);
                        }
                        break;

                    default:
                        Console.WriteLine("Error! Unknown action!");
                        break;

                }

                Console.ReadLine();
            }
        }
    }
}
/*
 * Kalkulator
 */
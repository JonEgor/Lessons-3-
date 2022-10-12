using System;
namespace lessons
{
    /*
       *Калькулятор
       */
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondVale;
            string action;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondVale = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+' '-' '*' '/' ");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(firstValue + secondVale);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstValue - secondVale);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstValue * secondVale);
            }
            else if (action == "/")
            {
                if (secondVale == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstValue / secondVale);

            }
            else
            {
                Console.WriteLine("Ошибка! Неизветсное действие!");
            }
            Console.ReadLine();
        }
    }
}
/*
 * Kalkulator
 */
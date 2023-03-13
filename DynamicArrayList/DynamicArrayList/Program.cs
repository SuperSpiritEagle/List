using System;
using System.Collections.Generic;

namespace DynamicArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string commandSum = "sum";
            string commandExit = "exit";
            string commanPrint = "print";
            string commandDelete = "delete";
            string userInput = "";

            Console.WriteLine($"Введите [{commandSum}] для сложения введенных чисел,\n" +
                              $"введите [{commanPrint}] чтобы вывести все введенные числа,\n" +
                              $"введите [{commandDelete}] чтобы удалить последнее введенное число,\n" +
                              $"введите [{commandExit}] чтобы выйти из программы.\n");

            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

            Console.Clear();

            while (userInput != commandExit)
            {
                Console.WriteLine($"enter a number [{commandSum}][{commanPrint}][{commandDelete}][{commandExit}]");
                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput == commandSum)
                {
                    int sum = Sum(numbers);

                    Console.WriteLine(sum);
                }
                else if (userInput == commanPrint)
                {
                    Print(numbers);
                }
                else if (userInput == commandDelete)
                {
                    DeleteLastNumber(numbers);
                }
                else
                {
                    addNumber(numbers, userInput);
                }
            }
        }

        private static void addNumber(List<int> numbers, string userInput)
        {
            if (int.TryParse(userInput, out int number))
            {
                numbers.Add(number);
            }
        }

        private static void DeleteLastNumber(List<int> numbers)
        {
            if (numbers.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("нет чисел");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static int Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static void Print(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}

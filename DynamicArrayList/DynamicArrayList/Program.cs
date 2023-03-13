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

            while (userInput != commandExit)
            {
                Console.WriteLine($"Введите [{commandSum}] для сложения введенных чисел,\n" +
                                  $"введите [{commanPrint}] чтобы вывести все введенные числа,\n" +
                                  $"введите [{commandDelete}] чтобы удалить последнее введенное число,\n" +
                                  $"введите [{commandExit}] чтобы выйти из программы.\n");

                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput == commandSum)
                {
                    ShowSum(numbers);
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
                    AddNumber(numbers, userInput);
                }
            }
        }

        private static void AddNumber(List<int> numbers, string userInput)
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
                Console.WriteLine("нет чисел" + "\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum+"\n");
        }

        private static void Print(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n");
        }
    }
}

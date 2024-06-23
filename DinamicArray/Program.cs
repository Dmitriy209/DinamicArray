using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ButtonSum = "sum";
            const string ButtonExit = "exit";

            int[] numbers = new int[1];

            int sum = 0;

            bool isEndProgramm = false;

            string userInput;
            string helpMenu = "Введите число и оно добавится в массив.\n" +
                $"Введите {ButtonSum}, чтобы вывести сумму всех чисел в массиве.\n" +
                $"Введите {ButtonExit}, чтобы выйти из программы.";

            Console.WriteLine("Введите первое число:");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            while (isEndProgramm != true)
            {
                Console.WriteLine("Исходный массив:");

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
                Console.WriteLine(helpMenu);

                switch (userInput = Console.ReadLine().ToLower())
                {
                    case ButtonSum:
                        Console.Clear();

                        sum = 0;

                        foreach (int number in numbers)
                        {
                            sum += number;
                        }

                        Console.WriteLine($"Сумма всех чисел массива равна {sum}");
                        break;

                    case ButtonExit:
                        isEndProgramm = true;
                        break;

                    default:
                        Console.Clear();

                        int[] tempArray = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempArray[i] = numbers[i];
                        }

                        tempArray[tempArray.Length - 1] = Convert.ToInt32(userInput);
                        numbers = tempArray;
                        break;
                }
            }

            Console.WriteLine("Вы вышли из программы.");
        }
    }
}

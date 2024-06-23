using System;

namespace DinamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ButtonSum = "sum";
            const string ButtonExit = "exit";

            int[] numbers = new int[0];
            int[] tempNumbers = new int[numbers.Length + 1];

            bool isEndProgramm = false;

            string userInput;
            string helpMenu = "Введите число и оно добавится в массив.\n" +
                $"Введите {ButtonSum}, чтобы вывести сумму всех чисел в массиве.\n" +
                $"Введите {ButtonExit}, чтобы выйти из программы.";

            Console.WriteLine("Введите первое число:");
            tempNumbers[tempNumbers.Length - 1] = Convert.ToInt32(Console.ReadLine());
            numbers = tempNumbers;

            while (isEndProgramm == false)
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

                        int sum = 0;

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

                        tempNumbers = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }

                        tempNumbers[tempNumbers.Length - 1] = Convert.ToInt32(userInput);
                        numbers = tempNumbers;
                        break;
                }
            }

            Console.WriteLine("Вы вышли из программы.");
        }
    }
}

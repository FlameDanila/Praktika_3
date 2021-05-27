using System;
using System.Collections.Generic;

namespace Praktika_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Заполните массив через пробел для нахождения большего числа \nПример:\n'1 2 3'  =>  {1, 2, 3}");
                string word = Console.ReadLine();
                string[] words = { };
                int chislo = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    words = word.Split(' ');
                }
                for (int i = 0; i < words.Length; i++)
                {
                    if (chislo < Math.Abs(Convert.ToInt32(words[i])))
                    {
                        chislo = Math.Abs(Convert.ToInt32(words[i]));
                    }
                }
                Console.WriteLine(chislo);
                Console.Read();
            }

            {
                Console.WriteLine("Заполните массив через пробел для нахождения уникальных чисел\nПример:\n'1 2 3'  =>  {1, 2, 3}");
                string word = Console.ReadLine();
                string[] numbers = { };
                for (int i = 0; i < word.Length; i++)
                {
                    numbers = word.Split(' ');
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            Array.Clear(numbers, i, 1);
                            Array.Clear(numbers, j, 1);
                        }
                    }
                }
                foreach (var rav in numbers)
                {
                    Console.WriteLine(rav);
                }
            }

            {
                Random random = new Random();
                int[] numbers = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = random.Next(-100, 10);
                }
                foreach (var rav in numbers)
                {
                    Console.WriteLine($"{rav}");
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Convert.ToInt32(numbers[i]) < 0)
                    {
                        numbers[i] = 0;
                    }
                }
                Console.WriteLine("\n");
                foreach (var rav in numbers)
                {
                    Console.WriteLine($"{rav}");
                }
            }
        }
    }
}

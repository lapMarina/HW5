using System;

namespace HW5
{
    class Program
    {
        static int[] GetArray(int lenght, int min_value, int max_value)
        {
            int[] numbers = new int[lenght];
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                int random_int = random.Next(min_value, max_value);
                numbers[i] = random_int;
            }
            return numbers;
        }

        static int GetCountEvenNumbers(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    result++;
            }
            return result;
        }

        static int GetSumOddIndexes(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    result += array[i];
            }
            return result;
        }

        static int GetDiffBetweenMinAndMaxNumbers(int[] array) 
        {
            int min_value = array[0];
            int max_value = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min_value)
                    min_value = array[i];
                if (array[i] > max_value)
                    max_value = array[i];
            }
            return max_value - Math.Abs(min_value);
        }
            
        static void FirstTask() 
        {
            Console.WriteLine("Первое задание");
            Console.WriteLine("Введите число, которое будет указывать длину массива");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(lenght, 100, 999);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine("\n");
            Console.WriteLine(GetCountEvenNumbers(array));
        }

        static void SecondTask() 
        {
            Console.WriteLine("Второе задание");
            Console.WriteLine("Введите число, которое будет указывать длину массива");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальный диапазон");
            int min_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальный диапазон");
            int max_value = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(lenght, min_value, max_value);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine("\n");
            Console.WriteLine(GetSumOddIndexes(array));
        }

        static void ThirdTask() 
        {
            Console.WriteLine("Третье задание");
            Console.WriteLine("Введите число, которое будет указывать длину массива");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальный диапазон");
            int min_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальный диапазон");
            int max_value = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(lenght, min_value, max_value);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine("\n");
            Console.WriteLine(GetDiffBetweenMinAndMaxNumbers(array));
        }

        static void Main(string[] args)
        {

            FirstTask();
            SecondTask();
            ThirdTask();
        }
    }
}

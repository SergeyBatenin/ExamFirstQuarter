using System;
class Program
{
    static void Main()
    {
        string[] baseArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };

        // Посчитать количество валидных элементов в начальном массиве
        int size = CountValidElements(baseArray);

        // Создать итоговый массив на основе количества валидных элементов
        string[] resultArray = new string[size];

        // Заполнить массив валидными элементами (main algorithm)
        FillArray(baseArray, resultArray, size);

        // Вывести на печать начальный массив
        PrintArray(baseArray);
        Console.WriteLine();

        // Вывести итоговый массив
        PrintArray(resultArray);
    }

    static void FillArray(string[] baseArray, string[] resultArray, int size)
    {
        if (size > 0)
        {
            int index = 0;
            int length = baseArray.Length;
            for (int indexBase = 0; indexBase < length; indexBase++)
            {
                if (baseArray[indexBase].Length < 4)
                {
                    resultArray[index] = baseArray[indexBase];
                    index++;
                }
            }
        }
    }

    static int CountValidElements(string[] array)
    {
        int count = 0;
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            if (array[i].Length < 4) count++;
        }

        return count;
    }

    static void PrintArray(string[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            Console.Write($"\"{array[i]}\" ");
        }
        Console.WriteLine();
    }
}
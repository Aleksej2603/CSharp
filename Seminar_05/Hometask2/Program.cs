// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

// using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
        int[] tmpRow1 = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            tmpRow1[i] = array[0, i];
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[0, i] = array[array.GetLength(0) - 1, i];
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[array.GetLength(0) - 1, i] = tmpRow1[i];
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        return array;
    }

    // // Обмен элементами массива
    //     public static void SwapItems(int[,] array, int i)
    //     {
    //        //Напишите свое решение здесь
    //     }

    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        SwapFirstLastRows(numbers);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {3, 4, 9, 1},
                {5, 6, 7, 8},
                {2, 2, 8, 0}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
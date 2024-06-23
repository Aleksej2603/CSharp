// Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    // Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        int res = 0;
        if (x <= array.GetLength(0) && y <= array.GetLength(1))

        {
            res = array[x - 1, y - 1];
            System.Console.WriteLine(res);
        }
        return res;
    }

    // Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        if (x <= array.GetLength(0) && y <= array.GetLength(1))
            return true;
        if (x > array.GetLength(0))
        {
            System.Console.WriteLine("Позиция элемента по рядам за пределами массива");
        }
        if (y > array.GetLength(1))
        {
            System.Console.WriteLine("Позиция элемента по столбцам за пределами массива");
        }
        return false;
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
        if (ValidatePosition(numbers, 3, 3))
        {
            FindElementByPosition(numbers, 3, 3);
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {

            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;

            UserInputToCompileForTest.PrintResult(array, x, y);

        }
    }
}

// void Main()
// {
//     int row = ReadInt("Ввведите количество строк: ");
//     int col = ReadInt("Ввведите количество столбцов: ");
//     int[,] matrix = GenerateMatrix(row, col, 0, 10);
//     PrintMatrix(matrix);

//     System.Console.WriteLine();

//     //PrintResult(matrix);
//     int x = 2;
//     int y = 2;
//     if (x < 0 | x > matrix.GetLength(0) - 1)
//     {
//         System.Console.WriteLine("Позиция элемента по рядам за пределами массива");
//     }
//     if (y < 0 | y > matrix.GetLength(1) - 1)
//     {
//         System.Console.WriteLine("Позиция элемента по столбцам за пределами массива");
//     }
//     if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))
//     {
//         //FindElementByPosition(matrix, 2, 2);
//         int res = 0;
//         if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))

//         {

//             res = matrix[x - 1, y - 1];
//             System.Console.WriteLine(res);

//         }
//     }

// }

// // void PrintResult(int[,] matrix)
// // {
// //     if (!ValidatePosition(matrix, 2, 2))
// //     {
// //         FindElementByPosition(matrix, 2, 2);
// //     }
// // }

// void PrintMatrix(int[,] matrixForPrint)
// {
//     for (int i = 0; i < matrixForPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixForPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixForPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }

// }

// bool ValidatePosition(int[,] arr, int x, int y)
// {
//     // if (x <= arr.GetLength(0) - 1 && y <= arr.GetLength(1) - 1)
//     //     return true;
//     if (x < 0 | x > arr.GetLength(0) - 1)
//     {
//         System.Console.WriteLine("Позиция элемента по рядам за пределами массива");
//     }
//     if (y < 0 | y > arr.GetLength(1) - 1)
//     {
//         System.Console.WriteLine("Позиция элемента по столбцам за пределами массива");
//     }

//     return false;
// }

// int FindElementByPosition(int[,] matrix, int x, int y)
// {
//     int res = 0;
//     if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))

//     {

//         res = matrix[x - 1, y - 1];
//     }
//     return res;
// }

// int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] tempMatrix = new int[rows, cols];
//     Random rand = new Random();

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);

//     return tempMatrix;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Main();




// int[,] matrix = { { 2, 3, 1 }, { 0, 6, 4 }, { 4, 2, 3 } };
// int x = 3;
// int y = 2;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write(matrix[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))
// {

//     System.Console.WriteLine(matrix[x-1, y-1]);
// }
// else if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
// {

//     System.Console.WriteLine("Нет такого элемента");
// }
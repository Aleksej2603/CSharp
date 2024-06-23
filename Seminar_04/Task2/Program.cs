// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Main()
{
    int row = ReadInt("Ввведите количество строк: ");
    int col = ReadInt("Ввведите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 100, 999);

    PrintMatrix(matrix);
    System.Console.WriteLine(SumOfEvenNum(matrix));
}

int SumOfEvenNum(int[,] matrix)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0)
            {
                sum++;
            }
        }
    }
    return sum;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);

    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
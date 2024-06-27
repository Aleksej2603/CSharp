// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int size = ReadInt("Укажите размер матрицы: ");
    int[] array = GenerateArray(size, 0, 10);

    PrintMatrix(array);
    ReverseArray(array);
}

void ReverseArray(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        System.Console.Write(arr[i] + "\t");
    }
    System.Console.WriteLine();
}

void PrintMatrix(int[] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.Length; i++)
    {
        System.Console.Write(matrixForPrint[i] + "\t");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tmp = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tmp[i] = rand.Next(minValue, maxValue + 1);
    return tmp;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
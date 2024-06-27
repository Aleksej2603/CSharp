// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int size = ReadInt("Укажите длину массива: ");
    int[] array = GenerateArray(size, 1, 10);

    PrintArray(array);
    System.Console.WriteLine();
    PrintArr(array);
}

void PrintArray(int[] arr, int i=0)
{
    if (i >= arr.Length) return;

    Console.Write(arr[i] + " ");
    PrintArray(arr, i + 1);
}

void PrintArr(int[] arr2, int i = 0)
{
    if(i != arr2.Length) {
        PrintArr(arr2, i + 1);
        Console.Write(arr2[i] + " ");
    }
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = rnd.Next(minValue, maxValue + 1);
    return arr;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
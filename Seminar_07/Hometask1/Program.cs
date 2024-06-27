// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{

    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    PrintNumbers(M, N);

}

void PrintNumbers(int i, int N)
{
    { 
        if (i <= N) 
        { 
            Console.Write(i + " "); 
            PrintNumbers(i + 1, N); 
        } 
    } 
}

int ReadInt(string msg)
{
    System.Console.Write(msg);

    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


Main();
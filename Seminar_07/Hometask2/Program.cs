﻿// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// Пример
// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите M: ");
    int n = ReadInt("Введите N: ");

    System.Console.WriteLine(A(m, n));

}

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);

    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Программа завершается при вводе числа, с четной суммой, с символом 'q' возникла проблема 

void Main()
{
   do
    {
        int input = ReadInt("Введите целое число число либо 'q' для выхода: ");
        if (SumOfDigit(input) % 2 == 0)
        break;
    }
    while (true);
}

// bool Exit(ConsoleKeyInfo key)
// {
//     key = Console.ReadKey();

//     if(key.Key == ConsoleKey.q)
//     break;
// }
// bool Exit(input)
// {
//     if (SumOfDigit % 2 ==0)
//     {
//         return true;
//     }
//     return false;
// }

int SumOfDigit(int input)
{
    int sum = 0;
    while (input > 0)
    {
        sum += input % 10;
        input /= 10;
    }
    return sum;
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
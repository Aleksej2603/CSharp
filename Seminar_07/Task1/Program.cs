//Нпишите программу, которая будет
//принимать на вход число и 
//возвращать сумму его цифр

//Указание
//Использовать рекурсию

//Пример
//123 => 6
//63 => 9

void Main()
{

    int number = ReadInt("Введите число: ");
    SumNumbers(number);
    System.Console.WriteLine(SumNumbers(number));

}

int SumNumbers(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNumbers(number / 10);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
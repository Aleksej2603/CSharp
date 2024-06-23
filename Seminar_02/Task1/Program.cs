// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.

System.Console.Write("Введите число: ");

int result = Convert.ToInt32(Console.ReadLine());
{
    if (result % 7 == 0 && result % 23 == 0)
    {
        System.Console.WriteLine("Число кратное");
    }
    else
    {
        System.Console.WriteLine("Число не кратное");
    }
}
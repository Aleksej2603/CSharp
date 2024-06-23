// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной
// четверти плоскости, в которой находится эта точка.

System.Console.Write("ВВедите значение X: ");
int X = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите значение Y: ");
int Y = Convert.ToInt32 (Console.ReadLine());

if (X > 0 && Y >0)
{
    System.Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    System.Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    System.Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    System.Console.WriteLine("4");
}
else 
{
    System.Console.WriteLine("Значения не должны быть равны 0");
}
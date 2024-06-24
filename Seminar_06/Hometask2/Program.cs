//Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
void Main()
{

    System.Console.Write("Введите строку: ");
    string? str = Console.ReadLine();

    str = str!.ToLower();
    System.Console.WriteLine(str);

}

Main();

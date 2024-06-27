//Считать строку с консоли, содержащую латинские буквы.
//Вывести на экран согласные буквы этой строки.
//Указание
//Использовать рекурсию. не использовать цикл.
//Пример
//"hello" => h l l
//"World" => W r l d
//"Hello World!" => H l l W r l d

void Main()
{
System.Console.Write("Введите текст: ");
string? str = Console.ReadLine();
PrintConsonants(str);
}

void PrintConsonants(string? str)
{
if(str!.Length == 0) return;

char tempChar = char.ToLower(str[0]); // c <= C

if(isConsonant(tempChar))
System.Console.Write(str[0] + " ");

PrintConsonants(str[1..]);
}

bool isConsonant(char c)
{
return "bcdfghjklmnpqrstvwxz".Contains(c);
}

Main();



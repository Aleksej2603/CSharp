// На основе символов строки (тип string) сформировать массив символов (тип char[]).
// Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

void Main()
{
System.Console.Write("Введите строку: ");
string? str = Console.ReadLine();
char[] chars = StringToCharArray(str);
PrintArray(chars);
}

void PrintArray(char[] chars)
{
Console.WriteLine("[" + string.Join(", ", chars) + "]");
}

char[] StringToCharArray(string? inputString)
{
char[] chars = new char[inputString!.Length];

for (int i = 0; i < chars.Length; i++)
chars[i] = inputString[i];

return chars;
}

Main();
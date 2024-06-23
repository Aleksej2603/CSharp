// Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] letters = { 'a', 'b', 'c', 'd' };

// 1-й способ:
// string str = new string(chars);

// 2-й способ:
// string str = "";
// foreach (char letter in letters)
// str += letter;

// 3-й способ:
// string str = string.Join("", letters);

// 4-й способ:
string str = string.Concat(letters);

System.Console.WriteLine(str);
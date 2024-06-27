// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива
void Main()
{
    char[,] chars = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

    PrintString((FromArrayToString(chars)));

}
//Вывод строки
void PrintString(string str)
{
    System.Console.WriteLine(str);
}

//Получение строки из двумерного массива
string FromArrayToString(char[,] str)
{
    string arr = "";
    for (int i = 0; i < str.GetLength(0); i++)
    {
        for (int j = 0; j < str.GetLength(1); j++)
        {
            arr += str[i, j];
        }
    }
    //System.Console.WriteLine(arr + "");
    return arr;
}


Main();
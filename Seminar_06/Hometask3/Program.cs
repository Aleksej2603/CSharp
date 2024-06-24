// Задайте произвольную строку. Выясните, является ли она палиндромом.
void Main()
{
    System.Console.Write("Введите строку: ");
    string? str = Console.ReadLine();
    //string? rev = "";
    char[] res = str!.ToCharArray();
    if (IsPalindrom(res))
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }

    // for (int i = str!.Length - 1; i >= 0; i--)
    // {
    //     rev += str[i];
    // }

    // if (str == rev)
    // {
    //     Console.WriteLine($"{str} is Palindrome.");
    // }
    // else
    // {
    //     Console.WriteLine($"{str} is not Palindrome");
    // }
}

static bool IsPalindrom(char[] word)
{
    for (int i = 0; i < word.Length / 2; i++)
        if (word[i] != word[word.Length - 1 - i])
            return false;
    return true;
}

Main();
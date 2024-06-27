
void Main()
{
    System.Console.Write("Введите строку: ");
    string? str = Console.ReadLine();
    System.Console.WriteLine(CountVowels(str));
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);
}

int CountVowels(string? inStr)
{
    int count = 0;
    inStr = inStr!.ToLower();

    foreach (char c in inStr)
    {
        if (isVowel(c))
            count++;
    }
    return count;
}

Main();

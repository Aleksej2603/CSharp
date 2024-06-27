int number, result = 0;

Console.Write("enter number: ");
number = Covert.ToInt32(Console.ReadLine());

while (number > 0)
{
  result *= 10;
  result += number % 10;
  number /= 10;
}

Console.WriteLine(result);
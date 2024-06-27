// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.


Console.Write("Введите натуральное число N в диапозоне от 1 до 100000: ");


int num = Convert.ToInt32(Console.ReadLine());
int n = 0;

while (num > 0)
{
    num /= 10;
    n++;
}

int[] numbers = new int[n];

for (int i = 0; i < n - 1; i++)
{

}


if (num < 10)
{
    Console.Write(num);
}
else
{
    while (num > 0)
    {
        int result = num % 10;
       num /= 10;
        if (num > 0)
        {
            Console.Write(result + ", ");
        }
        else
        {
            Console.Write(result);
        }
    }
}

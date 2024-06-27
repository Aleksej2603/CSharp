// Напишите программу, которая на вход 
// принимает натуральное число N, а на 
// выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverseNum = 0;

while (num > 0)
{
//     reverseNum *= 10;
//     reverseNum += num % 10;
//     num /= 10;
// }
// if (reverseNum < 10)
// {
//     Console.Write(reverseNum);
// }
// else
// {
    //while (reverseNum > 0)
    //{
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
    //}
}
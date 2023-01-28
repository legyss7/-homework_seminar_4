/* Задача 27: Напишите программу, которая принимает на
 вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int EnteringNumbers()
{
    int num;
    Console.Write("Введите целое число: ");
    while (! int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ошибка! Введенное число содержит символ.");
        Console.WriteLine("****************************************");
        Console.Write("Введите целое число: ");
    }
    return num;
}

int Sum(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    while(num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Сумма цифр во введенном числе равна {0}", Sum(EnteringNumbers()));

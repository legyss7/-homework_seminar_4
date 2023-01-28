/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int[] EnteringNumbers()
{
    int[] numbers = new int[2];
    string[] subStr;
link:
    while (true)
    {
        Console.WriteLine("Введите целое число A и натуральное число B через запятую: ");
        string str = Console.ReadLine() ?? String.Empty;
        subStr = str.Split(',');
        if (subStr.Length == 2) break;
        Console.WriteLine("Ошибка! Формат ввода не соответствует заданному.");
        Console.WriteLine("************************************************");
    }

    string[] info = { "A", "B" };
    for (int i = 0; i < numbers.Length; i++)
    {

        if (int.TryParse(subStr[i], out numbers[i]))
        {
            if (i == 1) // Проверяем второе число на натуральность
                if (numbers[i] <= 0)
                {
                    Console.WriteLine("Ошибка! Число " + info[i] + " не является натуральным.");
                    Console.WriteLine("******************************************************");
                    goto link;
                }
        }
        else
        {
            Console.WriteLine("Ошибка! Число " + info[i] + " содержит символ.");
            Console.WriteLine("**********************************************");
            goto link;
        }
    }
    return numbers;
}

string Pow(int[] num)
{
    string str = String.Empty;
    int mul = 1;
    for (int i = 1; i <= num[1]; i++)
        mul *= num[0];

    if (mul == 0 && num[0] != 0 || mul < 0 && num[0] > 0)
        str = "Ошибка! Переполнение разрядной сетки (-2 147 483 648 ... 2 147 483 647)";
    else str = $"Число A {num[0]} возведенное в степень B {num[1]} равно {mul}";

    return str;
}

Console.WriteLine(Pow(EnteringNumbers()));

/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a;
int b;
EnteringNumbers();
Console.WriteLine("Число A ({0}) возведенное в степень B ({1}) равно {2}", a, b, Pow(a, b));


void EnteringNumbers()
{
    int[] numbers = new int[2];
    string[] subStr;

    while (true)
    {
        Console.WriteLine("Введите целое число A и натуральное число B через запятую: ");
        string str = Console.ReadLine() ?? String.Empty;
        subStr = str.Split(',');
        if (subStr.Length == 2)
        {
            if (int.TryParse(subStr[0], out a))
            {
                if (int.TryParse(subStr[1], out b))
                {
                    if (b > 0) break;
                    else
                    {
                        Console.WriteLine("Ошибка! Число B не является натуральным.");
                        Console.WriteLine("****************************************");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Число B содержит символ.");
                    Console.WriteLine("********************************");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Число A содержит символ.");
                Console.WriteLine("********************************");

            }
        }
        else
        {
            Console.WriteLine("Ошибка! Формат ввода не соответствует заданному.");
            Console.WriteLine("************************************************");
        }
    }
}

int Pow(int a, int b)
{
    string str = String.Empty;
    int mul = 1;
    for (int i = 1; i <= b; i++)
        mul *= a;
    return mul;
}



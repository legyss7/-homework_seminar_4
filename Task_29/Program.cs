/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 

Напишите программу в которой пользователь задает размер массива
и диапазон чисел заполняющих массив по случайному закону.*/


int[] EnteringNumbers()
{
    int[] num = new int[3];
    Console.Write("Введите размер массива: ");
    while (!int.TryParse(Console.ReadLine(), out num[0]))
    {
        Console.WriteLine("Ошибка! Введенное число содержит символ.");
        Console.WriteLine("****************************************");
        Console.Write("Введите размер массива: ");
    }

    Console.Write("Введите нижний предел чисел для заполнения массива: ");
    while (!int.TryParse(Console.ReadLine(), out num[1]))
    {
        Console.WriteLine("Ошибка! Введенное число содержит символ.");
        Console.WriteLine("****************************************");
        Console.Write("Введите нижний предел значения для заполнения массива: ");
    }

    Console.Write("Введите верхний предел чисел для заполнения массива: ");
    while (!int.TryParse(Console.ReadLine(), out num[2]))
    {
        Console.WriteLine("Ошибка! Введенное число содержит символ.");
        Console.WriteLine("****************************************");
        Console.Write("Введите верхний предел чисел для заполнения массива: ");
    }

    return num;
}

int[] FillingArray(int[] numbersConfig)
{
    int[] array = new int[numbersConfig[0]];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(numbersConfig[1], numbersConfig[2] + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    //Console.WriteLine($"Полученный массив [{string.Join(", ", array)}]");
    Console.Write("Полученный массив [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b].");
}

PrintArray(FillingArray(EnteringNumbers()));
void Zadacha34()
// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве
{
    int size = 20;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    FindCount(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }

    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();

    }
    void FindCount(int[] nums)
    {
        int count = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                count = count + 1;
            }
        }
        Console.WriteLine("Количество чётных чисел в массиве:  " + count);
    }

}
// Zadacha34();

void Zadacha36()
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов 
// с нечётными индексами
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 10);
    PrintArray(numbers);
    FindResult(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }

    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();

    }
    void FindResult(int[] nums)
    {
        int result = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (i % 2 != 0)
            {
                result = result + nums[i];
            }
        }
        Console.WriteLine("Сумма элементов массива с нечётными индексами:  " + result);
    }

}
//Zadacha36();

void Zadacha38()
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
// массива
{
    int size = 7;
    double[] numbers = new double[size];
    Random rand = new Random();
    double divider = 100;

    for (int i = 0; i < size; i++)
    {
        // numbers[i] = rand.Next(1000, 10000)/divider;
        numbers[i] = Math.Round(rand.NextDouble() * 20 - 10, 2); // [0, 1] * 20 -->[0, 20] - 10 -->[-10, 10]
    }
    PrintArray(numbers);

    void PrintArray(double[] numbers)
    {

        int size = 7;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }

}


Zadacha38();
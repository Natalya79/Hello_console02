// Задача 47. Задать двумерный массив размером m x n, заполненный случайными вещественными числами,
// округлёнными до одного знака

void Zadacha47()

{
    int rows = 3;
    int colums = 4;
    double[,] numbers = new double[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(double[,] numbers)
    {
        Random rand = new Random();
        int rows = 3;
        int colums = 4;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
            }
        }
    }
    void PrintArray(double[,] numbers)
    {
        int rows = 3;
        int colums = 4;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }

    }
}
Zadacha47();

// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве и возвращает
// значение этого элемента или указание на то, что такого элемента нет

void Zadacha50()
{
    Console.WriteLine("Введите цифру номера строки");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите цифру номера столбца");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        Random rand = new Random();
        int rows = 3;
        int colums = 4;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

    void PrintArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {

                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    bool result = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (number1 == i + 1 && number2 == j + 1)
            Console.WriteLine($"Значение элемента {numbers[i, j]}");
            result = true;
        }
        Console.WriteLine();
    }
    if (result == false) return;
    Console.WriteLine($"Такого элемента в массиве нет"); // как добиться того, чтобы эта строчка не появлялась
    // при положительном результата, к сожалению, не знаю
    Console.WriteLine();
}

Zadacha50();

//52 Заполните двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
void Zadacha52()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers, 0, 100);
    PrintArray(numbers);


    void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }
    void PrintArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }

    }

    double res1 = 0;

    for (int j = 0; j < colums; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            res1 = res1 + numbers[i, j];

        }
        res1 = res1 / rows;
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {res1}");
        res1 = 0;
    }

}
Zadacha52();



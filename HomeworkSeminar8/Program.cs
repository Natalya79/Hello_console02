// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.

void Zadacha54()

{

    int[,] numbers = new int[3, 4];
    FillArray(numbers);
    Console.WriteLine("Массив, заполненный случайными числами");
    PrintArray(numbers);

    SortArray(numbers);
    Console.WriteLine("Отсортированный по убыванию массив");
    PrintArray(numbers);

    void FillArray(int[,] numbers)
    {
        Random rand = new Random();

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = rand.Next(1, 9);
            }
        }
    }

    void SortArray(int[,] numbers)
    {

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {

                for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1])
                    {
                        int temp = numbers[i, k + 1];
                        numbers[i, k + 1] = numbers[i, k];
                        numbers[i, k] = temp;
                    }
                }

            }
        }
    }

    void PrintArray(int[,] numbers)
    {

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }

    }
}
Zadacha54();

// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

void Zadacha56()

{
    Console.WriteLine("Введите количество строк массива");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите диапазон значений массива от 1 до  ");
    int r = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[m, n];
    FillArray(numbers);
    PrintArray(numbers);
   

    void FillArray(int[,] numbers)
    {
        Random rand = new Random();

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = rand.Next(1, r);
            }
        }
    }

    int min = 0;
    int Sum = SumLineElements(numbers, 0);
    for (int i = 1; i < numbers.GetLength(0); i++)
    {
        int temp = SumLineElements(numbers, i);
        if (Sum > temp)
        {
            Sum = temp;
            min = i;
        }
    }
    int SumLineElements(int[,] numbers, int i)
    {
        int sum = numbers[i, 0];
        for (int j = 1; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        return sum;
    }


    void PrintArray(int[,] numbers)
    {

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }

    }
     Console.WriteLine($"Номер строки с наименьшей суммой элементов {min+1}. Сумма элментов равна {Sum}");
}
Zadacha56();
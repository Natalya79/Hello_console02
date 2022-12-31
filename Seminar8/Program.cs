// //53 Заполните двумерный массив, поменяйте местами первую и последнюю строки
// void Zadacha53()
// {
//     int rows = 4;
//     int colums = 5;
//     int[,] numbers = new int[rows, colums];
//     FillArray(numbers);
//     PrintArray(numbers);

//     int indexMin = 0;
//     int indexMax = rows - 1;
//     for (int j = 0; j < colums; j++)
//     {
//         (numbers[indexMin,j], numbers[indexMax,j]) = (numbers[indexMax,j], numbers[indexMin,j]);
// //     }
// //     PrintArray(numbers);
// // } 
// // Zadacha53();

// // void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
// // {
// //     maxValue++;
// //     Random rand = new Random();
// //     int rows = numbers.GetLength(0);
// //     int colums = numbers.GetLength(1);
// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < colums; j++)
// //         {
// //             numbers[i, j] = rand.Next(minValue, maxValue);
// //         }
// //     }
// // }
// // void PrintArray(int[,] numbers, string message = "Вывод массива: ")
// // {
// //     int rows = numbers.GetLength(0);
// //     int colums = numbers.GetLength(1);
// //     Console.WriteLine(message);
// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < colums; j++)
// //         {

// //             Console.Write($"{numbers[i, j]}\t");
// //         }
// //         Console.WriteLine();
// //     }

// // }

// //53 Заполните двумерный массив, поменяйте местами строки и столбцы
// void Zadacha55()
// {
//     int rows = 4;
//     int colums = 4;
//     int[,] numbers = new int[rows, colums];
//     FillArray(numbers);
//     PrintArray(numbers);
//     PrintNewArray(numbers);


// }
// Zadacha55();

// void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
// {
//     maxValue++;
//     Random rand = new Random();
//     int rows = numbers.GetLength(0);
//     int colums = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             numbers[i, j] = rand.Next(minValue, maxValue);
//         }
//     }
// }
// void PrintArray(int[,] numbers, string message = "Вывод массива: ")
// {
//     int rows = numbers.GetLength(0);
//     int colums = numbers.GetLength(1);
//     Console.WriteLine(message);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {

//             Console.Write($"{numbers[i, j]}\t");
//         }
//         Console.WriteLine();
//     }

// }

// void PrintNewArray(int[,] numbers, string message = "Вывод нового массива: ")
// {
//     int rows = numbers.GetLength(0);
//     int colums = numbers.GetLength(1);
//     Console.WriteLine(message);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++) // ПОЧЕМУ????? j = i срезает новую таблицу
//         {
//             // int temp = numbers[i,j];
//             // numbers[i,j] = (numbers[j,i]);
//             // numbers[i,j] = temp;
//             // (numbers[i,j], numbers[j,i]) = (numbers[j,i], numbers[i,j]);
//             (numbers[i,j], numbers[j,i]) = (numbers[j,i], numbers[i,j]);
//             Console.Write($"{numbers[j, i]}\t");
//         }
//         Console.WriteLine();
//     }

// }

//57 Заполните двумерный массив, поменяйте местами строки и столбцы
void Zadacha57()
{
    int rows = 5;
    int colums = 5;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers, 0, 9);
    PrintArray(numbers);

    int[] dictionary = new int[10];

    PrintArray1(dictionary, "Вывод словаря:");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            dictionary[numbers[i, j]]++;
        }
    }
}
Zadacha57();

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


void PrintArray(int[,] numbers, string message = "Вывод массива: ")
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {

            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }

}

void PrintArray1(int[] numbers, string message = "Вывод массива: ")
{
    int rows = numbers.Length;

    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine($"число {i} встречается: {numbers[i]} раз(а)");
    }
    Console.WriteLine();
}


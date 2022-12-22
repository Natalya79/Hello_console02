//46 Заполните двумерный массив MxN
void Zadacha46()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers, - 100, 100);
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
                // Console.Write($"A[{i}, {j}] = {numbers[i, j]}   ");
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        
    }
}
// Zadacha46();

//48 Заполните двумерный массив MxN, каждый элемент находится по формуле A = i+J
void Zadacha48()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);


void FillArray(int[,] numbers)
{
    int A = 0;
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            A = i + j;
            numbers[i, j] = A;
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
                // Console.Write($"A[{i}, {j}] = {numbers[i, j]}   ");
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        
    }
}
//Zadacha48();

//49 Задайте двумерный массив, найдите элементы, у которых оба индексы чётные и замените их на их квадраты
void Zadacha49()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);
    PrintNewArray(numbers);

   
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
        Console.WriteLine("Изначальный массив"); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        
    }
 
 void PrintNewArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        Console.WriteLine("Новый массив"); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                if (i % 2 == 0 && j % 2 == 0)  numbers[i, j] = numbers[i, j] *  numbers[i, j];
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        
    }


}
//Zadacha49();


//51 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
void Zadacha51()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
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
        Console.WriteLine("Изначальный массив"); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        
    }
 
 
        int sum = 0;
         
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                if (i == j)  sum = sum + numbers[i, j];
                
            }
        }
        Console.Write($"Сумма элементов главной диагонали равна {sum}");
    

}
Zadacha51();
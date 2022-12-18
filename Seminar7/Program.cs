//46 Заполните двумерный массив MxN
void Zadacha46()
{
    int rows = 3;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    
    
    
}

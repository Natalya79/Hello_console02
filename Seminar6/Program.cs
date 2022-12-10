
// область для описания методов задач
void Zadacha39()
{
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    /*
    for (int i = size - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + "  ");
    }
    */

    int[] result = new int[size];
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)
    {
        result[maxIndex - i] = numbers[i]; // имеющийся массив перебирается поэлементно, ответы записываются во второй
    }
    PrintArray(result);

// второй способ
     for (int i = 0; i < size/2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex] = temp;
    }
    PrintArray(numbers);

}
// область для вспомогательных методов
void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    Random rand = new Random();
    int length = numbers.Length;

    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine("\n");
}
// область для написания кода
Zadacha39();
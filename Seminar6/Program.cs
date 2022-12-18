/*
// область для описания методов задач
void Zadacha39()
{
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size]; // в строках 5 и 7 после слова new идёт тип данных
    FillArray(numbers);
    PrintArray(numbers);

    
    for (int i = size - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + "  ");
    }
    

    int[] result = new int[size];
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)
    {
        result[maxIndex - i] = numbers[i]; // имеющийся массив перебирается поэлементно, ответы записываются во второй
    }
    PrintArray(result);

    // второй способ
    for (int i = 0; i < size / 2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex] = temp;
    }
    PrintArray(numbers);

    // способ кортеж
    for (int i = 0; i < size / 2; i++)
    {

        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);

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
*/

/*
void Zadacha40()
// напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// со сторонами такой длины

{
    int size = 3;
    int[] number = new int[size];
    int[] numberA = new int[size];
    FillArray(number);
    PrintArray(number);


    void FillArray(int[] numbers, int minValue = 1, int maxValue = 9)
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
        Console.WriteLine("Вывод сторон треугольника: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
        Console.WriteLine("\n");
    }

    numberA[0] = number[1] + number[2];
    numberA[1] = number[0] + number[2];
    numberA[2] = number[0] + number[1];
    bool result = false;

    for (int i = 0; i < size; i++)
    {
        if (number[i] < numberA[i]) result = true; // неверно. Похоже, программа проверяет соблюдение условия 
        // хотя бы для одной суммы, а не для всех. Треугольников со сторонами 8, 5 и 3 не бывает

    }
    if (result) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");
}
Zadacha40();
*/

/*
void Zadacha42()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int temp;
    string binary = string.Empty;
    while (number> 0)
    {
        temp = number%2;
        number = number/2;
        binary = temp.ToString() + binary;
    }
 Console.WriteLine($"Число в двоичном виде: {binary}");
}

Zadacha42();
*/
/*
int num = 5;
void Zadacha44(int num) // последовательность чисел Фибоначчи
{
    num -= 2;
    double firstNum = 0;
    double secondNum = 1;
    double result = 0;
    int count = 0;

    Console.Write(firstNum + "  " + secondNum + "  ");
   
    while (count < num)
    {
     result = firstNum + secondNum;
     Console.Write(result + " ");
     firstNum = secondNum;
     secondNum = result;
     count++;
    }
}

Zadacha44(num);
*/



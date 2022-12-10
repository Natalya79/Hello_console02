// Задача 25.Используя определение степени числа, напишите цикл, который принимает на вход два числа и А и В
//и возводит число А в степень числа В
void Zadacha25()
{

    Random rand1 = new Random();
    int number1 = rand1.Next(1, 100);
    Console.WriteLine("Введено число А: " + number1);

    Random rand2 = new Random();
    int number2 = rand2.Next(1, 10);
    Console.WriteLine("Введено число В: " + number2);

    double result = Math.Pow(number1, number2);
    Console.WriteLine($"{number1} (Число A) в степени {number2} (число В) равно {result}");

}

void Zadacha25_1()
{

    Random rand1 = new Random();
    int number1 = rand1.Next(1, 100);
    Console.WriteLine("Введено число А: " + number1);

    Random rand2 = new Random();
    int number2 = rand2.Next(1, 5);
    Console.WriteLine("Введено число В: " + number2);

    int counter = 1;
    int result = 1;
    while (counter <= number2)
    {
        result = number1 * result;
        counter++;
    }
    Console.WriteLine($"{number1} (Число A) в степени {number2} (число В) равно {result}");
}

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе  

void Zadacha27()
{
    Random rand = new Random();
    int number = rand.Next(1, 10000);
    Console.WriteLine("Введено число: " + number);
    int result = 0;
    int res2 = 0;
    while (number / 10 > 0)
    {
        res2 = number % 10;
        result = result + res2;
        number = number / 10;

    }
    Console.WriteLine($"Сумма цифр в числе равна {result + number}");
}


// Задача 29. Напишите программу, которая задаёт массив из 8 случайных чисел и выводит
// отсортированный по модулю массив 

void Zadacha29()
{
    int[] numbers = new int[5];
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numbers[i] = rand.Next(0, 10);
        Console.Write(numbers[i] + "  ");
    }

    Console.WriteLine("Массив из 8 случайных чисел от 1 до 100");

    //for (int i = 0; i < 8; i++)
    //{
        //if (numbers[i] < 0) numbers[i] = numbers[i] * -1;
        //Console.Write(numbers[i] + "  ");
   // }
    //Console.WriteLine("Модули чисел массива");

    for (int i = 0; i < 5; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j <= 4; j++)
        {
            if (numbers[j] < numbers[minPosition]) minPosition = j;
        }
        int temporary = numbers[i];
        numbers[i] = numbers[minPosition];
        numbers[minPosition] = temporary;
        Console.Write(numbers[i] + "  ");
    }
//Console.WriteLine("Массив, отсортированный по модулю");
}

//Zadacha25();
//Zadacha25_1();
//Zadacha27();
Zadacha29();
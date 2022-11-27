/*
// 24 Напишите программу, которая на вход принимает число А и выдаёт сумму чисел от 1 до А
void Zadacha24()
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {

        Console.Write($"{sum} + {counter} = ");
        sum += counter; //sum = sum + counter;
        Console.WriteLine(sum);
        counter++;
    }
    Console.WriteLine("Ответ:" + sum);
}
Zadacha24();
*/

/*
// 24 Второй способ
void Zadacha24()
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    int sum = 0;
    while (number > 0)
    {
       sum += number;
       number--;
    }
    Console.WriteLine("Ответ:" + sum);
}
Zadacha24();

*/

/*
// 26 Напишите программу, которая на вход число и показывает количество цифр в числе
void Zadacha26()
{
    Random rand = new Random();
    int number = rand.Next(1, 9999999);
    Console.WriteLine("Введено число: " + number);

    int cyfra = 1;

    while (number > 10)
    {
        number = number / 10;
        cyfra++;
    }
    Console.WriteLine(cyfra);

}
Zadacha26();
*/

/*
// 26 Напишите программу, которая на вход число и показывает количество цифр в числе. Второй способ
void Zadacha26()
{
    Console.WriteLine("Введите число:  ");
    string number = Console.ReadLine();
    Console.WriteLine("Введено число: " + number);
    int length = number.Length;
    Console.WriteLine($"Количество цифр в числе {number} равно {length}");

}
Zadacha26();
*/
/*
// или
void Zadacha26()
{
    Random rand = new Random();
    int number = rand.Next(1, 9999999);
    Console.WriteLine("Введено число: " + number);
    string numberStr = Convert.ToString(number);
    Console.WriteLine($"Количество цифр в числе {number} равно {numberStr.Length}");

}
Zadacha26();
*/

/*
void Zadacha26()
{
    Random rand = new Random();
    int number = rand.Next(1, 9999999);
    Console.WriteLine("Введено число: " + number);
    
    Console.WriteLine("длина числа равна " + Math.Floor(Math.Log10(number) + 1));
// Math.Ceiling метод округления к большему Math.Floor округление к меньшему

}
Zadacha26();
*/

/*
//28 Напишите программу, которая на вход принимает число А и выдаёт произведение чисел от 1 до А
void Zadacha28()
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    int counter = 1;
    int result = 1;
    while (counter <= number)
    {
        Console.Write($"{result} * {counter} = ");
        result = result * counter;
        Console.WriteLine(result);
        counter++;
    }
    Console.WriteLine("Ответ:" + result);
}
Zadacha28();
*/

/*
// 28 Второй способ
void Zadacha28()
{
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    int result = 1;
    while (number > 1)
    {
        result *= number;//result = result * counter;
        number--;
    }
    Console.WriteLine("Ответ:" + result);
}
Zadacha28();
*/
/*
// 28  способ через for
void Zadacha28()
{
    Random rand = new Random();
    int number = rand.Next(1, 30);
    Console.WriteLine("Введено число: " + number);
    int result = 1;

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"i = {i}");
        result = result * i;
    }
    Console.WriteLine($"Результат произведения числел от 1 до {number} = {result}");
}
Zadacha28();
*/
/*
// 30. Напишите программу, которая выводит массив из 8 элементов, заполнненных 1 и 0 в случайном порядке

void Zadacha30()
{
    Random rand = new Random();
    int[] binar = new int[8];
    Console.Write("binary array = [ "); // бинарный массив

    for (int i = 0; i < 8; i++)
    {
        binar[i] = rand.Next(0, 2);
        Console.Write(binar[i] + ", ");
    }
    Console.WriteLine("]");
}
Zadacha30();
*/

// 30. Напишите программу, которая выводит массив из 8 элементов, заполнненных 1 и 0 в случайном порядке
//второй способ

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] nums)
 
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + "  "); 
    }
}


void Zadacha30()
{
    int size = 8;
    Random rand = new Random();
    int[] numbers = new int[size];
    // у массива после типа данных прописываются [] - т.е. не один int, а набор intов
    // numbers - это переменная-контейнер для массива. int[] справа - также тип данных, в скобках требуется 
    // размер. Указывается переменная  size. Слева - создание переменной, где будет храниться массив
    // справа - создание массива
    //Console.WriteLine(numbers[7]); // Обращение к массиву. Его размер 7 - это индекс старшего, 8го элемента
    // пустой массив - это массив из нулей

    FillArray(numbers);
    PrintArray(numbers);
}
    Zadacha30();


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
8
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
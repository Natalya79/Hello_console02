/*
void Zadacha1()
{
    // Напишите программу, которая выдаёт случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа
    Random rand = new Random();//переменная rand, в которую будет помещён генератор случайных чисел new Random
    int number = rand.Next(10, 100);
    Console.WriteLine("Случайное число: " + number);
    int tens = number / 10;
    int ones = number % 10;

    Console.Write("Наибольшая цифра числа: ");
    if (tens > ones)
    {
        Console.WriteLine(tens);
    }
    else
    {
        Console.WriteLine(ones);
    }
}
Zadacha1();

*/

/*
void Zadacha2()
{
    // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру числа
    Random rand = new Random();//переменная rand, в которую будет помещён генератор случайных чисел new Random
    int number = rand.Next(100, 1000);
    Console.WriteLine("Случайное число: " + number);
    int hundreds = number / 100;
    int ones = number % 10;
    Console.Write($"{hundreds}{ones}");

}
Zadacha2();
*/

/*
void Zadacha3()

// Напишите программу, которая принимает на вход два числа и проверяет, является ли второе кратным первому, 
// если нет, выводит остаток
{
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 % number1 == 0) Console.WriteLine($"{number2} кратно {number1}");
    else Console.WriteLine($"{number2} не кратно {number1}, остаток {number2 % number1}"); 
}    
Zadacha3();

*/

/*
// Напишите программу, которая принимает на вход число и проверяет, является ли оно кратным 
// 7 и 23 одновременно
Вариант 1
void Zadacha3()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number % (7 * 23) == 0) Console.WriteLine($"{number} кратно и 7, и 23");
    else Console.WriteLine($"{number} не кратно 7 и 23 одновременно"); 
}    
Zadacha3();


//Вариант 2
void Zadacha3()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number % (7) == 0 && number % (23) == 0) // & операнд "и" (&& - и краткое, т.е достаточно проверить первое условие),
    // - если оно не соблюдается, то дальше проверять не нужно,т.к. неверно всё выражение)
    // |, || операнд "или" (|| - краткое)
    {
        Console.WriteLine($"{number} кратно и 7, и 23");
    }
    else Console.WriteLine($"{number} не кратно 7 и 23 одновременно"); 
}    
Zadacha3();
*/


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно квадратом другого

void Zadacha4()
{
   Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 * number1 == number2 || number2 * number2 == number1)
    {
        Console.WriteLine("Да"); 
    }    
    else Console.WriteLine("Нет");
}

Zadacha4();
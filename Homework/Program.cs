/*
int number = 5;

int numberSecond;
numberSecond = 8;
int result = number * number;

Console.WriteLine(result);

int Result = numberSecond * numberSecond;
Console.WriteLine($"{numberSecond} * {numberSecond} = {Result}");

*/

/*
int number = 15;
if (number > 10)
{
    Console.WriteLine("Число больше 10");
}
else
{
    Console.WriteLine("Число не больше 10");
}
*/

/*
int number = 5;
while (number < 10)
{
    Console.WriteLine(number);
    number++;
    
}
*/

/*
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = new Random().Next(0, 6);//
if (number == 1)
{
    Console.WriteLine("Понедельник");
}

else if (number == 2)
{
    Console.WriteLine("Вторник");
}

else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");

}
   
else if (number == 5)

{
    Console.WriteLine("Пятница");
    
}    
else if (number == 6)

{
    Console.WriteLine("Суббота");

}

else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}

else 
{
    Console.WriteLine("Некорректное число");
}

/* 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое большее, а какое меньшее
Console.WriteLine("Введите число A");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) Console.WriteLine("A больше B");
else if (number1 < number2)
{
    Console.WriteLine("B больше A");
}
else if (number1 == number2)

{
    Console.WriteLine("A равно B");
}    
*/

// 1. Напишите программу, которая на вход принимает три числа и выдаёт максимальное
Console.WriteLine("Введите число A");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 < number2) max = number2;
    
if (max < number3) max = number3;
 Console.WriteLine(max);
   
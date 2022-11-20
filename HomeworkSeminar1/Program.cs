/* 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое большее, а какое меньшее
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

/*4. Напишите программу, которая на вход принимает три числа и выдаёт максимальное
Console.WriteLine("Введите число A");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
    
if (number3 > max) max = number3;
 Console.WriteLine(max);
   
   // Это примитивный способ. Нужно посмотреть, как решить другим способом (лучше), через индекс i и цикл while
   */

   /*6. Напишите программу, которая на вход принимает число и выдаёт, является ли оно чётным

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1) Console.WriteLine("Число нечётное");
else Console.WriteLine("Число чётное");
*/

/* 8. Напишите программу, которая на вход принимает число больше нуля (N>0) 
//и на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int count = 2;
while (count <= number)
{
    if (count % 2 == 0) Console.WriteLine($"{count}");
    count++;
}
*/




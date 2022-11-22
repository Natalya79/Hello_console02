/*

// Задача 10: напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа

void Zadacha10()

{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = number / 10 % 10;
    Console.WriteLine(result);
}
Zadacha10();
*/



/*
// Задача 13: напишите программу, которая с помощью деления выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет

void Zadacha13()

{
    Console.WriteLine("Введите  число");
    int number = Convert.ToInt32(Console.ReadLine());

       while (number > 999)  number = number / 10;
    
            if (number / 100 == 0)  
        {
            Console.WriteLine("Третьей цифры нет"); 
        }
    
        else  Console.WriteLine($"{number = number % 100 % 10}");  
    
   
}
Zadacha13();
*/


/*
// Задача 15: напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным


/* void Zadacha15()

{
Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1 || number == 2 || number ==3 || number ==4 || number ==5)
{
    Console.WriteLine("Рабочий день");
}

else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
}


else     Console.WriteLine("Некорректная цифра");

}
Zadacha15();

*/

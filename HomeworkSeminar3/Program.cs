// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
void Zadacha19()

{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
   
    if (number < 10000 | number > 99999) Console.WriteLine("Число не пятизначное");

    else if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("Число является палиндромом");
    }

    else Console.WriteLine("Число не является палиндромом");

}

// 21. напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в трёхмерном пространстве

void Zadacha21()
{
    Console.WriteLine("Введите координату х1");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату y1");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату z1");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату x2");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату y2");
    int y2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите координату z2");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
   
    Console.WriteLine($"Длина отрезка равна {Math.Round(dist, 2)}");
}

// 22. напишите программу, которая принимает на вход число N и выводит таблицу кубов от 1 до N

void Zadacha22()
{
    Console.WriteLine("Введите число");

    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число" + "____" + "Куб");
    for (int i = 1; i <= number; i++) 
    {
         Console.WriteLine(i + "__________"+ $"{Math.Pow(i, 3)}");
    }
      
}

Zadacha19();
Zadacha21();
Zadacha22();




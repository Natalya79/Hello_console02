/*
void Zadacha17()
// 17. напишите программу, которая принимает на вход координаты точки X Y, не равные 0, и выдаёт номер четверти 
// плоскости, в которой находится эта точка
{
    Random rand = new Random(); // rand - имя переменной, в которой хранится генератор (класс), который имеет тип 
    //данных Random - который слева. Слева переменная, справа генератор. Random справа - тип генератора
    // тип_данных имя переменной = new тип_данных(иногда здесь указан параметр); - аналогия с новым сотрудником
    //для определённой функции
    int x = rand.Next(-10, 11);// метод Next
    int y = rand.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");

    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть");
    }

    else
    {
        Console.WriteLine("Точка лежит на координатной прямой");
    }
}


*/

/*
// 18. напишите программу, которая по заданному номеру четверти показывает диапазон возможных
// координат точек в этой четверти X Y

void Zadacha18()

{
    Console.WriteLine("Введите число от 1 до 4 - номер четверти");
    int number = Convert.ToInt32(Console.ReadLine());

    //Random rand = new Random(); // rand - имя переменной, в которой хранится генератор (класс), который имеет тип 
    //данных Random - который слева. Слева переменная, справа генератор. Random справа - тип генератора
    // тип_данных имя переменной - new тип_данных(иногда здесь указан параметр); - аналогия с новым сотрудником
    //для определённой функции
    //int x = rand.Next(-10, 11);// метод Next
    //int y = rand.Next(-10, 11);
    //Console.WriteLine($"A({x}, {y})");

    if (number == 1)
    {
        Console.WriteLine("Координата x > 0, y > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("Координата x < 0, y > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("Координата x < 0, y < 0");
    }
    else if (number == 4)
    {
        Console.WriteLine("Координата x > 0, y < 0");
    }

    else if (number > 4)
     {
        Console.WriteLine("Некорректное число. Такой четверти нет");
    }
}

Zadacha18();
*/


/*
// 21. напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в двухмерном пространстве

void Zadacha21()
{
    Console.WriteLine("Введите координату х1");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату y1");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату x2");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату y2");
    int y2 = Convert.ToInt32(Console.ReadLine());
    // Math.Pow(x, 2); - возведение в степень, в данном случае 2
    // Math.Sqrt(x); - извлечение квадратного корня
    // Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); - формула вычисления длины отрезка 
    // квадратный корень из квадрата гипотенузы - суммы квадратов катетов (длина каждого катета как 
    // разница между горизотальными и вертикальными координатами)
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
   
    Console.WriteLine($"Длина отрезка равна {Math.Round(dist, 2)}");//округление до количества знаков после запятой
    // в данном случае 2
}
Zadacha21();
*/

// 21. напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в двухмерном пространстве. Способ с массивами

/*
void Zadacha21()
{
    Console.WriteLine("Введите координаты точки А через пробел");
    string pointA = Console.ReadLine();
    Console.WriteLine("Введите координаты точки B через пробел");
    string pointB = Console.ReadLine();

    string[] pointASplit = pointA.Split(); // ввели две строчки string pointA, string pointB и разбили их
    // командой Split - эта команда считывает пробел. Строка 45 _ 7 разбивается на две строки 45 и 7
    string[] pointBSplit = pointB.Split();
    double dist = Math.Sqrt(Math.Pow(Convert.ToInt32(pointASplit[0]) - Convert.ToInt32(pointBSplit[0]), 2) 
    + Math.Pow(Convert.ToInt32(pointASplit[1]) - Convert.ToInt32(pointBSplit[1]), 2));
    Console.WriteLine($"Длина отрезка равна {Math.Round(dist, 2)}");
}

Zadacha21();
*/

/*
// 22. напишите программу, которая принимает на вход число и выводит таблицу квадратов от 1 до его размера

void Zadacha22()
{
    Console.WriteLine("Введите число");

    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число" + "____" + "Квадрат");
    for (int i = 1; i <= number; i++) 
    {
         Console.WriteLine(i + "__________"+ $"{Math.Pow(i, 2)}");
    }
      
}
Zadacha22();

*/

// 22. напишите программу, которая принимает на вход число и выводит таблицу квадратов от 1 до его размера
// способ через цикл while
void Zadacha22()
{
    Console.WriteLine("Введите число");

    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число" + "____" + "Квадрат");
    int i = 1;

    while (i <= number) 
    {
         Console.WriteLine(i + "__________"+ $"{Math.Pow(i, 2)}");
          // Console.WriteLine($"{i} * {i} + "__________"+ $"{Math.Pow(i, 2)}");
          // Console.WriteLine($"{i}^2 + "__________"+ $"{Math.Pow(i, 2)}");
          // \t - табуляция
         i++;
    }
      
}
Zadacha22();
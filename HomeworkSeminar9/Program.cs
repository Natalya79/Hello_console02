
// Задача 64: Задайте значения M и N. Напишите программу, который выведет все натуральные числа, кратные 3, 
// в промежутке от M до N. M = 1; N = 9. -> "3, 6, 9"
void Zadacha64()
{

    Console.WriteLine("Введите число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());

    PrintThreeDivide(numberM, numberN);

    void PrintThreeDivide(int numberM, int numberN)

    {

        if (numberM < numberN)
        {
            for (int i = numberM; i <= numberN; i++)
                if (i % 3 == 0) Console.WriteLine($" {i}");
            return;
        }


        PrintThreeDivide(numberM, numberN);
    }

    Console.WriteLine();

}
Zadacha64();


/*Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму
натуральных элементов в промежутке от M до N. 
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void Zadacha66()
{

    Console.WriteLine("Введите число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());

    NumberSum(numberM, numberN, 0);

    void NumberSum(int numberM, int numberN, int sum)

    {

        if (numberM > numberN)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
            return;
        }
        sum = sum + (numberM++);
        NumberSum(numberM, numberN, sum);
    }

}

Zadacha66();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

void Zadacha68()
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    AkkermanFunction(m, n);

 
    void AkkermanFunction(int m, int n)
    {
        Console.Write(Akkerman(m, n));
    }

    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
        }
    }
}
Zadacha68();
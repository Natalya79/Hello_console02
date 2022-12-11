
// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитать, сколько чисел больше 0

void Zadacha41()
{
    Console.Write("Введите числа через запятую: ");
    int[] numbers = StringToNum(Console.ReadLine());

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Всего чисел больше 0 = {count}");


    int[] StringToNum(string input)
    {
        int count = 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
            {
                count++;
            }
        }

        int[] numbers = new int[count];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string temp = "";

            while (input[i] != ',')
            {
                if (i != input.Length - 1)
                {
                    temp += input[i].ToString();
                    i++;
                }
                else
                {
                    temp += input[i].ToString();
                    break;
                }
            }
            numbers[index] = Convert.ToInt32(temp);
            index++;
        }
        return numbers;
    }

}
Zadacha41();

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1
// y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
{

    Console.WriteLine("введите значение b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k2");
    int k2 = Convert.ToInt32(Console.ReadLine());

    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;

    Console.WriteLine($"координаты точки пересечения двух прямых x: {x}, y: {y}");
}
Zadacha43();
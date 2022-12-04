/* void Zadacha31()
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9, найдите сумму 
// отрицательных и положительных элементов массива
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);//или не указывать- 9 и 9, но тогда в строке 41 указать int minValue=9, int maxValue=9
    PrintArray(numbers);

    FillArray(numbers, -100, 200);
    PrintArray(numbers);
    FindSumPos(numbers);
    FindSumNeg(numbers);

    void FindSumPos(int[] nums)
    {
        int sumPos = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] > 0)
            {
                sumPos += nums[i];
            }
        }
        Console.WriteLine("Сумма положительных элементов:  " + sumPos);
    }

    void FindSumNeg(int[] nums)
    {
        int sumNeg = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
                sumNeg += nums[i];
        }
        Console.WriteLine("Сумма отрицательных элементов:  " + sumNeg);
    }


    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue); //nums[i] = new Random().Next(-9, 10); вместо этой и 11 строк
        }

    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
Zadacha31();
*/

/*
void Zadacha32()
// Задача 32: Напишите программу замены элементов массива - отрицательные на положительные и  наоборот
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            if (nums[i] > 0) nums[i] = nums[i] * -1;
            else nums[i] = nums[i] * -1;
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
Zadacha32();
*/

/*
void Zadacha32()
// Задача 32: Напишите программу замены элементов массива - отрицательные на положительные и  наоборот
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            nums[i] = nums[i] * -1; //  nums[i] *= -1
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
Zadacha32();
*/

/*
void Zadacha33()
// Задача 33: Напишите программу поиска наличия или отсутствия числа в массиве
{
    int size = 12;
    int[] numbers = new int[size];

    Console.WriteLine("Введите первую цифру от -9 до 9");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите вторую цифру от -9 до 9");
    int number2 = Convert.ToInt32(Console.ReadLine());

    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < length; i++)
        {
            if (number1 == nums[i]) 
            {
                Console.WriteLine($"Число {number1} в массиве есть");
            }
           
            if (number2 == nums[i]) 
            {
                Console.WriteLine($"Число {number2} в массиве есть");
            }
           
                     
        }
        Console.WriteLine();
    }
}

Zadacha33();
*/

/*
void Zadacha33()
// Задача 33: Напишите программу поиска наличия или отсутствия числа в массиве - 2 вариант
{
    int size = 12;
    int[] numbers = new int[size];

    Console.WriteLine("Введите цифру от -9 до 9");
    int number = Convert.ToInt32(Console.ReadLine());
    int j = 0;

    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < length; i++)
        {
            if (number == nums[i])
            {
                j++;
            }
        }
            if (j > 0) Console.WriteLine($"Число {number} в массиве есть");
            else Console.WriteLine($"Числа {number} в массиве нет");
        
        Console.WriteLine();
    }
}

Zadacha33();
*/

/*
void Zadacha33()
// Задача 33: Напишите программу поиска наличия или отсутствия числа в массиве - вариант с флагом
{
    int size = 12;
    int[] numbers = new int[size];

    Console.WriteLine("Введите цифру от -9 до 9");
    int number = Convert.ToInt32(Console.ReadLine());
    bool flag = false; //bool логический тип переменных, к-рый принимает значение "истина" либо "ложь" (по умолчанию)

    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < length && !flag; i++) //т.е. пока flag == false, оба условия должны соблюдаться 
        {
            if (nums[i] == number)
            {
                flag = true;
            }
            Console.Write(i + " ");
        }


// вариант 
//for (int i = 0; i < length && !flag; i++) 
  //      {
   //         flag = nums[i] == number;
  //          Console.Write(i + " ");
  //      }

//

        Console.WriteLine();

            if (flag) Console.WriteLine($"Число {number} в массиве есть"); // т.е. flag = true, присутствует
            
            else Console.WriteLine($"Числа {number} в массиве нет");
        
        Console.WriteLine();
    }
}

Zadacha33();

*/

/*
void Zadacha35()
// Задача 35: Задать одномерный массив из 10 случайных чисел. Найти количество элементов массива
// значения которых лежат в отрезке от 10 до 99
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 500);
    PrintArray(numbers);

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] >= 10 && nums[i] <= 99) count = count + 1;
            
        }
        Console.Write(count);
    }
}
Zadacha35();
*/

/*
void Zadacha37()
// Задача 37: Найдите произведение пар чисел в одномерном массиве (первый и последний элемент, второй и предпоследний)
// результат запишите в новом массиве
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 9);
    PrintArray(numbers);
    

    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    
      
      for (int i = 0; i <= length/2; i++)
      {
          int j = length - i - 1;
          int result = 0;
          if (i < length/2) result = nums[i] * nums[j];
          if (i == j) result = nums[i];

          Console.Write(result + " ");
          
      }
      
    }
}

Zadacha37();
*/


void Zadacha37()
// Задача 37: Найдите произведение пар чисел в одномерном массиве (первый и последний элемент, второй и предпоследний)
// результат запишите в новом массиве 2 вариант
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 9);
    PrintArray(numbers);


    void FillArray(int[] nums, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(minValue, maxValue);
        }
    }

    void PrintArray(int[] nums)
    {

        int length = nums.Length;
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
    int halfsize = size / 2;
    int[] result = new int[halfsize + size%2]; // size - halfsize
    int MaxIndex = size - 1;
    for (int i = 0; i < halfsize; i++)
    {
        result[i] = numbers[i] * numbers[MaxIndex - i];
    }
    if (size%2 == 1) result[halfsize] = numbers[halfsize];
    PrintArray(result);
}

Zadacha37();
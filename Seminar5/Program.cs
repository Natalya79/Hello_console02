void Zadacha31()
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9, найдите сумму 
// отрицательных и положительных элементов массива
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);//или не указывать- 9 и 9, но тогда в строке 47 указать int minValue=9, int maxValue=9
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
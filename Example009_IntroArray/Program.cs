// Массивы и функции
/*задача 1
int Max (int number1, int number2, int number3)
{
    int result = number1;
    if (number2 > result) result = number2;
    if (number3 > result) result = number3;
    return result;
}

int[] array = {1, 5, 8};

int max = Max(array[0], array[1], array[2]);
 Console.WriteLine(max);
*/

/*задача 2
int [] array = {1, 12, 31, 4, 15, 16, 17, 18}; // определить новый массив
int n = array.Length; // определение количества элементов массива
int  find = 4; //требуется найти элемент массива, равный find
int index = 0; // установить счётчик index
while (index < n)
{
    if(array[index] == find) // если элемент массива с данным индексом совпал с find, алгоритм завершает работу
    
        {
            Console.WriteLine(index);
            break; // нужно на случай, если в массиве есть элементы с одинаковым значением.
            // тогда программаостановится на первом из них 
        }
    
    index = index + 1;
}
*/

void FillArray(int[] collection) // FillArray наименование метода. collection наименование аргумента
{
    int length = collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // генератор случайных чисел от 1 до 10
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length; 
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection [index] == find)
        {
                position = index;
                break;
        }
        index++;
    }
    return position;
}


int [] array = new int[10]; //создай новый массив с 10 элементами

FillArray(array);
PrintArray (array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
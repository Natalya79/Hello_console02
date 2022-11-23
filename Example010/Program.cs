/*
int Method3()
{
    return DateTime.Now.Day;
}
    int day = Method3();
Console.WriteLine(day);
*/

/*
// Преобразование текста 
string text = "Наташа  ";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    { 
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
return result;
}
string newText = Replace(text, ' ', '+');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'Н', 'N');
Console.WriteLine(newText);
*/

/*
// Упорядочить массив. Min

int[] arr = {1, 4, 6, 8, 3, 6, 8, 4};
void PrintArray(int[] array)
{
   int count = array.Length;

    for (int i = 0; i < count; i++)    
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
   int count = array.Length;
    for (int i = 0; i < array.Length - 1; i++)    
    {
        int minPosition = i; // позиция рабочего элемента, с которым будут производится действия

        for (int j = i + 1; j < array.Length; j++)    
    {
        if(array[j] < array[minPosition]) minPosition = j;
    }
        int temporary = array [i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
   
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

*/

/*
// Упорядочить массив. Max

int[] arr = {1, 4, 6, 8, 3, 6, 8, 4};
void PrintArray(int[] array)
{
   int count = array.Length;

    for (int i = 0; i < count; i++)    
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
   int count = array.Length;
    for (int i = 0; i < array.Length - 1; i++)    
    {
        int maxPosition = i; // позиция рабочего элемента, с которым будут производится действия

        for (int j = i + 1; j < array.Length; j++)    
    {
        if(array[j] > array[maxPosition]) maxPosition = j;
    }
        int temporary = array [i];
        array[i] = array[maxPosition]; 
        array[maxPosition] = temporary;
    }
   
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
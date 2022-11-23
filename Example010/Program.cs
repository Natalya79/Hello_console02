/*
int Method3()
{
    return DateTime.Now.Day;
}
    int day = Method3();
Console.WriteLine(day);
*/

/*
// Преобразование текста - ошибка
string text = "99757 65 ";
string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    { 
        if(text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + text[i];
    }
return result;
}
string NewText = Replace (text, " ", "+");
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace (text, "9", "10");

*/

int [] arr = {1, 4, 6, 8, 3, 6, 8, 4};
void PrintArray(int[] array)
{
   int count = array.Length;
    for (int i = 0, i < count; i++)    
    {
        System.Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
/*
void SelectionSort(int[] array)
{
   int count = array.Length;
    for (int i = 0, i < array.Length; i++)    
    {
        int minPosition = i;
        int temporary = array [i];
        array
    }
    Console.WriteLine();
}
PrintArray (arr);
*/
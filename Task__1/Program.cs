// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3.

string[] GetArray(int size)                             // Создаем массив. Количество строк задает пользователь.
{
    string[] array = new string[size]; 
    for (int i=0; i<array.Length; i++)
    {
         Console.WriteLine("Введите строку: ");
         array[i] = Console.ReadLine();
    }
    return array;
}

int CountUpper3(string[] inArray)                      // Считаем количество строк больше или равное 3.
{
    int count = 0;
    for (int i=0; i<inArray.Length; i++)
    {
        if (inArray[i].Length>=3) count++;
    }
    return count;
}

string[] Str3Symbol(string[] inArray, int count)       // Создаем новый массив и кладем в него значения >=3.
{
    int j=0;
    string[] result = new string[count];
    for (int i=0; i<inArray.Length; i++)
    {
        if (inArray[i].Length>=3) 
        {
            result[j]=inArray[i];
            j++;
        }        
    }
    return result;
} 

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int countNumbers = int.Parse(Console.ReadLine()!);
string[] newArray = GetArray(countNumbers);
Console.WriteLine("Все введенные строки:");            
Console.WriteLine(String.Join(", ", newArray));          // Для наглядности выводим все строки.
int count = CountUpper3(newArray);
Console.WriteLine("Строки более 3х символов");
string[] result = Str3Symbol(newArray, count);
Console.WriteLine(String.Join(", ", result));           // Выводим строки более 3х символов.
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();
Console.Write("How many items in your array ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

int index = 0;
while (index <= size - 1)
{
    Console.Write("Enter element ");
    array[index] = Console.ReadLine();
    index++;
}

int Counter(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count = count + 1;
    }
    return count;
}

string[] newarray = new string[Counter(array)];

void FillNewArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }

}

void Display(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($" \"{array[i]}\", ");
    }
    Console.WriteLine($" \"{array[array.Length - 1]}\"]");
}

Display(array);

if (Counter(array) > 0)
{
    FillNewArray(array, newarray);
    Display(newarray);
}
else Console.WriteLine("[]");
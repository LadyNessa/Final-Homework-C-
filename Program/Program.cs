void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

string[]array1 = new string[4] {"hello", "2", "world", ":-)"};
string[]array2 = new string[4];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}

PrintArray(array2);
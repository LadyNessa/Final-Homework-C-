void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

Console.WriteLine("Введите элементы первоначального массива через пробел: ");
string arr = Console.ReadLine();
string[]array1 = arr.Split(' ');
string[]array2 = new string[array1.Length];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}

Console.Write("Элементы, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);
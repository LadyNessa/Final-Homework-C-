# Алгоритм работы программы:
## 1. Создание массивов
   ***Первый массив*** заполняется пользователем через пробел, подсказка по заполнению возникает сразу после старта программы. После заведения текста в программу, он обрабатывается с помощью функции Split, и в результате каждое слово становится элементом первого массива.

   ***Второй массив*** на первоначальном этапе просто обозначается как массив с длиной равной длине первого массива.

## 2. Выполнение условия
Для второго массива задается счетчик *count*, изначально равный 0.

Затем, начиная с первого элемента первого массива (задается счетчик *i*, также изначально равный 0), поочередно для всех элементов первого массива (для всех i, которые меньше array1.length) выполняется проверка условия  - длина элемента должна быть меньше или равна 3.

Если условие выполняется, то значение этого элемента присваивается (соответственно счетчику count) элементам второго массива. Тут же происходит модификация счетчика count.

## 3. Печать результатов
На экране возникает надпись "Элементы, длина которых меньше либо равна 3 символа: ". 

**Запускается заранее прописанный метод печати массивов:**
~~~
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}
~~~

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (int)random.Next(-100,100);
        Console.Write("{0,10}" , + array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Введите координаты:");
 int line = Convert.ToInt32(Console.ReadLine());
 int column = Convert.ToInt32(Console.ReadLine());
 if (line < 0 | line > m - 1 | column > n - 1 | column < 0)
 Console.WriteLine("Такого числа в массивек нет!");
 else
 {
 object value = array.GetValue(line,column);
 Console.WriteLine($"Значение элемента: {value}");
 }




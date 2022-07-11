// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.Write("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(10,100);
        Console.Write(matrix[i, j] + "   ");
    }
    Console.WriteLine();
}
Console.Write("Введите значение строки x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца z = ");
int z = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == x)
    {
        for (int j = 0; j <= matrix.GetLength(1); j++)
        {
            if (j == z)
            {
                Console.Write($"На позиции ({x};{z}) находится число {matrix[i, j]} ");
            }
            else if (z >= matrix.GetLength(1))
            {
                Console.Write("Координаты превышают размер массива ");
                break;
            }
        }
    }
    else if (x >= matrix.GetLength(0)  )
    {
        Console.Write("Координаты превышают размер массива ");
        break;
    }
}

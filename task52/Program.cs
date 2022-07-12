// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1,9);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("\n");
double A =0;
for (int j = 0; j < n; j++)
{    
    A=0;
    for (int i = 0; i < m; i++)
    {
        
      
        A+=matrix[i,j];       
        
    }   Console.Write($" \n {A/m} среднее афифмитическое значение");
    
} 



// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if(i==j )
//         {
//         A=A+matrix[i,j];       
//         }
//     }
// } Console.Write($"{A} сумма элементов по диагонали");
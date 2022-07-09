// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// static void FixedSeedRandoms(int seed)
//     {
//         Console.WriteLine(
//             "\nRandom numbers from a Random object with " +
//             "seed = {0}:", seed);
//         Random fixRand = new Random(seed);

//         RunIntNDoubleRandoms(fixRand);
//     }

Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().NextDouble()*55-25;
        // матрица от -25 до 30. Почему тогда цифры в ответе девяти значные? или я чтото не правильно понял?
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

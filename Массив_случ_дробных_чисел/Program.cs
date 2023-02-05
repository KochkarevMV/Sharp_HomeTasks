// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



void FillArray (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() * (5 - 1) + 1, 1);
        }
    }
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write($"[{array[i,j]}]");
Console.WriteLine();
}
}

Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double [,] matrix = new double[size[0], size[1]];
FillArray(matrix);
PrintArray(matrix);
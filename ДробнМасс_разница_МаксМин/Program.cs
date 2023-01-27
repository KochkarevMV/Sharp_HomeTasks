// Задайте массив дробных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61

Console.Clear();
double [] Mass = {2.1, 3.2, 12.3, 16.2, 1.1};

double Max (double [] array)
{
    double Maxx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Maxx)
        Maxx = array[i];
    }
    return Maxx;

}

double Min (double [] array)
{
    double Minn = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Minn)
        Minn = array[i];
    }
    return Minn;

}
double MassMax = Max(Mass);
double MassMin = Min(Mass);
Console.WriteLine($"Максимальный элемент массива: {Max(Mass)} ");
Console.WriteLine($"Минимальный элемент массива: {Min(Mass)} ");
Console.WriteLine("Разница между максимальным и минимальным элементом массива: ");
Console.WriteLine($"{MassMax - MassMin}");


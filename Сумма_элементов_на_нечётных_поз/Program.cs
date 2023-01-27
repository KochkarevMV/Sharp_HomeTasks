// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
void Mass (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,10);
}

int Sum (int [] array)
{
    int sumpos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0 && i > 0)
        sumpos = sumpos + array[i];
    }
    return sumpos;
}

int [] Array1 = new int [8];
Mass(Array1);
Console.WriteLine($"Ваш случайный массив: [{string.Join(",",Array1)}]");
Console.WriteLine($"Сумма всех элементов, стоящих на нечётных позициях: ");
Console.WriteLine(Sum(Array1));
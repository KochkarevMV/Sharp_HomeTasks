// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
void Mass (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,1000);
}

int MassChet (int [] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if(element%2 == 0)
        count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] OurMass = new int [a];
Mass(OurMass);
Console.WriteLine($"Ваш массив: [{string.Join(",",OurMass)}] ");
Console.WriteLine($"Количество чётных чисел:");
Console.WriteLine(MassChet(OurMass));
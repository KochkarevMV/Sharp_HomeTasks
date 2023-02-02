// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введит кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());


void YourArray(int[] array)
{
    for (int i = 0; i < n; i++)
        array[i] = new Random().Next(-100, 100);
}


int HowMany(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element > 0)
            count++;
    return count;
}

int[] numbers = new int[n];
YourArray(numbers);
Console.Write("Ваш ряд чисел: ");
Console.WriteLine(string.Join(",", numbers));
Console.Write("Кол-во чисел больше нуля: ");
Console.Write(HowMany(numbers));
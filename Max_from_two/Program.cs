// Программа по нахождению максимального из двух чисел

Console.Clear();
Console.WriteLine("Давайте определим максимум из двух чисел");
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
Console.Write("Первое число больше второго");
else if (a < b)
Console.Write("Второе число больше первого");
else
Console.Write("Числа равны");
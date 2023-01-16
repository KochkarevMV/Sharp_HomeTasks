// Программа по нахождению максимального из трёх чисел

Console.Clear();
Console.WriteLine("Давайте определим максимум из трёх чисел");
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
Console.WriteLine("Первое число является наибольшим значением");
else if (b > c && b > a)
Console.WriteLine("Второе число является наибольшим значением");
else if (c > b && c > a)
Console.WriteLine("Третье число является наибольшим значением");
else
Console.WriteLine("Максимальные числа равны - максимальных чисел больше, чем одно: введите новые (отличные друг от друга) числа");
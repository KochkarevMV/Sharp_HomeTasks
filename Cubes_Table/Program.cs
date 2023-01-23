//  Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Давайте определим таблицу кубов вашего числа");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= a; count++)
    Console.WriteLine($"{Math.Pow(count,3)}");

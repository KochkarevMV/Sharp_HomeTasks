﻿//  Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Давайте определим таблицу кубов вашего числа");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a > count)
{
    Console.WriteLine($"{Math.Pow(count,3)}");
    count ++;
}
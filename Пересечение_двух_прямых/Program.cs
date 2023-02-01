// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. 
// Это уравнение прямой пропорциональности

// Значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Точка b1 = {b1}");
Console.WriteLine($"Точка k1 = {k1}");
Console.WriteLine($"Точка b2 = {b1}");
Console.WriteLine($"Точка k2 = {b2}");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
Console.Write($"X равен ");
Console.WriteLine($"{x}");
Console.Write($"Y равен ");
Console.WriteLine($"{y}");
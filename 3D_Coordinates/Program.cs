// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Давайте определим расстояние между вашими точками в 3D пространстве");
Console.Write("Введите координаты X 1-й точки: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Y 1-й точки: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Z 1-й точки: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты X 2-й точки: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Y 2-й точки: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Z 2-й точки: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double Result = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);
Console.Write("Расстояние между вашими точками: ");
Console.Write($"{Result}");
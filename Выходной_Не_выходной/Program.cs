// Программма по определению выходного/не выходного дня по заданному пользователем числу

Console.Clear();
Console.WriteLine("Давайте определим выходной ли день вы ввели");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 6)
Console.Write("Это будний день");
else if (a > 5 && a < 8)
Console.Write("Это выходной день");
else
Console.Write("Введите число от 1 до 7");

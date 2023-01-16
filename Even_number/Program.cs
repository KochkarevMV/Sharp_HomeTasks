// Программа по выявлению чётного или нечётного числа

Console.Clear();
Console.WriteLine("Давайте определим чётное ли, или нечётное ваше число");
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
Console.Write("Ваше число является чётным");
else if (a%2 != 0)
Console.Write("Ваше число является нечётным");
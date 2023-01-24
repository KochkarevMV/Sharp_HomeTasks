// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Давайте определим палиндром ли ваше число");
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 10000 && a < 100000 && a/10000 == a%10 && (a%100)/10 == (a%10000)/1000) // a/10000 - находит первое число, a%10 - находит последнее число, (a&100)/10 - находит четвёртое число, (a%10000)/1000 - находит второе число
Console.WriteLine("Число является полиндромом");
else
Console.WriteLine("Число не является полиндромом");

// Решение преподавателя
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Программа выводит третью цифру заданного пользователем числа, или выводит сообщение, что её нет

// Console.Clear();
// Console.WriteLine("Давайте определим третью цифру вашего числа");
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// {
// if (a > 100 && a < 1000)
// Console.Write($"Третья цифра вашего числа: {a%10}");
// else if (a > 1000 && a < 10000)
// Console.Write($"Третья цифра вашего числа: {(a/10)%10}");
// else if (a > 10000 && a < 100000)
// Console.Write($"Третья цифра вашего числа: {(a/100)%10}");
// else if (a > 100000 && a < 1000000)
// Console.Write($"Третья цифра вашего числа: {(a/1000)%10}");
// else if (a > 1000000 && a < 10000000)
// Console.Write($"Третья цифра вашего числа: {(a/10000)%10}");
// else if (a > 10000000 && a < 100000000)
// Console.Write($"Третья цифра вашего числа: {(a/100000)%10}");
// else if (a > 100000000 && a < 1000000000)
// Console.Write($"Третья цифра вашего числа: {(a/1000000)%10}");
// else if (a > 1000000000 && a < 10000000000)
// Console.Write($"Третья цифра вашего числа: {(a/10000000)%10}");
// else if (a < 100 || a == 0)
// Console.WriteLine("Третья цифра отсутствует");
// }


//Решение короче
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n >= 1000)
    {
        n = n / 10;
    }
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}

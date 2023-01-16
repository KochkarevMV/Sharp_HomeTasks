// Программа по нахождению массива чётных чисел от 1 до указанного числа

Console.Clear();
Console.WriteLine("Давайте определим массив чётных чисел от 1 до указанного вами числа");
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

while (m <= n)
{
    if (m%2 == 0)
    Console.Write($"{m} ");
    m = m + 1;
}

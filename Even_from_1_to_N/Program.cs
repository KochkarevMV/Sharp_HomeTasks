// Программа по нахождению массива чётных чисел от 1 до указанного числа

Console.Clear();
Console.WriteLine("Давайте определим массив чётных чисел от 1 до указанного вами числа");
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int M = 0;

while (M <= N && N%2 == 0)
{
    Console.Write($"{N}, ");
    M = M++;
}

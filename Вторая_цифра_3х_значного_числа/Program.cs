// Программма по нахождению второй цифры заданного пользователем трёхзначного числа

Console.Clear();
Console.WriteLine("Давайте определим вторую цифру вашего числа");
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = (a%100)/10;
Console.Write("Вторая цифра вашего числа: ");
Console.Write($"{b}");

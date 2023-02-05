// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такой позиции в массиве нет

void FillArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}

int Finder (int [,] array)
{
    Console.WriteLine("Введите позицию элемента в массиве: ");
    int [] n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    int x = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            if (i <= n[0] && j <= n[1])
            x = array[n[0], n[1]];
        }
    }
return x;
}
    

int [,] MyArray = new int [3,3];
FillArray(MyArray);
Console.WriteLine(Finder(MyArray));
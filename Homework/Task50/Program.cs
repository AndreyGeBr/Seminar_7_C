// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.WriteLine("Введите позицию элемента через enter: ");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

int[,] array = CreateArray();
FillArray(array);
Console.WriteLine("В массиве");
PrintArray(array);
if (n < array.GetLength(0) && m < array.GetLength(1)) Console.Write($" Элемент на позиции [{n}, {m}] = {array[n, m]}");
else Console.Write($" Элемент на позиции [{n}, {m}] не существует");  

int[,] CreateArray()
{
    Random random = new Random();
    int[,] array = new int [random.Next(3, 6), random.Next(3, 6)];
    return array;
}

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = random.Next(-9, 10);
        }
    }
} 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


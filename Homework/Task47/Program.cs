// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] array = CreateArray();
FillArray(array);
PrintArray(array);

double[,] CreateArray()
{
    Random random = new Random();
    double[,] array = new double [random.Next(4, 9), random.Next(4, 9)];
    return array;
}

void FillArray(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = Math.Round(random.NextDouble() * 10, 2);
        }
    }
} 

void PrintArray(double[,] array)
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
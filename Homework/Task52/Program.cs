// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();
double[] avgColumn = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    avgColumn[i] = Math.Round((result / array.GetLength(0)), 2);
}
PrintArrayDouble(avgColumn);

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

void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}| ");
    }
    Console.WriteLine();
}

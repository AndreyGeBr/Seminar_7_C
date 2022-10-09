// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();


Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReplaseEvenIndex(matrix);
PrintArray(matrix);


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

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 11);;
        }
    }
}

void ReplaseEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            // array[i, j] = array[i, j] * array[i, j];
            array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
}
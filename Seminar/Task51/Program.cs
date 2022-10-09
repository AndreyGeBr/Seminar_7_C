// Задайте двумерный массив. Найдите сумму  элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.Clear();

Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
int result = SumMainDiagonal(matrix);
Console.Write($"Сумма элементов на главной диагонали равна {result}");



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

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}
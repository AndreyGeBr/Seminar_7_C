// Задайте трехмерный массив размером m*n*z, заполненный случайными целыми числами (от 0 до 99).
// Выведите массив в консоль.

Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array);


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = generator.Next(0, 100);
            }
        }
    }
}


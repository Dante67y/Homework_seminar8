// Задайте двумерный массив. Напишите программу
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatr(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    // Меняем местами первую и последнюю строку массива
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1]) // Для упорядочивания по возрастанию
                                                     // надо поменять знак '<' на '>'
                {
                    int max = 0;
                    max = matrix[i, z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = max;
                }
            }
        }
    }
    Console.WriteLine("Массив с упорядоченными значениями:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(m, n));

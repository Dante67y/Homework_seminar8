int[,] CreateMatr(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    Console.WriteLine();
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        int count = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j] && i != j)
                count++;
        }
        Console.WriteLine(array[i] + " встречается " + count + " раз");
    }
}
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(m, n));

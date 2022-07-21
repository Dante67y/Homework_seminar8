void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размерность матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выбранный размер матрицы: " + string.Join(" * ", size, size));
Console.WriteLine();
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillMatrix(matrixA);
FillMatrix(matrixB);
int[,] matrixC = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
         matrixC[i, j] = matrixC[i, j] + (matrixA[i, j] * matrixB[i, j]);
    }
}
Console.Write("Матрица A:");
PrintMatrix(matrixA);
Console.WriteLine();
Console.Write("Матрица B:");
PrintMatrix(matrixB);
Console.WriteLine();
Console.Write("Произведение матриц 'A*B':");
PrintMatrix(matrixC);

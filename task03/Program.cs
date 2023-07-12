// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Ведите количество стобцов: ");
    int[,] matrix1 = FillMatrix(rows, cols, 0, 10);
    int[,] matrix2 = FillMatrix(rows, cols, 0, 10);
    PrintMatrix(matrix1);
    System.Console.WriteLine();
    PrintMatrix(matrix2);
    System.Console.WriteLine();
    int[,] matrix3 = ProductOfMatrix(matrix1, matrix2);
    System.Console.WriteLine("Результирующая матрица:");
    PrintMatrix(matrix3);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ProductOfMatrix(int[,] matr1, int[,] matr2)
{
    int row; int col;
    row = matr1.GetLength(0);
    col = matr1.GetLength(1);
    int[,] newMatrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < row; k++)
            {
                newMatrix[i, j] += matr1[i, k] * matr2[k, j];
            }
        }

    }
    return newMatrix;
}

Main();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= tempMatrix.GetLength(0) * tempMatrix.GetLength(1))
    {
        tempMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < tempMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= tempMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > tempMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
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

int[,] matrix = FillMatrix(4, 4, 0, 16);
PrintMatrix(matrix);
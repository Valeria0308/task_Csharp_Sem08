// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Main()
{
    int x = ReadInt("Введите количество строк: ");
    int y = ReadInt("Ведите количество стобцов: ");
    int z = ReadInt("Ведите глубину массива: ");
    int[,,] matrix3D = FillMatrix(x, y, z, 10, 99);
    PrintMatrix(matrix3D);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] FillMatrix(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[x, y, z];


    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {

            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = new Random().Next(leftRange, rightRange + 1);
            }
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                System.Console.Write($"{matrixForPrint[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

Main();


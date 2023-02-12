// Найти произведение двух матриц

int[,] myMatrixFirst = CreateMatrix(3, 3, 1, 9);
PrintMatrix(myMatrixFirst);
Console.WriteLine();
int[,] myMatrixSecond = CreateMatrix(3, 3, 1, 9);
PrintMatrix(myMatrixSecond);
Console.WriteLine();

if (myMatrixFirst.GetLength(1) == myMatrixSecond.GetLength(0))
{
    int[,] getMatrixProduct = GetMatrixProduct(myMatrixFirst, myMatrixSecond);
    PrintMatrix(getMatrixProduct);
}
else
    Console.WriteLine("Данные матрицы умножать нельзя");


int[,] GetMatrixProduct(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] productMatrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrixFirst.GetLength(1); n++)
            {
                productMatrix[i, j] += matrixFirst[i, n] * matrixSecond[n, j];
            }
        }
    }
    return productMatrix;
}



int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

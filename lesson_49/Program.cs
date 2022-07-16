// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.

//int rows = Convert.ToInt32(Console.ReadLine());
//int colums = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int[rows, colums];

Console.Clear();

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        } 
    }
    return matrix;
}

/* int[,] FindEvenIndex(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i+=2)
    {
        for (int j = 0; j < mtrx.GetLength(1); j+=2)
        {
            mtrx[i, j] *= mtrx[i, j];
        } 
    }
    return mtrx;
} */

void FindEvenIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        } 
    }
}

void PrintMatrix(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{massiv[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] result = GetMatrix(3, 3, 1, 10);
PrintMatrix(result);
Console.WriteLine();
//int[,] result2 = FindEvenIndex(result);
//PrintMatrix(result2);
FindEvenIndex(result);
PrintMatrix(result);

// Задача 48: Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Amn = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        } 
    }
    return matrix;
}

void PrintMatrix(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{massiv[i, j], 3} | ");
            //Console.Write(massiv[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] result = GetMatrix(rows, colums);
PrintMatrix(result);

// Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами) (0,0); (1;1) и т.д.

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

int CheckArray(int[,] mass)
{
    int sum = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum += i == j ? mass[i, j] : 0;
            /* if (i == j)
            {
                sum += mass[i, j];
            } */
        } 
    }
    return sum;
}

int CheckArray2(int[,] mass)
{
    int sum = 0;
    int index = 0;

    if (mass.GetLength(0) > mass.GetLength(1))
    {
        index = 1;
    }
    for (int i = 0; i < mass.GetLength(index); i++)
    {
        sum += mass[i, i];
    } 
    return sum;
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

int[,] array = GetMatrix(3, 5, 1, 20);
PrintMatrix(array);
//int result = CheckArray(array);
int result2 = CheckArray(array);
Console.WriteLine("\nСумма элементов = " + result2);


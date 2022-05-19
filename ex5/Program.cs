// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] matrix = new int[5, 4];

void PrintArray(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write($"{matr[n, m]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            matr[n, m] = new Random().Next(1, 10);
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

void eventArray(int[,] matr) //четность или нечетность 
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            if (n % 2 == 0&&m % 2 == 0 ) matr[n, m] = matr[n, m]*matr[n, m];
            Console.Write($"{matr[n, m]} ");
        }
        Console.WriteLine();
    }
}

eventArray (matrix);


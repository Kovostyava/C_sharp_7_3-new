// 1. Напишите программу, которая будет создавать копию заданного
//    массива с помощью поэлементного копирования.



void PrintArray(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }

}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
    
         {
            matr[i, j] = new Random().Next(1, 10);
         }

    }
}

void MyArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
    
         {
            matr[i, j] = new Random().Next(1, 10);
         }

    }
}

int[,] matrix = new int[4, 5];
PrintArray(matrix);
FillArray(matrix);
MyArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MyArray(matrix);
Console.WriteLine();
PrintArray(matrix);
/*
Задача 58. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1  2  3  4
12 13 14 5
11 16 15 6
10  9  8  7
*/
int rows = 4;
int columns = 4;
int[,] array = new int[rows,columns];
int max = 0;
/***************************************************************************************/
FillArray(array);
PrintArray(array);
/***************************************************************************************/
int FindMax(int[,] A)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (A[i,j] > max)
            {
                max = A[i,j];
            }
        }
    }
    return max;
}
/***************************************************************************************/
void FillArray(int[,] A)
{
    int rows = A.GetLength(0);
    int columns = A.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        int i = 0;
        A[i,j] = j+1;
        FindMax(A);
    } 
    /****/
    for (int i = 1; i < rows; i++)
    {
        int j = columns-1;
        A[i,j] = max + 1;
        FindMax(A);
    }
   /****/
    for (int j = columns-2; j > 0; j--)
    {
        int i = rows-1;
        A[i,j] = max + 1;
        FindMax(A);
    }
    /****/
    for (int i = rows-1; i > 0; i--)
    {
        int j = 0;
        A[i,j] = max + 1;
        FindMax(A);
    }
    /****/
    for (int j = columns-3; j < columns-1; j++)
    {
        int i = rows-3;
        A[i,j] = max + 1;
        FindMax(A);
    }
    /****/
     for (int j = columns-2; j > 0; j--)
    {
        int i = rows-2;
        A[i,j] = max + 1;
        FindMax(A);
    }
}

/***************************************************************************************/
void PrintArray(int[,] A)
{
     for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < A.GetLength(1); j++)
        {
           Console.Write(A[i,j] + "\t")  ;
        }
        Console.WriteLine();
    }
}
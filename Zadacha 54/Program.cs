/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/

Random random = new Random();
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];
int[] arrayRow = new int [rows];

FillArray(array);
PrintArray(array);
PrintSortRows(array);

void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for(int j = 0; j < A.GetLength(1); j++)
        {
            A[i,j] = random.Next(1,10);
        }
    }
}
void PrintArray(int[,] A)
{
     for (int i = 0; i < A.GetLength(0); i++)
    {
        for(int j = 0; j < A.GetLength(1); j++)
        {
           Console.Write(A[i,j] + "\t")  ;
        }
        Console.WriteLine();
    }
}

void PrintSortRows(int[,] A)
{
    Console.WriteLine(); 
    Console.WriteLine("Отсортированный массив по строкам: ");
    Console.WriteLine();
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for(int z = j + 1; z < A.GetLength(1); z++)
            {
                if(A[i,j] > A[i,z])
                {
                    int temp = A[i,j];
                    A[i,j] = A[i,z];
                    A[i,z] = temp;
                } 
            }  
            Console.Write(A[i,j] + "\t");       
        }  
        Console.WriteLine();    
    }
    Console.WriteLine("--------------------------------------------------------------------------------------");
}
Console.WriteLine();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayRow[j] = array[j, i];
                    Console.Write(arrayRow[j] + "\t");    
                }    
            }
        

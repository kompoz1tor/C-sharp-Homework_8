/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("Программа, которая считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.");
Console.WriteLine("Задайте прямоугольный двумерный массив");
Console.WriteLine("--------------------------------------------------------------------");
Random random = new Random();
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];
int[] arrayRow = new int [columns];
int[] sumRow = new int[rows];
/***************************************************************************************/
Revizor(array);
void Revizor(int[,] A)
{
    if (A.GetLength(0) != A.GetLength(1))
    {
        FillArray(array);
        PrintArray(array);
        FillArraySumRow(array);
        Console.WriteLine("--------------------------------------------------------------------");
        MinSumRow(sumRow);
        Console.WriteLine("--------------------------------------------------------------------");
    }
    else Console.WriteLine ("Введите прямоугольный массив, где количество строк не совпадает с количеством столбцов");
}

/***************************************************************************************/

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
/***************************************************************************************/
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
/***************************************************************************************/
void FillArraySumRow(int[,] A)
{
    for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayRow[j] = array[i, j];
                    sum = sum + arrayRow[j];
                }   
                sumRow[i] = sum; 
            }
}
/***************************************************************************************/
void MinSumRow(int[] A)
{
    int min = sumRow[0];
    int indexMin = 0;
    for (int i = 0; i < sumRow.Length; i++)
         {
            if (sumRow[i] < min)
            {
                min = sumRow[i];
                indexMin = i+1;
            }
         }
    Console.WriteLine($"Минимальная суммма строки массива равна {min}, номер строки: {indexMin}");
}
/***************************************************************************************/

/* TASK1
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] Regular (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i,n] < array [i, n+1])
                {
                    int temp = array[i,n + 1];
                    array[i,n + 1] = array [i,n];
                    array[i,n] = temp;
                }
            }
        }
    } return array;
}

Console.Write("Enter numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2DArray (m, n, min, max);
Show2DArray(array);
Console.WriteLine("Array with descending elements: ");
int [,] regular = Regular(array);
Show2DArray(regular); */

/* TASK2 
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Console.Write("Enter numbers of rows: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter numbers of columns: ");
//int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2DArray (4, 4, min, max);
Show2DArray(array);
int MinSum = int.MaxValue;   
int minrow = 0;
    for (int i = 0; i < array.GetLength(0) -1; i++)
        {   
            int rowsum = 0;
             for (int j = 0; j < array.GetLength(1); j++)
            {
              rowsum += array[i,j];   
             if (rowsum < MinSum)
             {
                MinSum = rowsum;
                minrow = i;
             }
            }
        }
Console.Write("The row with the smallest sum of elements: ");
for(int j = 0;j < array.GetLength(1);j++) Console.Write(array[minrow, j] + " ");*/

/*TASK3
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] TheFirstMatrix (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of rows: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of columns: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] FirstArray = TheFirstMatrix (m, n, min, max);
int [,] SecondArray = TheFirstMatrix (n, l, min, max);
Console.WriteLine("The first matrix: ");
Show2DArray(FirstArray);
Console.WriteLine("The second matrix: ");
Show2DArray(SecondArray);
int [,] MultiMatrix (int [,] Matrix )
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            int multi = 0;
            for (int k = 0; k < FirstArray.GetLength(0); k++)
            {
                multi += FirstArray[m, n] * SecondArray[k, l];
            }
        Matrix [i,j] = multi;
        }
    }
}
int multi = MultiMatrix(FirstArray,SecondArray);
Console.WriteLine($"The multiplication matrix: ");
Show2DArray(MultiMatrix);*/

/*TASK4
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2 

int [, ,] CreateRandom3DArray (int x, int y, int z, int minValue, int maxValue)
{
    Random rand = new Random();
    int [, ,] newArray = new int [x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
              newArray[i,j,k] = rand.Next(10, 100 +1);
            }
        }
    }return newArray;
}

void Show3DArray (int [, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page №: " + (i+1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " ");
            } Console.WriteLine();
        } Console.WriteLine("=========================");
    }
}

Console.Write("Enter numbers of x: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of y: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of z: ");
int p = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter min value of element: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter max value of element: ");
//int max = Convert.ToInt32(Console.ReadLine());

int [, ,] array = CreateRandom3DArray (m, n, p,10, 100);
Show3DArray(array);
*/

/*TASK5
Заполните спирально массив 4 на 4.

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int n = 4;
int [,] array = new int [n, n];
int temp = 1;
int x = 0;
int y = 0;

while (temp <= n*2*2) 
{
  array [x, y] = temp;
  temp++;
  if (x <= y + 1 && x + y < array.GetLength(1) - 1)
    y++;
  else if (x < y && x + y >= array.GetLength(0) - 1)
    x++;
  else if (x >= y && x + y > array.GetLength(1) - 1)
    y--;
  else
    x--;
}

WriteArray(array);*/


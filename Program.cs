//Домашняя работа 
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateDoubleRandom2dArray(int rows, int columns, int minValue, int maxValue)
{   
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue,maxValue+1)  
                                    + new  Random().NextDouble(),2) ;
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] myArray= CreateDoubleRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{   
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(  array[i,j] +"\t"  );
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckOfIndex(int[,] array, int rowIndex, int columnIndex)
{
    if ((rowIndex <0 || rowIndex>=array.GetLength(0)) 
        || (columnIndex <0 || columnIndex>=array.GetLength(1)) ) 
    { 
        Console.WriteLine("No element.");
    }
    else 
    {
        Console.Write($"array[{rowIndex},{columnIndex}]={array[rowIndex,columnIndex] }");
    }
    
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray= CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/
/*
Console.Write("Input a row index: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column index: ");

int columnIndex = Convert.ToInt32(Console.ReadLine());
CheckOfIndex( myArray, rowIndex, columnIndex);
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
double[] AverageColumnsArray(int [,] array)
{
    double[] averageArray=new double [array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int sum=0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum=sum+array[j,i];
        }
        averageArray[i]=(double)sum/array.GetLength(0);
    }
    Console.WriteLine();
    return averageArray;
}

void ShowAverageArray(double [] array)
{

    for(int i = 0; i < array.Length; i++)
        Console.Write(  array[i] +"\t"  );
}

double[] averageArray = AverageColumnsArray(myArray);
ShowAverageArray(averageArray);
*/
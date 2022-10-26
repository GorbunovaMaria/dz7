/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
/*
int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)   //cтроки/столбцы
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
    newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    //строки
    {
    for (int j = 0; j < array.GetLength(1); j++)   //столбцы
      {
      Console.Write (array [i,j] + " ");
      }
    Console.WriteLine();
    }
}

bool TrueOfFalse (int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)    
    {
    for (int j = 0; j < array.GetLength(1); j++)
      {
      if (array[i,j] == num ) return true;
      }
    }
     return false;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число в массиве");
int num = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (m,n,min,max);
Show2DArray(myArray);
bool result = TrueOfFalse (myArray, num);
Console.WriteLine($"В данном массиве есть указанное вами число? -> {result}");*/


/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)   //cтроки/столбцы
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
    newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    //строки
    {
    for (int j = 0; j < array.GetLength(1); j++)   //столбцы
      {
      Console.Write (array [i,j] + " ");
      }
    Console.WriteLine();
    }
}
void numbersSum (int[,] array)
{
for (int j = 0; j < array.GetLength(1); j ++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{Math.Round(sum / array.GetLength(0),1)} ");
}
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (m,n,min,max);
Show2DArray(myArray);
Console.WriteLine();
numbersSum(myArray);



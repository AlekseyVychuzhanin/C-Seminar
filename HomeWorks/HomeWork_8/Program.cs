// Задача 1. Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
        
    }
    Console.WriteLine();
}

void SortingArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m];
                    array[i, m] = array[i, m + 1];
                    array[i, m + 1] = temp;
                }
            }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortingArray(myArray);
Show2dArray(myArray);
*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
        
    }
    Console.WriteLine();
}

int FindRowWithTheSmallestAmount(int[,] array)
{
    int minSum = 0;
    int row = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (minSum == 0) minSum = sum;
        Console.WriteLine($"Sum of elements {i + 1} row is: {sum}");
        if (sum < minSum) row = i;
    }
    return row;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int row = FindRowWithTheSmallestAmount(myArray);
Console.WriteLine("Row with minimum sum of elements is: " + (row + 1));
*/

// Задача 3. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.





// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.







// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.





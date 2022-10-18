// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CrateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array:");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}

int SumOfPositives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum = sum + array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CrateArray(size);
int resultOfNegative = SumOfNegatives(myArray);
int resultOfPositive = SumOfPositives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of negative elements is " + resultOfNegative);
Console.WriteLine("Sum of positive elements is " + resultOfPositive);
*/

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

int[] ArrayFlip(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * - 1;
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, -100, 100);
ShowArray(myArray);

int[] arrayFlip = ArrayFlip(myArray);
ShowArray(arrayFlip);
*/

// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

bool FindNumber(int[] array, int num)
{
    bool find = false;
    for  (int i = 0; i < array.Length; i++)
        if(array[i] == num)
            return true;

    return false;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(10, 1, 25);
bool find = FindNumber(myArray, number);
ShowArray(myArray);
Console.WriteLine(find);
*/

// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindAmoun(int[] array)
{
    Console.Write("Input min limit: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max limit: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int m = min;
    int n = max;
    int count = 0;
    
    for  (int i = 0; i < array.Length; i++)
        if(array[i] >= m & array[i] <= n)
            count ++;
    return count;
}

int[] myArray = CreateRandomArray(12, 1, 100);
ShowArray(myArray);
int amount = FindAmoun (myArray);
Console.WriteLine("Amount of elements is " + amount);
*/





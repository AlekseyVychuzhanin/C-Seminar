// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int a)
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
        sum = sum + current;
    return sum;
}

Console.WriteLine("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberOfDigit(int num)
{
    int count = 0;

    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumberOfDigit(a);
Console.WriteLine($"{a} has {result} digits");
*/

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int n)
{
    int fact = 1;

    for (int current = 1; current <= n; current++)
        fact *= current;
    return fact;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int f = Factorial(num);
Console.WriteLine($"Product of elements from 1 to {num} is {f}");
*/

// Задача 4. Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.
// (Создание массива и показ массива)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
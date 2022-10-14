// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Exponentiate(int a, int b)
{
    double result = (Math.Pow(a, b));
    return result;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree of a number: ");
int b = Convert.ToInt32(Console.ReadLine());

double res = Exponentiate(a, b);
Console.WriteLine($"{a} in degree {b} is {res}");
*/

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = NumberLength(number);
SumNumbers(number, length);
*/

//Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
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
if(size < 0)
    size = size * -1;
Console.Write("Input the min volue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max volue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/

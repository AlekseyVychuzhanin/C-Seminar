// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] array)
{
    for( int i= 0, last = array.Length - 1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[] myArray = CreateRandomArray(6, 1, 10);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    return false;
}

Console.Write("Input side size a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side size b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side size c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool res = Triangle(a, b, c);
Console.WriteLine(res);
*/

// Задача 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

int[] CopyArray (int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copy[i] = array[i];
    return copy;
}

int[] myArray = CreateRandomArray(6, 1, 10);
ShowArray(myArray);
CopyArray(myArray);
ShowArray(myArray);
*/

// Задача 4. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibohachi(int size, int a, int b)
{
    int[] fibArray = new int[size];
    fibArray[0] = a;
    fibArray[1] = b;
    for(int i = 2; i < size; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i -2];
    return fibArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input amount: ");
int fibSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first number: ");
int fibA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int fibB = Convert.ToInt32(Console.ReadLine());

int[] fibonachi = Fibohachi(fibSize, fibA, fibB);
ShowArray(fibonachi);
*/

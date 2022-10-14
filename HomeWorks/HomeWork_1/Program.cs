// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input the first number ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"Max = {n1} , Min = {n2}");
}
else
{
    Console.WriteLine($"Max = {n2} , Min = {n1}");
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int maxInt = n1;

if (maxInt < n2)
{
    maxInt = n2;
}
if (maxInt < n3)
{
    maxInt = n3;
}
Console.WriteLine("Max = " + maxInt );
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 > 0)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Yes");
}
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n)
    {
        if (current % 2 ==0)
        Console.Write(current + ", ");
        current ++;
    }
*/
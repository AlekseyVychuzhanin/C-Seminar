// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}

ShowNums(5);
*/

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(12345));
*/

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if(n > m) ShowNums(m, n - 1);
    Console.Write(n + " ");
}

ShowNums(5, 10);
*/

// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double DegreeOfNumber(double a, double b)
{
    if(b < 0) return 1 / a * DegreeOfNumber(a, b + 1);
    if(b > 0) return a * DegreeOfNumber(a, b - 1);
    else return 1;
}

Console.WriteLine(DegreeOfNumber(5, -2));
*/

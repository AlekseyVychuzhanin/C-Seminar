// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    int quart = 0;

    if (x > 0 && y > 0) quart = 1;
    if (x < 0 && y > 0) quart = 2;
    if (x < 0 && y < 0) quart = 3;
    if (x > 0 && y < 0) quart = 4;

    return quart;
}
Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindRange(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if (quart == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (quart == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
    if (quart == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
    if (quart <1 || quart > 4)
    {
        Console.WriteLine("Input correct quart number");
    }
}
Console.Write("Input quart number: ");
int quart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your range is "+ quart);
FindRange(quart);
*/

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

    return distance;
}

Console.Write("Input x-coordinate of tne first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of tne first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x-coordinate of tne second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of tne second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Distance = " + FindDistance(x1,y1,x2,y2));
*/

// Задача 4. Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void FindSquare(int n)
{
    int count = 1;
    if(n < 1)
    {
        Console.WriteLine("Input a number more 1");
    }
    else
    {
        while (count <= n)
        {
            Console.WriteLine(Math.Pow(count,2));
            count++;
        }
    }
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
FindSquare(n);
*/

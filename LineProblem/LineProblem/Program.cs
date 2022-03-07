// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparison Computation Program on Main Branch");
Console.WriteLine("enter the value of x1 ");
int x1;
x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of x2 ");
int x2;
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of y1 ");
int y1;
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of y2");
int y2;
y2 = Convert.ToInt32(Console.ReadLine());

double d =Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
Console.WriteLine("Distance is " + d);

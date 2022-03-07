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

double l1 =Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("length of line 1 is " + l1);




Console.WriteLine("enter the value of x3 ");
int x3;
x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of x4 ");
int x4;
x4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of y3 ");
int y3;
y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the value of y4");
int y4;
y4 = Convert.ToInt32(Console.ReadLine());

double l2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
Console.WriteLine("length of line 2 is " + l2);
Console.WriteLine("both lines are equal: " + l1.Equals(l2)); //return T/F
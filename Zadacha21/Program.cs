/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

int xa = distance("x", "A");
int xb = distance("x", "B");
int ya = distance("y", "A");
int yb = distance("y", "B");
int za = distance("z", "A");
int zb = distance("z", "B");

int distance(string coordinateName, string pointName)
{
    Console.WriteLine($"Введите координату {coordinateName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double D(double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2));
}
double segmentLength = Math.Round (D(xa, xb, ya, yb, za, zb), 2);

Console.WriteLine($"Расстояние между двух точек {segmentLength}");



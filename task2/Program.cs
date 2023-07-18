// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Clear();
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x1 = Prompt("Введите точку Х1: ");
int y1 = Prompt("Введите точку Y1: ");
int z1 = Prompt("Введите точку Z1: ");
int x2 = Prompt("Введите точку X1: ");
int y2 = Prompt("Введите точку X2: ");
int z2 = Prompt("Введите точку Z2: ");

void GetResult(double x1, double y1, double z1, double x2, double y2, double z2)
{
    Console.Write(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));
}

Console.Write("Расстояние между точками в 3D пространстве: ");
GetResult(x1, y1, z1, x2, y2, z2);
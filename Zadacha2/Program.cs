/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве*/

int x1 = ReadInt("Введите точку x1:");
int y1 = ReadInt("Введите точку y1:");
int z1 = ReadInt("Введите точку z1:");
int x2 = ReadInt("Введите точку x2:");
int y2 = ReadInt("Введите точку y2:");
int z2 = ReadInt("Введите точку z2:");

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double result = Math.Sqrt(a*a + b*b + c*c);

Console.WriteLine(result);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


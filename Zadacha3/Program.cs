/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int number = ReadInt("Введите число:");

int count = 1;

while (count <= number)
{
    Console.Write(count * count * count + " ");
    count++;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
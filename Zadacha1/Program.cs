/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

int number = ReadInt("Введите пятизначное число:");
if (number >= 10000 && number < 100000)
{
    int temp = number;
    int res = 0;

    while (number > 0)
    {
        res = res * 10 + number % 10;
        number /= 10;
    }
    if(temp == res)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Число не  является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
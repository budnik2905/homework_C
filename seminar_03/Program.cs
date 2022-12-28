// See https://aka.ms/new-console-template for more information
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите пятизначное чило: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10000 % 10;
int number2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
int nul = number / 10000;

if (nul < 1 || nul > 9)
{
    Console.WriteLine(number + " -> " + "Не пятизначное число ");
}
else if (number1 == rev2 && number2 == rev1)
{
    Console.WriteLine(number + " -> Да это палиндром ");
}
else
{
    Console.WriteLine(number + " -> Нет это не палиндром");
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int z1 = ReadInt("Введите z для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");
int z2 = ReadInt("Введите z для точки 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}


// See https://aka.ms/new-console-template for more information
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int step = numberA;

for (int i = 1; i < numberB; i++)
{
step = step * numberA;
}
Console.WriteLine($"{numberA} , {numberB} -> {step}");

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int number = i % 10;
i = i / 10;
sum = sum + number;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 111);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}

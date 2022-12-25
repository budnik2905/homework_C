// See https://aka.ms/new-console-template for more information
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondnumber = (number / 10)% 10;
Console.WriteLine($"Вторая цифра в числе {number} -> {secondnumber}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
Console.WriteLine($"Третьей цифры нет");
return;
}
string numberstr = number.ToString();
Console.WriteLine($"Третья цифра числа {number} -> {numberstr[2]}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 7) || (number < 1))
{
    Console.WriteLine("Неверный день недели");
}
if (number > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}
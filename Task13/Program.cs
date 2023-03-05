﻿// Задача 13: Напишите программу, которая 
// 1.выводит третью цифру заданного числа или 
// 2.сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");

int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("Третьей цифры нет!");
else
System.Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");
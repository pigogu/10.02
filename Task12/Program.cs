﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число : ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numberOne, numberTwo);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine("не кратно, остаток : " + result);

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}
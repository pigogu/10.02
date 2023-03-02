﻿// 16. Напишите программу, которая 
// 1.принимает на вход два числа и 
// 2.проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число :");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Square(firstNumber, secondNumber)) Console.WriteLine("Yes");
else Console.WriteLine("No");


bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}


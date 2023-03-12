// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool Thelengthofthesidesofthetriangle (int num1, int num2, int num3)
{
if (number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2) return true;
else return false;
}

bool result=Thelengthofthesidesofthetriangle(number1, number2, number3);
Console.WriteLine(result ? "Да" : "Нет");

// string TransformationNumber(int num)
// {
// string newNum = string.Empty;
// while (num != 0)
// {
// newNum = num % 2 + newNum;
// num = num / 2;
// }
// return newNum;
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string transformationNumber = TransformationNumber(number);
// Console.WriteLine(transformationNumber);
// Nikita Bannikov: Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int num)
// {
// int count = 1;
// int result = 0;
// while (num > 0)
// {
// result = result + num % 2 * count;
// num = num / 2;
// count *= 10;
// }
// return result;
// }
// int decToBin = DecToBin(number);
// Console.WriteLine($"{number} -> {decToBin}");
//Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.
//Пример:
// a = 5; b = 7 -> max = 7 
// a = 2; b = 10 -> max = 10 
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число а :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b :");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int maxNumber = a;
    int minNumber = b;
    Console.Write($"Максимальное значение = {maxNumber}  ");

    Console.Write($"Минимальное значение = {minNumber}");
}
if (b > a)
{
    int maxNumber = b;
    int minNumber = a;
    Console.Write($"Максимальное значение = {maxNumber}  ");

    Console.Write($"Минимальное значение = {minNumber}");
}
else
{
    Console.WriteLine("максимальное и минимальноое значение не найдено! Попробуйте ввести другие числа!");

}

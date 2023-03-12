// Задача 28: Напишите программу, которая
// 1.принимает на вход число N и выдаёт
// 2.произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int composition = CompositionNum(number);
   Console.WriteLine($"произведение чисел от 1 до {number} -> {composition}");
}
else Console.WriteLine("Ошибка ввода - число не натуральное!");

int CompositionNum (int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i;
        }
    }
    return result;
}
// Задача 15: Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, и 
// 2.проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int d)
{
    if (d > 0 && d < 8)
    {
        if (d == 6 || d == 7)
        {
            Console.Write(+ d + " - Да");
        }
        else
        {
            Console.Write(+ d + " - Нет");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, перезапустите программу и введите число от 1 до 7!");
    }
    return "";
}
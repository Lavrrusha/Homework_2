/*
 * Задача 10: 
 * Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 */
Console.Write("Введите трехзначное число:");
var readLine = Console.ReadLine();
try
{
    int number = int.Parse(readLine);
    if ((number > 99 & number < 1000) || number < -99 & number > -999)
    {
        if (number < 0)
            number = -number;
        number /= 10;
        number %= 10;
        Console.WriteLine($"Вторая цифра числа {readLine}: {number}");
    }
    else
    {
        Console.WriteLine("Введено не трехзначное число!");
    }
}
catch
{
    Console.WriteLine("Ошибка при вводе, введено не число!");
}
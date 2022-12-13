/*
 * Задача 15: 
 * Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 */
Console.Write("Введите число: ");
var readLine = Console.ReadLine();
try
{
    int number = int.Parse(readLine);
    if (number >= 1 & number <= 5)
    {
        Console.WriteLine("Не выходной!");
    }
    if (number >= 6 & number <= 7)
    {
        Console.WriteLine("Выходной!");
    }

    if (number >= 8 || number <= 0)
    {
        Console.WriteLine("Не день недели!");
    }
}
catch
{
    Console.WriteLine("Ошибка при вводе, введено не число!");
}

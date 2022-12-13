/*
 * Задача 13: 
 * Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 */
Console.Write("Введите число: ");
var readLine = Console.ReadLine();
try
{
    int number = int.Parse(readLine);
    if (number > 99 || number < -99)
    {
        if (number < 0)
            number = -number;

        var length = number.ToString().Length;
        var tempNumber = number;
        while (length - 3 > 0)
        {
            tempNumber /= 10;
            length--;
        }
        tempNumber %= 10;

        Console.WriteLine($"Третья цифра числа {readLine}: {tempNumber}");
    }
    else
    {
        Console.WriteLine("Третей цифры нет!");
    }
}
catch
{
    Console.WriteLine("Ошибка при вводе, введено не число!");
}
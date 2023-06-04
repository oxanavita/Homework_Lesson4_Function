﻿// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        double number = double.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        Console.WriteLine($"Количество цифр в числе: {digitCount}");
    }

    static int CountDigits(double number)
    {
        // Преобразуем число в строку и удаляем лишние символы
        string numberString = Math.Abs(number).ToString().Replace(".", "").Replace(",", "");

        // Возвращаем количество символов в строке
        return numberString.Length;
    }
}

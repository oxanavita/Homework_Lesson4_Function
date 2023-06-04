// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int tempNumber = number;

        while (tempNumber > 0)
        {
            int digit = tempNumber % 10;
            sum += digit;
            tempNumber /= 10;
        }

        Console.WriteLine($"Сумма цифр в числе {number} равна: {sum}");
    }
}
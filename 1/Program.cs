// 1. Дано число n. Получите число, записанное в обратном порядке.

// 345 >> 543
// 81 >> 18

Random rnd = new Random();
int n = rnd.Next(10, 1000);
Console.WriteLine($"Дано число {n}.");
Console.WriteLine($"Число в перевернутом виде: {NumberReverse(n)}.");


int NumberReverse(int number, int reversedNumber = 0)
{
    if (number == 0) return reversedNumber;
    reversedNumber = reversedNumber * 10 + number % 10;
    return NumberReverse(number / 10, reversedNumber);
}
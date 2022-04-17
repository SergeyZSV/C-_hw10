// 1. Дано число n. Получите число, записанное в обратном порядке.

// 345 >> 543
// 81 >> 18

Random rnd = new Random();
int n = rnd.Next(10, 1000);
Console.WriteLine($"Дано число {n}.");
Console.WriteLine($"Число в перевернутом виде: {NumberReverse(n)}.");


string NumberReverse(int number, string reversedNumber = "")
{
    if (number == 0) return reversedNumber;
    reversedNumber += number % 10;
    return NumberReverse(number / 10, reversedNumber);
}
// 2. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.

// m = 5 >> 1, 2, 2, 3, 3

Random rnd = new Random();
int n = rnd.Next(1, 10);
int m = rnd.Next(5, 100);
Console.Write($"Первые {m} членов монотонной последовательности: ");
Numbers(n, m);

void Numbers(int startNumber, int amountNumbers, int count = 0)
{
    for (int i = 0; i < startNumber; i++)
    {
        if (count == amountNumbers) return;
        Console.Write(startNumber + "   ");
        count = count + 1;
    }
    Numbers(startNumber + 1, amountNumbers, count);
}
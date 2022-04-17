// 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.

// 10 >> 5, 2.
// 12 >> 2, 2, 3.

int n = 12;
SimpleDividers(n);

void SimpleDividers (int currentNumber, int del = 1)
{
    if (currentNumber == 1) return;
    del++;
    if (currentNumber % del == 0) 
    {
        Console.Write(del + " ");
        currentNumber /= del;
        del = 1;
    }
    SimpleDividers(currentNumber,del);
}



// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits(int number)
{
    if (number == 0)
        return 0;
    return (number % 10) + SumDigits(number / 10);
}

Console.Write(SumDigits(9));
/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int GetNewNumber()
{
    Console.Write("Введите трехзначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int PrintSecondNumber(int number)
{
    int a = number / 100;
    int c = number % 10;
    int b = (number - a *100 - c) / 10;
    return b;
}

int number = GetNewNumber();
Console.WriteLine(number);

int NewNumber = PrintSecondNumber(number);
Console.WriteLine(NewNumber);


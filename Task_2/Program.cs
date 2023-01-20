/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int GetNewNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int IntegerFromDiv(int number, int n)
{
    int Int = number / n;
    return Int;
}

int number = GetNewNumber();
int n = 100;
int m = 10;

int integer  = IntegerFromDiv(number, n);

if (integer == 0)
{
    Console.WriteLine("В введённом числе нет третьей цифры");
}

if (integer > 0 && integer < 10)
{
    int ThirdDigit = number % 10;
    Console.WriteLine("Третья цифра введенного числа: " + ThirdDigit);
}

if (integer >= 10)
{int NewInteger = IntegerFromDiv(number, m);
        while (NewInteger >= 999) 
        {
            m = 10 * m;
            NewInteger = IntegerFromDiv(number, m);
        }     
        
    int ThirdDigit = (number / m) % 10;
    Console.WriteLine("Третья цифра введенного числа: " + ThirdDigit);
}






/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int NumberOfDay ()
    {
        Console.Write("Введите номер дня: ");
        return Convert.ToInt32(Console.ReadLine());
    }

int DayNumber = NumberOfDay ();

if (DayNumber < 8 && DayNumber > 0)
    if (DayNumber >= 1 && DayNumber  <= 5)
        {
            Console.WriteLine("Не выходной день");
        }
    else 
        {
            Console.WriteLine("Выходной день");
        }
else
    {
        Console.WriteLine("Такого дня нет. Введите заново.");
    } 
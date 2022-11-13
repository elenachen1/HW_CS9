/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int sum = 0;
Console.WriteLine ("Введите число начала промежутка");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число конца промежутка");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumber(m,n);
Console.WriteLine($"сумму натуральных элементов в промежутке от {m} до {n} - {sum}");
void NaturalNumber( int number1, int number2)
{
    
    for ( int i = m ; i <= n ; i++)
    {
        sum += i;

    }
}

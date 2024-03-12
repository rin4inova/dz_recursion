// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNum(int m, int n)
{
    if (m == n)
    {
        return Convert.ToString(n);
    }
    return m + " " + PrintNum(m + 1, n);
}
Console.WriteLine(PrintNum(m, n));


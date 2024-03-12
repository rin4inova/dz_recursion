// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] numbers = { 1, 2, 5, 0, 10, 34 };
// Console.Write($"{numbers[0]}");

void PrintElement(int[] array, int n)
{
    if (n == 0)
    {
        Console.Write($"{array[0]}");
    }
    else if (n > 0)
    {
        Console.Write($"{array[n]} ");
        PrintElement(array, n - 1);
    }
}

PrintElement(numbers, numbers.Length - 1);


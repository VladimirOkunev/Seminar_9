//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if (m == n) return n;
    return m + Sum(m + 1, n);
}

Console.Write("Enter the first number: ");

int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");

int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"Sum of the digits form {m} to {n}: {Sum(m, n)}");
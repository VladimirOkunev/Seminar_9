//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все чётные числа в промежутке от N до 1.

void OddCount(int n)
{
	if(n==2) 
    {Console.WriteLine(n);
    return;
    }
    else
    {
        if(n%2==0) Console.WriteLine(n);
    }
	OddCount(n-1);
}

Console.Write("Enter a number: ");

int n = int.Parse(Console.ReadLine() ?? "0");

OddCount(n);
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void Main()
{
    Console.WriteLine("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Сумма натуральных чисел между N и M = ");
    Console.WriteLine(SumNumbers(n, m));
}

int SumNumbers(int n, int m)
{
    if (n > m)
        return 0;
    else
        return n + SumNumbers(n + 1, m);
}

Main();
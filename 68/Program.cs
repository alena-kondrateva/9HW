// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


void Main()
{
    Console.WriteLine("Введите число N");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число M ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("A(m,n) => ");
    Console.WriteLine(Akkerman(n, m));
}

int Akkerman(int m, int n)
{
    if (m <= 0)
        return n + 1;
    else
    {
        if (m > 0 && n <= 0)
            return Akkerman(m - 1, 1);
        else if (m > 0 && n > 0)
            return Akkerman(m - 1, Akkerman(m, n - 1));
        return 0;
    }
}

Main();

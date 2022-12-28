/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintRange(int start, int end)
{
    //Базовый случай
    if (start == end)
    {
        return start.ToString(); 
    }
    //Рекурсивный
    string range = start + ", " + PrintRange(start - 1, end); // Здесь просто экспериментировал с типом string, так записал.
    return range;
}

Console.WriteLine(PrintRange(n, 1));
*/





/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumOfRange(int start, int end)
{
    int sum = 0;
    if (start == end)
    {
        return start;
    }
    sum = start + SumOfRange(start+1, end); // m=4, n=8, sum = 4+5+6+7+8 = 30; sum = start+(start+1)
    return sum;
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} = {SumOfRange(m, n)}");
*/





/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
int AckFunction(int m, int n)
{
    if (m == 0) // A(0,n) = n+1
    {
        return (n + 1);
    }
    else if (n == 0) // A(m,0) = A(m-1,1)
    {
        return AckFunction(m - 1, 1);
    }
    else //  A(m, n) = A(m-1, A(m, n-1))
    {
        return AckFunction(m - 1, AckFunction(m, n - 1));
    }
}

Console.Write("Введите число M: ");
int mArg = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int nArg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{AckFunction(mArg, nArg)}");
*/











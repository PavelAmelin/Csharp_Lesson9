int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AkkermanFunc(m - 1, 1);
    return  AkkermanFunc(m - 1, AkkermanFunc(m , n - 1));
}
Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(a, b));
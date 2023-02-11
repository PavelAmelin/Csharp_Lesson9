int SumAllNumsBetween(int N, int M)
{
    if (N == 0 && M == 0)
        return 0;
    if (N == M)
        return N;
    else if (N > M)
        return  M + SumAllNumsBetween(N, M + 1);
    return  N + SumAllNumsBetween(N + 1, M);
}
Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел между {a} и {b}: {SumAllNumsBetween(a, b)}");

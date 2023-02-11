void AllNums(int N)
{
    if (N > 0)
    {
    Console.WriteLine(N);
    AllNums(N - 1);
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
AllNums(num);
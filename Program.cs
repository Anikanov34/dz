// See https://aka.ms/new-console-template for more information
// ДЗ 3
Console.WriteLine("введите числа");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = Convert.ToInt32(Console.ReadLine());
int N2 = Convert.ToInt32(Console.ReadLine());

if (N >= N1)
{
    if (N >=N2)
    {
           Console.Write($"{N} ,");
    }else
    {
        Console.Write($"{N2} ,");

    }
} else
{
    if (N1>=N2)
    {
        Console.Write($"{N1} ,");

    }    else
    {
                Console.Write($"{N2} ,");

    }
}
 
// Задача 4: Напишите программу, которая принимает на вход три числа
// 1. и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ведите число");
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальное число {a}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {c}");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine($"Максимальное число {b}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {c}");
    }
}
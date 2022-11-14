// Напишите программу, 
// 1. которая на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Ведите число");
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Максимальное число {a}");
}

else
{
    Console.WriteLine($"Максимальное число {b}");
}

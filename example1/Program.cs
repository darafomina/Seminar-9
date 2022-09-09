//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
if (N>M)
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");
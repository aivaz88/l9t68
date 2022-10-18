// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(Akkermun(M, N));


int Akkermun(int M, int N, int sum = 0)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Akkermun(M - 1, 1);
    if (M > 0 && N > 0) return Akkermun(M - 1, Akkermun(M, N - 1));
    return Akkermun(M, N);
}
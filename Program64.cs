
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
int M = 1;
Console.WriteLine();
if (N>M)
for (int i = N; i >= 1; i--)
    Console.Write($" {i},   ");
else
    for (int i = M; i >= N; i--)
        Console.Write($" {i},   ");
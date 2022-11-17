// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("M = ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("N = ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Result, S = {SumNumbers(M, N)}");

// static int SumNumbers(int M, int N)
// {
//     if (M == 0) return (N * (N + 1)) / 2;            
//     else if (N == 0) return (M * (M + 1)) / 2;       
//     else if (M == N) return M;                       
//     else if (M < N) return N + SumNumbers(M, N - 1); 
//     else return N + SumNumbers(M, N + 1);            
// }

int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}













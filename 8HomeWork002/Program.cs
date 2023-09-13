// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = 1;
int n = 15;
void PrintSumNumbers(int m, int n)
{
    int result = SumNumberBetweenPoints(m, n);
    Console.WriteLine($"M = {m}; N = {n} -> {result}");
}

int SumNumberBetweenPoints(int m, int n)
{
    if ( m == n) return m;    
    return m + SumNumberBetweenPoints(m + 1, n);
    
}
PrintSumNumbers(m, n);

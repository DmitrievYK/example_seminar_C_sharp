// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.WriteLine("Введите число: ")
// int n = Convert.ToInt32(Console.ReadLine());

// double Fibonacci(int n)
// {
//     int a = 0;
//     int b = 1;
//     for (int i = 1; i < n; i++)
//     {
//         a +=b;
//     }
//     return a;
// }
// Console.WriteLine($"Если N = {n} ,  ")


Console.Clear();
Console.Write("Введите первые 'N' чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] GetFibonacci(int N)
{
    int first = 0;
    int second = 1;
    int[] fibonacci = new int[N];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 1; i < N; i++)
    {
        fibonacci[i] = first + second;
        second = first;
        first = fibonacci[i];
    }
    return fibonacci;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
Console.Write($"\n{N}! = ");
PrintArray(GetFibonacci(N));
Console.WriteLine();
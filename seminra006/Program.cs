// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число ");
string input = Console.ReadLine();
int N_start = Convert.ToInt32(input);
int N_stop = - N_start;
Console.WriteLine(N_stop);
while (N_stop < N_start)
    {
        N_stop = N_stop + 1;
        Console.WriteLine(N_stop);
    }



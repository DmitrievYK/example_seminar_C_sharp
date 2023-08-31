// Функция вычисления чисел Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

//  функция расчета числа фибоначи
double Fibonacci (int n)
{
    if( n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}


// задаем сразу несколько чисел
for (int i = 1; i <50; i++) // лучше ставить 40 быстрее будет считать
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

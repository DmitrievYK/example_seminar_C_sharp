// l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2+ (z 2 - z 1) 2)
//AB = √(xb - xa)2 + (yb - ya)2

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// метод для ввода чисел в массив и вывода на экран
void ReadandPrintArray(int[] array) 
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Вы ввели координаты точки: {array[0]}, {array[1]}");
}
Console.WriteLine("Введите координаты точки А: ");
int[] A = new int[2];

ReadandPrintArray(A);

Console.WriteLine("Введите координаты точки B: ");
int[] B = new int[2];

ReadandPrintArray(B);

Console.WriteLine("Результат расчета");
double result = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2));

Console.WriteLine(result); 

Console.WriteLine(Math.Floor(result*100)/100);// умножение числа на 100 сдвигает десятичную 
// запятую вправо на два знака, а затем `Math.Floor()` округляет число в меньшую сторону. 
// Деление на 100 возвращает число обратно в его исходное положение с двумя знаками после запятой.
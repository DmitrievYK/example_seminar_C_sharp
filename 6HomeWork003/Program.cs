// Задача №50
// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число.
//  Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент)
//   и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, 
// а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition.
//  Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

int[,] CreateIncreasingMatrix(int n, int m, int k) // создаем матрицу с заданной размерностью. n - строки, m - столбцы, k - число, на которое увеличивается каждый новый элемент
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10) + k;
        }
    }
    return matrix;

}
void PrintArray(int[,] matrix) // Вывод матрицы на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[] FindNumberByPosition(int[,] matrix, int x, int y) // Проверка координаты на вхождение в матрицу и запись позиции в массив (из 2-х чисел)
{
    int[] number = new int[2];
    if (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
    {
        number[0] = matrix[x, y];
        number[1] = 0;
        return number;
    }
    else 
    {
        return new int[2];
    }    


}

void PrintCheckIfError(int[] arrayPosition, int x, int y) //Печать результатов поиска
{
    if (arrayPosition[0] != 0 && arrayPosition[1] == 0)
    {
        Console.WriteLine($"The number in [{x}, {y}] is {arrayPosition[0]}");
    }
    else Console.WriteLine("There is no such index");
}
int n = 3;
int m = 4;
int k = 2;
int x = 2;
int y = 3;
int[,] matrix = CreateIncreasingMatrix(n, m, k);
int[] arrayPosition = FindNumberByPosition(matrix, x, y);
PrintArray(matrix);
Console.WriteLine();
FindNumberByPosition(matrix, x, y);
PrintCheckIfError(arrayPosition, x, y);
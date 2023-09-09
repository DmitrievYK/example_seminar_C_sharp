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
void PrintArray(int[,] matrix)
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
int[] FindNumberByPosition(int[,] matrix, int x, int y)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] number = new int[2];
    if (x >= 0 && x < rows - 1  && y >= 0 && y < columns - 1 )
    {
        Console.Write(matrix[x, y] + " ");
        number[0] = number[matrix[x, y]];
        number[1] = 0;
        //Console.WriteLine("[ " + String.Join(", ", number) + " ]");
        return number;
    }
    else return new int[2];    


}

//int PrintCheckIfError()
int n = 3;
int m = 4;
int k = 2;
int x = 2;
int y = 3;
int[,] matrix = CreateIncreasingMatrix(n, m, k);
PrintArray(matrix);
Console.WriteLine();
FindNumberByPosition(matrix, x, y);
PrintArray(matrix);

// Вот пример написания метода `FindNumberByPosition`, который принимает на вход сгенерированную матрицу и координаты `x` и `y`. 
// Метод будет проверять, находятся ли указанные координаты в пределах границ массива, и в зависимости от этого, 
// возвращать массив с числом на указанной позиции или массив с нулевым значением:

// ```csharp
// public int[] FindNumberByPosition(int[,] matrix, int x, int y)
// {
// int rows = matrix.GetLength(0);
// int columns = matrix.GetLength(1);

// if (x >= 0 && x < rows && y >= 0 && y < columns)
// {
// int[] result = new int[2];
// result[0] = matrix[x, y];
// result[1] = 0;
// return result;
// }
// else
// {
// return new int[2];
// }
// }
// ```

// В этом примере мы используем методы `GetLength(0)` и `GetLength(1)`, чтобы определить количество строк (`rows`) и столбцов (`columns`) в матрице `matrix`. 
// Затем мы проверяем, находятся ли координаты `x` и `y` в пределах границ матрицы.
//  Если да, мы создаем новый массив `result` с двумя элементами: числом из матрицы на указанной позиции и 
//  вторым элементом со значением 0 для показа успешного выполнения операции. 
//  Если координаты находятся за пределами границ массива, мы просто возвращаем новый массив с нулевыми значениями.

// Вы можете вызвать метод следующим образом:

// ```csharp
// int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// int x = 1;
// int y = 1;
// int[] result = FindNumberByPosition(matrix, x, y);
// Console.WriteLine("Значение числа на позиции ({0}, {1}): {2}", x, y, result[0]);
// Console.WriteLine("Статус операции: {0}", result[1] == 0 ? "Успешно" : "Ошибка");
// ```

// В этом примере мы создаем двумерный массив `matrix` размером 3x3 как пример сгенерированной матрицы. 
// Затем мы вызываем метод `FindNumberByPosition` с координатами `(1, 1)` и выводим результат.
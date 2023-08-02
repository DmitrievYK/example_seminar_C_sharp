
// void - это метод который не возвращает значения

void FillArray(int[] collection) // метод заполняющий массив рандомным числами от 1 до 10, с именем аргумента collection
{
    int length = collection.Length; // длинна равная длинне массива с именем аргумента collection
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); // создание рандомного числа от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) // метод печатающий массив с именем аргумента col\
{
    int count = col.Length; // count равный длинне аргумента col 
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод который по массиву collection, ищет элемент find
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // контейнер который запоминает индекс искомого элемента find (-1 это когда нет элемента в массиве выводит -1)

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position; // возвращаем так как этот метод с возвращаемыми элементами

}

int[] array = new int[10]; // создание массива из 10 цифр, наполненый нулями

FillArray(array);
PrintArray(array);
Console.WriteLine(); // вывод пустой строки чтобы сделать отступ и видеть что результат не слился с массивом

int pos = IndexOf(array, 4); // мы задаем переменную pos с методом внутри IndexOf (поиск искомого значения) с массивом array(строка 44) и заданным значением 4 (не индекс, а именно значение, который подставляется в find в методе IndexOf)
Console.WriteLine(pos);
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = GetArray(7, -5, 5);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine("-------------");
// int[] array2= Create_New_Array(array);
// Console.WriteLine(String.Join(" ", array2));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }


// int[] Create_New_Array(int[] arr)				// метод для перемножения пар чисел в одномерном массиве 
// 								// и передачи результатов перемножения в новый массив
// {
//     int size=0;								
//     if (arr.Length%2==1) size=arr.Length/2+1;			// условие, при котором если в исходном массиве нечетное число элементов, 
//     else size=arr.Length/2;					// чтобы при перемножении пар элементов, начиная с концов массива создать иллюзию
//     								// перемножения центрального элемента самого на себя
//     int[] res = new int[size];					// создание нового массива, куда будут записаны результаты перемножения
//     for (int i = 0; i < size; i++)	
//     {
//         if ((arr.Length%2==1)&&(i==size-1)) res[i]=arr[i];	// условие, при котором при нечетном количестве элементов исходного массива 
//         else res[i] = arr[i]*arr[arr.Length-i-1];		// средний его элемент будет приравнен к последнему элементу нового массива
//     }
//     return res;
// }


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);

int[] SumaPara(int[] arr)
{
    int size = 0;
    if (arr.Length%2==1) 
    {
        size=arr.Length/2+1;
    }
    else
    {
        size=arr.Length/2;
    }
    int[] res = new int[size];	

    for (int i = 0; i<size; i++)
    {
        if ((arr.Length%2==1) && (i==size-1))
        {
            res[i]=arr[i];
        }
        else 
        {
            res[i] = arr[i]*arr[arr.Length-i-1];
        }
    }
    return res;
}
int[] res = SumaPara(array);
Console.WriteLine((String.Join(" ", res)));



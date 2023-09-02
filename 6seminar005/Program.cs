// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// 1. Число раздвелить на два 
// 2. Остаток от числа подлеить тоже на два

// необходимо доделывать с массивом 
// int number = Convert.ToInt32(Console.ReadLine());
// int counter = 0;
// int counter_( int number){
//     while(number > 0){
//         number /= 2;
//         counter ++;
//     }
//     return counter;
// }
// counter_(number);
// void final(int number, int counter){
//     for(int i = 0; i < counter; i ++){
//         int bu = number / 2;
//         if(number % 2 == 0){
//             Console.Write(0 + " ");
//         }
//         else{
//             Console.Write(1 + " ");
//         }
//         number = bu;
//     }
// }
// final(number, counter);


// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int Transform(int n)
// {
//     string result = 0;
//     int left = 0;
//     int right = 0;

 
//     While( N != 0)
//     {
//         n %= 2;
//         n %= 2;
//         count++;
//     }
// }

Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());
string binaryString = "";
while (decimalNumber > 0)
{
     int remainder = decimalNumber % 2;
     decimalNumber /= 2;
     binaryString = remainder + binaryString; // Аналогично binaryString += remainder;  запись числа сначало(remainder) потом строка binaryString
 }
 Console.WriteLine($"Двоичное представление числа: {binaryString}");
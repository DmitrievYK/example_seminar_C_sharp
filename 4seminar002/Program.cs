// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
static int DigitsNumber (int value){
    if (value < 0)
    {
        value = - value; // можно запаисать value * -1
    }
    string number = value.ToString ();
    return number.Length;
}
int number = Print("Введите число");

Console.WriteLine(DigitsNumber(number));


// / Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// //89126 -> 5

// int getNumber (){
//     Console.WriteLine("Введите число");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int countElements (int number){
//     if (number < 0) 
//     {
//         number = number * -1;
//     }
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;  
//     }
//     return count;
// }

// int number = getNumber();
// int sum = countElements(number);
// Console.WriteLine("Итого символов " + sum);
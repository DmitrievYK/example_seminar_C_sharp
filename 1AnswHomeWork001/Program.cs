// // Решение задачи №1 (Решение 1)
// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже

//       int rev = number;
//       if (number < 10000 || number >= 100000)
//       {
//         Console.WriteLine("Число не пятизначноге");
//         return false;
//       }

//       int mirror = 0;
//       while (rev !=0)
//       {
//         int digit = rev % 10;
//         mirror = mirror * 10 + digit;
//         rev /= 10;
//       }
//       return mirror == number;

//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }
//****************************************
// Решение задачи №1 (вариант 2) - Отправленный
// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       int rev = number;
//       int mirror = 0;
//       if (number >= 10000 && number <= 100000)
//       {
        
//         while (rev !=0)
//         {
//           int digit = rev % 10;
//           mirror = mirror * 10 + digit;
//           rev /= 10;
//         }
//         }
//       else 
//       {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }
//       Console.WriteLine(number);
//       Console.WriteLine(mirror);

//       return number == mirror;

      
      
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 645464;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{number} -> {result}");
//     }
// }



// ***************************************
//  Решение задачи №2
// using System;
// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//       Console.WriteLine("Результат расчета:");
//       double DistanceBetweenPoints = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
//       Console.WriteLine($"Без округления = {DistanceBetweenPoints}");
//       Console.WriteLine($"Округление до сотых = {DistanceBetweenPoints:F2}");
      
//       return DistanceBetweenPoints;
      
 


//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 7;
//             x2 = -5;
//             x3 = 0;
//             y1 = 1;
//             y2 = -1;
//             y3 = 9;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }

// *********************************

// Решение задачи номер №3
using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      
      for (int i = 1; i <= N; i++)
      {
        int count = i*i*i;
        // int count = Convert.ToInt32(Math.Pow(i, 3));
        Console.WriteLine(count);
      }
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
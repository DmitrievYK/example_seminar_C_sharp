//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

string input = Console.ReadLine(); // Console выводит/возвращает всегда string
int number = Convert.ToInt32(input); // преобразование string в int (парсить)

//int input = Convert.ToInt32(Console.ReadLine()); // сократили предыдущие записи из двух строк

int result = number * number;
string newString = "Наш результат: " + result; // переменнная
Console.WriteLine("Наш результат: " + result);
Console.WriteLine(newString); // Второй вариант вывовда с заранее введенной переменной типа стринг(строка)

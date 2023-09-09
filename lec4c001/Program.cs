// рекурсии и возможные задачи с ними

// Собрать строку с числами от a до b, a<=b
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NumberFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// Собрать строку с числами от a до b, a>=b
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}
Console.WriteLine(NumberFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

// Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i < n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); //3628800
Console.WriteLine(FactorialRec(10)); //3628800

// Вычислить а в степени n
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{   //return n == 0 ? 1 : PowerRec(a, n - 1) * a; (сокращенная запись 81 и 82 строки)
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

// Перебор слов (составление слов из имеющихся букв)
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // однобуквенные слова
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}
//***** увеличенеие букв в слове
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // двухбуквенные слова
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}
//***** увеличенеие букв в слове
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // трехбуквенные слова
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}
//**** Общее решение через рекурсию
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);

// Метод который проходит по всем папкам в какойто выборочной папке (через рекурсию)
string path = "C:\1\Example_C#";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); //(di.FullName);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalog = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalog[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string [path] = @"C:\1\Example_C#";
CatalogInfo(path);

// Задача с тремя башнями - блинчики перекладываются с одного шпиля на 
// другой за определенное количество ходов (через рекурсию)

void Towers(string with = "1", string on ="3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
// Двоичное дерево -> https://ru.wikipedia.org/wiki/%D0%94%D0%B2%D0%BE%D0%B8%D1%87%D0%BD%D0%BE%D0%B5_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%BE
// Обход дерева -> https://ru.wikipedia.org/wiki/%D0%9E%D0%B1%D1%85%D0%BE%D0%B4_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%B0
// Обход разных структур (решение через бинарное дерево)
// ((4 - 2) * (1 + 3)) / 10
//                     /
//          *            10
//     -         +
//  4    2     1   3
string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                  0   1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();

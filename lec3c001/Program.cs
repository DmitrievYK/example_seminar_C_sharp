// Как нужно писать код 
// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/  ссылка на статью каких правил мы придерживаемся при написании в языке С#
// Ключевые слова C# -> https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/
// Лексическая структура (swift) -> https://docs.swift.org/swift-book/documentation/the-swift-programming-language/lexicalstructure/
// Правила и соглашения об именовании идентификаторов C# - > https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/identifier-names
// Общие соглашения о коде C# -> https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions


using System.Drawing;
using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "");
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x*10, point.y))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //Console.WriteLine(data[i].x*10);
    Console.WriteLine();
}
//Задание 1
// Создайте метод расширение (extension method) для 
//проверки является ли целое число нечётным. Напишите 
//код для тестирования метода.

using System;

namespace Task1
{
    public static class IntOddExtension
    {
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1 — IsOdd()");
            Console.WriteLine($"5 нечётное? {5.IsOdd()}");
            Console.WriteLine($"8 нечётное? {8.IsOdd()}");
        }
    }
}

// Задание 2
// Создайте метод расширение (extension method) для 
//проверки является ли целое число чётным. Напишите 
//код для тестирования метода.

using System;

namespace Task2
{
    public static class IntEvenExtension
    {
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 2 — IsEven()");
            Console.WriteLine($"5 чётное? {5.IsEven()}");
            Console.WriteLine($"8 чётное? {8.IsEven()}");
        }
    }
}

// Задание 3
// Создайте метод расширение (extension method) для 
//проверки является ли целое число простым. Напишите 
//код для тестирования метода.

using System;

namespace Task3
{
    public static class IntPrimeExtension
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 3 — IsPrime()");
            Console.WriteLine($"2 простое? {2.IsPrime()}");
            Console.WriteLine($"15 простое? {15.IsPrime()}");
            Console.WriteLine($"17 простое? {17.IsPrime()}");
        }
    }
}

// Задание 4
// Создайте метод расширение (extension method) для 
//подсчёта количества гласных в строке. Напишите код 
//для тестирования метода.

using System;
using System.Linq;

namespace Task4
{
    public static class StringVowelExtension
    {
        private static readonly char[] Vowels =
        {
            'a','e','i','o','u','y',
            'а','е','ё','и','о','у','ы','э','ю','я'
        };

        public static int CountVowels(this string text)
        {
            return text.Count(c => Vowels.Contains(char.ToLower(c)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 4 — CountVowels()");
            Console.WriteLine($"Гласных в \"Hello World\": {"Hello World".CountVowels()}");
        }
    }
}

// Задание 5
// Создайте метод расширение (extension method) для 
//подсчёта количества согласных в строке. Напишите код 
//для тестирования метода.

using System;
using System.Linq;

namespace Task5
{
    public static class StringConsonantExtension
    {
        private static readonly char[] Vowels =
        {
            'a','e','i','o','u','y',
            'а','е','ё','и','о','у','ы','э','ю','я'
        };

        public static int CountConsonants(this string text)
        {
            return text.Count(c => char.IsLetter(c) &&
                                   !Vowels.Contains(char.ToLower(c)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5 — CountConsonants()");
            Console.WriteLine($"Согласных в \"Hello\": {"Hello".CountConsonants()}");
        }
    }
}

//Задание 6
// Создайте метод расширение (extension method) для 
//подсчёта количества предложений в строке. Напишите 
//код для тестирования метода.

using System;

namespace Task6
{
    public static class SentenceExtension
    {
        public static int CountSentences(this string text)
        {
            return text.Split(new char[] { '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 6 — CountSentences()");
            string text = "Hi. How are you? Fine!";
            Console.WriteLine($"Количество предложений: {text.CountSentences()}");
        }
    }
}

// Задание 7
// Создайте запись Person. Необходимо хранить инфор
//мацию об имени, фамилии, возрасте. Создайте массив 
//записей Person. Напишите код для поиска человека с 
//минимальным, максимальным возрастом. Отобразите 
//средний возраст людей (реализуйте с использованием 
//extension method). 

using System;
using System.Linq;

namespace Task7
{
    public record Person(string Name, string Surname, int Age);

    public static class PersonExtensions
    {
        public static double AverageAge(this Person[] persons)
        {
            return persons.Average(p => p.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 7 — Person");

            Person[] people =
            {
                new Person("Ivan", "Petrov", 20),
                new Person("Oleg", "Sidorov", 35),
                new Person("Anna", "Ivanova", 28)
            };

            var youngest = people.MinBy(p => p.Age);
            var oldest = people.MaxBy(p => p.Age);

            Console.WriteLine($"Самый молодой: {youngest}");
            Console.WriteLine($"Самый старший: {oldest}");
            Console.WriteLine($"Средний возраст: {people.AverageAge()}");
        }
    }
}

//Задание 8
// Создайте запись Point3D. Необходимо хранить ин
//формацию о координатах точки в трёхмерном про
//странстве. Создайте массив точек. Напишите код для 
//вычисления расстояния между точками. Отобразите 
//максимальное расстояние между точками и информа
//цию об этих точках.

using System;

namespace Task8
{
    public record Point3D(double X, double Y, double Z);

    public static class PointExtensions
    {
        public static double DistanceTo(this Point3D a, Point3D b)
        {
            return Math.Sqrt(
                Math.Pow(a.X - b.X, 2) +
                Math.Pow(a.Y - b.Y, 2) +
                Math.Pow(a.Z - b.Z, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 8 — Point3D");

            Point3D[] pts =
            {
                new Point3D(0, 0, 0),
                new Point3D(1, 2, 2),
                new Point3D(3, 5, 1)
            };

            double maxDistance = 0;
            Point3D pA = null, pB = null;

            for (int i = 0; i < pts.Length; i++)
            {
                for (int j = i + 1; j < pts.Length; j++)
                {
                    double d = pts[i].DistanceTo(pts[j]);
                    if (d > maxDistance)
                    {
                        maxDistance = d;
                        pA = pts[i];
                        pB = pts[j];
                    }
                }
            }

            Console.WriteLine($"Максимальное расстояние: {maxDistance}");
            Console.WriteLine($"Между точками: {pA} и {pB}");
        }
    }
}

// Задание 9
// Создайте запись «Дробь». Нужно хранить информацию 
//о числителе и знаменателе. Напишите код для поиска ми
//нимальной и максимальной дроби (используйте extension 
//method). Отобразите результаты на экран.
using System;
using System.Linq;

namespace Task9
{
    public record Fraction(int Numerator, int Denominator);

    public static class FractionExtensions
    {
        public static double Value(this Fraction f)
        {
            return (double)f.Numerator / f.Denominator;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 9 — Fraction");

            Fraction[] fractions =
            {
                new Fraction(1, 2),
                new Fraction(3, 4),
                new Fraction(2, 5),
                new Fraction(7, 8)
            };

            var minFraction = fractions.MinBy(f => f.Value());
            var maxFraction = fractions.MaxBy(f => f.Value());

            Console.WriteLine($"Минимальная дробь: {minFraction} (значение {minFraction.Value()})");
            Console.WriteLine($"Максимальная дробь: {maxFraction} (значение {maxFraction.Value()})");
        }
    }
}


//Задание 1
// Создайте метод расширение (extension method) для 
//проверки является ли целое число числом Фибоначчи. 
//Напишите код для тестирования метода.

using System;

namespace Task1
{
    public static class IntFibonacciExtension
    {
        public static bool IsFibonacci(this int n)
        {
            bool IsPerfectSquare(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1 — Проверка числа Фибоначчи");
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 13, 21, 22 };

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} — Фибоначчи? {num.IsFibonacci()}");
            }
        }
    }
}

// Задание 2
// Создайте метод расширение (extension method) для 
//подсчёта количества слов в строке. Напишите код для 
//тестирования метода.

using System;

namespace Task2
{
    public static class StringWordCountExtension
    {
        public static int WordCount(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            var words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 2 — Подсчёт количества слов");

            string sentence = "Hello world! This is a test sentence.";
            Console.WriteLine($"Текст: \"{sentence}\"");
            Console.WriteLine($"Количество слов: {sentence.WordCount()}");
        }
    }
}

// Задание 3
// Создайте метод расширение (extension method) для 
//подсчёта длины последнего слова в строке. Напишите 
//код для тестирования метода.

using System;

namespace Task3
{
    public static class StringLastWordExtension
    {
        public static int LastWordLength(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            var words = text.Trim().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length > 0 ? words[words.Length - 1].Length : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 3 — Длина последнего слова");

            string sentence = "Hello world from CSharp";
            Console.WriteLine($"Текст: \"{sentence}\"");
            Console.WriteLine($"Длина последнего слова: {sentence.LastWordLength()}");
        }
    }
}

// Задание 4
// Создайте метод расширение (extension method) для 
//проверки валидности расставления скобок в строке. В 
//строке могут содержаться такие скобки: (,), {,}, [,.
// Открывающиеся скобки должны закрываться скоб
//ками того же типа.Открывающиеся скобки должны
//закрываться в правильном порядке.Например:
// ■ {}[] — валидная строка;
// ■ (()) — валидная строка;
// ■ [{}] — валидная строка;
// ■ [} — невалидная строка;
// ■ [[{]}] — невалидная строка.
// Напишите код для тестирования метода.

using System;
using System.Collections.Generic;

namespace Task4
{
    public static class StringBracketExtension
    {
        public static bool IsValidBrackets(this string text)
        {
            var stack = new Stack<char>();
            var pairs = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };

            foreach (char c in text)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[c])
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 4 — Проверка валидности скобок");

            string[] examples = { "{}[]", "(())", "[{}]", "[}", "[[{]}]" };

            foreach (var ex in examples)
            {
                Console.WriteLine($"\"{ex}\" — валидная? {ex.IsValidBrackets()}");
            }
        }
    }
}

// Задание 5
// Создайте метод расширение для фильтрации элемен
//тов массива целых на основании переданного аргумента 
//(предикат для определения условия). Метод возвращает 
//новый, созданный массив после фильтрации. Например,
//в качестве условия может быть предикат для проверки на 
//чётность или нечётность элементов массива.

using System;
using System.Linq;

namespace Task5
{
    public static class ArrayFilterExtension
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            return array.Where(predicate).ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5 — Фильтрация массива");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            var evenNumbers = numbers.Filter(n => n % 2 == 0);
            var oddNumbers = numbers.Filter(n => n % 2 != 0);

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");
            Console.WriteLine($"Чётные: {string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Нечётные: {string.Join(", ", oddNumbers)}");
        }
    }
}

// Задание 6
// Создайте запись «Дневная температура». Необходимо 
//хранить информацию о самой большой и самой маленькой 
//температуре за день. Создайте массив температур. Напи
//шите код для вычисления дня с максимальной разницей 
//между самой большой и самой маленькой температурой.

using System;
using System.Linq;

namespace Task6
{
    public record DayTemperature(int MaxTemp, int MinTemp);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 6 — Дневная температура");

            DayTemperature[] temperatures =
            {
                new DayTemperature(30, 20),
                new DayTemperature(25, 10),
                new DayTemperature(28, 15),
                new DayTemperature(35, 18)
            };

            var dayWithMaxDiff = temperatures
                .Select((temp, index) => new { Temp = temp, Index = index + 1, Diff = temp.MaxTemp - temp.MinTemp })
                .OrderByDescending(x => x.Diff)
                .First();

            Console.WriteLine($"День с максимальной разницей: День {dayWithMaxDiff.Index} ({dayWithMaxDiff.Temp.MaxTemp}°C / {dayWithMaxDiff.Temp.MinTemp}°C), разница {dayWithMaxDiff.Diff}°C");
        }
    }
}

// Задание 7
// Создайте запись «Оценки студента». Необходимо хра
//нить информацию об экзаменационных оценках студента 
//по набору предметов. Создайте массив оценок. Напишите 
//код для отображения студента с максимальной, средней 
//оценкой.
using System;
using System.Linq;

namespace Task7
{
    public record StudentGrades(string Name, int[] Grades);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 7 — Оценки студента");

            StudentGrades[] students =
            {
                new StudentGrades("Ivan", new int[] { 5, 4, 3, 4 }),
                new StudentGrades("Anna", new int[] { 4, 4, 5, 5 }),
                new StudentGrades("Oleg", new int[] { 3, 4, 2, 5 })
            };

            var studentWithMaxAvg = students.OrderByDescending(s => s.Grades.Average()).First();
            var studentWithMinAvg = students.OrderBy(s => s.Grades.Average()).First();

            Console.WriteLine($"Студент с максимальной средней оценкой: {studentWithMaxAvg.Name} ({studentWithMaxAvg.Grades.Average():F2})");
            Console.WriteLine($"Студент с минимальной средней оценкой: {studentWithMinAvg.Name} ({studentWithMinAvg.Grades.Average():F2})");
        }
    }
}
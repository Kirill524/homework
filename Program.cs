//Задание 1
// Напишите метод, который отображает квадрат из 
//некоторого символа. Метод принимает в качестве пара
//метра: длину стороны квадрата, символ.

using System;

class Program
{
    static void DrawSquare(int size, char symbol)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main1()
    {
        DrawSquare(5, '*'); 
    }
}

// Задание 2
// Напишите метод, который проверяет является ли 
//переданное число «палиндромом». Число передаётся в 
//качестве параметра. Если число палиндром нужно вер
//нуть из метода true, иначе false.
// Палиндром — число, которое читается одинаково как 
//справа налево, так и слева направо. Например:
// 1221 — палиндром;
//3443 — палиндром;
//7854 — не палиндром.

using System;

class Program2
{
    static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
                return false;
        }
        return true;
    }

    static void Main2()
    {
        int num = 1221;
        Console.WriteLine($"{num} палиндром? {IsPalindrome(num)}"); 
    }
}

// Задание 3
// Напишите метод, фильтрующий массив на основании 
//переданных параметров. Метод принимает параметры: 
//оригинальный_массив, массив_с_данными_для_филь
//трации.
// Метод возвращает оригинальный массив без элемен
//тов, которые есть в массиве для фильтрации.
// Например:
// 1 2 6 - 1 88  7 6 — оригинальный массив;
//6 88 7 — массив для фильтрации;
//1 2 - 1 — результат работы метода.

using System;

class Program3
{
    static int[] FilterArray(int[] original, int[] filter)
    {
        return original.Where(x => !filter.Contains(x)).ToArray();
    }

    static void Main3()
    {
        int[] original = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filter = { 6, 88, 7 };
        int[] result = FilterArray(original, filter);

        Console.WriteLine("Результат фильтрации: " + string.Join(" ", result));
    }
}

// Задание 4
// Создайте класс «Веб-сайт». Необходимо хранить в 
//полях класса: название сайта, путь к сайту, описание 
//сайта, ip адрес сайта. Реализуйте методы класса для ввода 
//данных, вывода данных, реализуйте доступ к отдельным 
//полям через методы класса.  

using System;

class Website
{
    private string name;
    private string path;
    private string description;
    private string ip;

    public void InputData()
    {
        Console.Write("Название сайта: ");
        name = Console.ReadLine();
        Console.Write("Путь к сайту: ");
        path = Console.ReadLine();
        Console.Write("Описание сайта: ");
        description = Console.ReadLine();
        Console.Write("IP адрес: ");
        ip = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"Название: {name}\nПуть: {path}\nОписание: {description}\nIP: {ip}");
    }

    public string GetName() => name;
    public string GetPath() => path;
    public string GetDescription() => description;
    public string GetIP() => ip;
}

class Program4
{
    static void Main4()
    {
        Website site = new Website();
        site.InputData();
        site.ShowData();
        Console.WriteLine("Название сайта через метод: " + site.GetName());
    }
}

//Задание 5
// Создайте класс «Журнал». Необходимо хранить в 
//полях класса: название журнала, год основания, описа
//ние журнала, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода 
//данных, реализуйте доступ к отдельным полям через 
//методы класса.

using System;

class Journal
{
    private string name;
    private int year;
    private string description;
    private string phone;
    private string email;

    public void InputData()
    {
        Console.Write("Название журнала: ");
        name = Console.ReadLine();
        Console.Write("Год основания: ");
        year = int.Parse(Console.ReadLine());
        Console.Write("Описание журнала: ");
        description = Console.ReadLine();
        Console.Write("Телефон: ");
        phone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"Название: {name}\nГод: {year}\nОписание: {description}\nТелефон: {phone}\nEmail: {email}");
    }

    public string GetName() => name;
    public int GetYear() => year;
    public string GetDescription() => description;
    public string GetPhone() => phone;
    public string GetEmail() => email;
}

class Program5
{
    static void Main5()
    {
        Journal journal = new Journal();
        journal.InputData();
        journal.ShowData();
        Console.WriteLine("Название журнала через метод: " + journal.GetName());
    }
}

// Задание 6
// Создайте класс «Магазин». Необходимо хранить в 
//полях класса: название магазина, адрес, описание про
//филя магазина, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода 
//данных, реализуйте доступ к отдельным полям через 
//методы класса.
using System;

class Store
{
    private string name;
    private string address;
    private string profile;
    private string phone;
    private string email;

    public void InputData()
    {
        Console.Write("Название магазина: ");
        name = Console.ReadLine();
        Console.Write("Адрес: ");
        address = Console.ReadLine();
        Console.Write("Описание профиля: ");
        profile = Console.ReadLine();
        Console.Write("Телефон: ");
        phone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"Название: {name}\nАдрес: {address}\nПрофиль: {profile}\nТелефон: {phone}\nEmail: {email}");
    }

    public string GetName() => name;
    public string GetAddress() => address;
    public string GetProfile() => profile;
    public string GetPhone() => phone;
    public string GetEmail() => email;
}

class Program6
{
    static void Main6()
    {
        Store store = new Store();
        store.InputData();
        store.ShowData();
        Console.WriteLine("Название магазина через метод: " + store.GetName());
    }
}



//Задание 1
// Создайте приложение калькулятор для перевода числа 
//из одной системы исчисления в другую. Пользователь с по
//мощью меню выбирает направление перевода. Например,
//из десятичной в двоичную. После выбора направления,
//пользователь вводит число в исходной системе исчисления. 
//Приложение должно перевести число в требуемую систе
//му. Предусмотреть случай выхода за границы диапазона,
//определяемого типом int, неправильный ввод.

using System;

class BaseConverter
{
    public static void ConvertNumber()
    {
        Console.WriteLine("Выберите направление перевода:");
        Console.WriteLine("1. Десятичная -> Двоичная");
        Console.WriteLine("2. Десятичная -> Восьмеричная");
        Console.WriteLine("3. Десятичная -> Шестнадцатеричная");
        Console.WriteLine("4. Двоичная -> Десятичная");
        Console.WriteLine("5. Восьмеричная -> Десятичная");
        Console.WriteLine("6. Шестнадцатеричная -> Десятичная");
        Console.Write("Выбор: ");

        string choice = Console.ReadLine();

        try
        {
            switch (choice)
            {
                case "1":
                    Console.Write("Введите число в десятичной системе: ");
                    int dec1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Двоичное: " + Convert.ToString(dec1, 2));
                    break;
                case "2":
                    Console.Write("Введите число в десятичной системе: ");
                    int dec2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Восьмеричное: " + Convert.ToString(dec2, 8));
                    break;
                case "3":
                    Console.Write("Введите число в десятичной системе: ");
                    int dec3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Шестнадцатеричное: " + Convert.ToString(dec3, 16));
                    break;
                case "4":
                    Console.Write("Введите число в двоичной системе: ");
                    string bin = Console.ReadLine();
                    int decFromBin = Convert.ToInt32(bin, 2);
                    Console.WriteLine("Десятичное: " + decFromBin);
                    break;
                case "5":
                    Console.Write("Введите число в восьмеричной системе: ");
                    string oct = Console.ReadLine();
                    int decFromOct = Convert.ToInt32(oct, 8);
                    Console.WriteLine("Десятичное: " + decFromOct);
                    break;
                case "6":
                    Console.Write("Введите число в шестнадцатеричной системе: ");
                    string hex = Console.ReadLine();
                    int decFromHex = Convert.ToInt32(hex, 16);
                    Console.WriteLine("Десятичное: " + decFromHex);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат числа!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число выходит за пределы типа int!");
        }
    }

    static void Main1()
    {
        ConvertNumber();
    }
}

// Задание 2
// Пользователь вводит словами цифру от 0 до 9. Прило
//жение должно перевести слово в цифру. Например, если 
//пользователь ввёл five, приложение должно вывести на экран 5. 

using System;
using System.Collections.Generic;

class WordToDigit
{
    static void Main2()
    {
        Dictionary<string, int> map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
            {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };

        Console.Write("Введите цифру словами (0-9): ");
        string input = Console.ReadLine();

        if (map.ContainsKey(input))
        {
            Console.WriteLine("Цифра: " + map[input]);
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }
}

//Задание 3
// Создайте класс «Заграничный паспорт». Вам необходимо 
//хранить информацию о номере паспорта, ФИО владельца,
//дате выдачи и т.д. Предусмотреть механизмы для инициа
//лизации полей класса. Если значение для инициализации 
//неверное, генерируйте исключение. 

using System;

class Passport
{
    public string Number { get; private set; }
    public string FullName { get; private set; }
    public DateTime IssueDate { get; private set; }

    public Passport(string number, string fullName, string issueDate)
    {
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Номер паспорта не может быть пустым!");
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("ФИО не может быть пустым!");
        if (!DateTime.TryParse(issueDate, out DateTime date))
            throw new ArgumentException("Неверная дата!");

        Number = number;
        FullName = fullName;
        IssueDate = date;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Номер паспорта: {Number}\nФИО: {FullName}\nДата выдачи: {IssueDate.ToShortDateString()}");
    }

    static void Main3()
    {
        try
        {
            Passport p = new Passport("AB1234567", "Иванов Иван Иванович", "2020-05-15");
            p.ShowInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}

// Задание 4
// Пользователь вводит в строку с клавиатуры логическое 
//выражение. Например, 3>2 или 7<3. Программа должна 
//посчитать результат введенного выражения и дать резуль
//тат true или false. В строке могут быть только целые числа 
//и операторы: <, >, <=, >=, ==, !=.Для обработки ошибок 
//ввода используйте механизм исключений.
using System;

class LogicalEvaluator
{
    static void Main4()
    {
        Console.Write("Введите логическое выражение (например, 3>2): ");
        string input = Console.ReadLine();

        try
        {
            bool result = EvaluateExpression(input);
            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    static bool EvaluateExpression(string expr)
    {
        expr = expr.Replace(" ", "");
        string[] operators = { "<=", ">=", "==", "!=", "<", ">" };
        foreach (string op in operators)
        {
            int idx = expr.IndexOf(op);
            if (idx > 0)
            {
                int left = int.Parse(expr.Substring(0, idx));
                int right = int.Parse(expr.Substring(idx + op.Length));
                return op switch
                {
                    "<" => left < right,
                    ">" => left > right,
                    "<=" => left <= right,
                    ">=" => left >= right,
                    "==" => left == right,
                    "!=" => left != right,
                    _ => throw new Exception("Неверный оператор")
                };
            }
        }
        throw new Exception("Неверное выражение");
    }
}



//Задание 1
// Напишите метод, который возвращает произведение 
//чисел в указанном диапазоне. Границы диапазона переда
//ются в качестве параметров.

using System;

class Program1
{
    static long ProductInRange(int start, int end)
    {
        long product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }
        return product;
    }

    static void Main1()
    {
        Console.WriteLine("Произведение чисел от 1 до 5: " + ProductInRange(1, 5)); 
    }
}

// Задание 2
// Напишите метод, который проверяет является ли 
//число числом Фибоначчи. Число передаётся в качестве 
//параметра. Если число простое нужно вернуть из метода 
//true, иначе false.

using System;

class Program2
{
    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == number || number == 0;
    }

    static void Main2()
    {
        int num = 21;
        Console.WriteLine($"{num} является числом Фибоначчи? {IsFibonacci(num)}");
    }
}

// Задание 3
// Напишите метод, сортирующий массив по убыванию 
//или возрастанию в зависимости от выбора пользователя. 
//Алгоритм сортировки реализуйте самостоятельно. 
//Например, может быть реализована сортировка методом 
//перестановок.

using System;

class Program3
{
    static void BubbleSort(int[] arr, bool ascending)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && arr[j] > arr[j + 1]) || (!ascending && arr[j] < arr[j + 1]))
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main3()
    {
        int[] arr = { 5, 2, 9, 1, 7 };
        BubbleSort(arr, true); 
        Console.WriteLine("По возрастанию: " + string.Join(" ", arr));
        BubbleSort(arr, false); 
        Console.WriteLine("По убыванию: " + string.Join(" ", arr));
    }
}

// Задание 4
// Создайте класс «Город». Необходимо хранить в полях 
//класса: название города, название страны, количество 
//жителей в городе, телефонный код города, название районов города.
//Реализуйте методы класса для ввода данных,
//вывода данных, реализуйте доступ к отдельным полям 
//через методы класса.

using System;

class City
{
    private string name;
    private string country;
    private int population;
    private string phoneCode;
    private string district;

    public void InputData()
    {
        Console.Write("Название города: ");
        name = Console.ReadLine();
        Console.Write("Страна: ");
        country = Console.ReadLine();
        Console.Write("Количество жителей: ");
        population = int.Parse(Console.ReadLine());
        Console.Write("Телефонный код: ");
        phoneCode = Console.ReadLine();
        Console.Write("Район: ");
        district = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"Город: {name}\nСтрана: {country}\nНаселение: {population}\nКод: {phoneCode}\nРайон: {district}");
    }

    public string GetName() => name;
    public string GetCountry() => country;
    public int GetPopulation() => population;
    public string GetPhoneCode() => phoneCode;
    public string GetDistrict() => district;
}

// Задание 5
// Реализуйте класс «Сотрудник». Необходимо хранить в 
//полях класса: ФИО, дату рождения, контактный телефон,
//рабочий email, должность, описание служебных обязан
//ностей. Реализуйте методы класса для ввода данных, вы
//вода данных, реализуйте доступ к отдельным полям через 
//методы класса.

using System;

class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string phone;
    private string email;
    private string position;
    private string duties;

    public void InputData()
    {
        Console.Write("ФИО: ");
        fullName = Console.ReadLine();
        Console.Write("Дата рождения (yyyy-MM-dd): ");
        birthDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Телефон: ");
        phone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
        Console.Write("Должность: ");
        position = Console.ReadLine();
        Console.Write("Описание обязанностей: ");
        duties = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"ФИО: {fullName}\nДата рождения: {birthDate.ToShortDateString()}\nТелефон: {phone}\nEmail: {email}\nДолжность: {position}\nОбязанности: {duties}");
    }

    public string GetFullName() => fullName;
    public DateTime GetBirthDate() => birthDate;
    public string GetPhone() => phone;
    public string GetEmail() => email;
    public string GetPosition() => position;
    public string GetDuties() => duties;
}

// Задание 6
// Реализуйте класс «Самолёт». Необходимо хранить в 
//полях класса: название самолёта, название производите
//ля, год выпуска, тип самолёта. Реализуйте конструкторы 
//и методы класса для ввода данных, вывода данных, реа
//лизуйте доступ к отдельным полям через методы класса. 
//Используйте механизм перегрузки методов.

using System;

class Airplane
{
    private string name;
    private string manufacturer;
    private int year;
    private string type;

    public Airplane() { }

    public Airplane(string name, string manufacturer)
    {
        this.name = name;
        this.manufacturer = manufacturer;
    }

    public Airplane(string name, string manufacturer, int year, string type)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.year = year;
        this.type = type;
    }

    public void InputData()
    {
        Console.Write("Название самолёта: ");
        name = Console.ReadLine();
        Console.Write("Производитель: ");
        manufacturer = Console.ReadLine();
        Console.Write("Год выпуска: ");
        year = int.Parse(Console.ReadLine());
        Console.Write("Тип: ");
        type = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine($"Название: {name}\nПроизводитель: {manufacturer}\nГод выпуска: {year}\nТип: {type}");
    }

    public string GetName() => name;
    public string GetManufacturer() => manufacturer;
    public int GetYear() => year;
    public string GetTypePlane() => type;
}

// Задание 7
// Реализуйте класс «Матрица». Реализуйте конструк
//торы и методы класса для ввода данных, вывода данных,
//подсчёта максимума, подсчёта минимума. Используйте 
//механизм перегрузки методов.
using System;

class Matrix
{
    private int[,] data;
    private int rows;
    private int cols;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    public Matrix(int[,] arr)
    {
        rows = arr.GetLength(0);
        cols = arr.GetLength(1);
        data = (int[,])arr.Clone();
    }

    public void InputData()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"data[{i},{j}]: ");
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void ShowData()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(data[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int Max()
    {
        int max = data[0, 0];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (data[i, j] > max)
                    max = data[i, j];
        return max;
    }

    public int Min()
    {
        int min = data[0, 0];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (data[i, j] < min)
                    min = data[i, j];
        return min;
    }
}



//Задание 1
// Пользователь вводит с клавиатуры в строку набор 
//символов от 0-9. Необходимо преобразовать строку в 
//число целого типа. Предусмотреть случай выхода за гра
//ницы диапазона, определяемого типом int. Используйте 
//механизм исключений.

using System;

class Program1
{
    static void Main1()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            Console.WriteLine("Вы ввели число: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введена некорректная строка!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число выходит за пределы диапазона int!");
        }
    }
}

// Задание 2
// Пользователь вводит с клавиатуры в строку набор 
//0 и 1. Необходимо преобразовать строку в число цело
//го типа в десятичном представлении. Предусмотреть 
//случай выхода за границы диапазона, определяемого 
//типом int, неправильный ввод. Используйте механизм 
//исключений.  

using System;

class Program2
{
    static void Main2()
    {
        Console.Write("Введите число в двоичной системе (0 и 1): ");
        string input = Console.ReadLine();

        try
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    throw new FormatException("Строка содержит недопустимые символы!");
            }

            int number = Convert.ToInt32(input, 2);
            Console.WriteLine("Десятичное представление: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число выходит за пределы диапазона int!");
        }
    }
}

//Задание 3
// Создайте класс «Кредитная карточка». Вам необходимо 
//хранить информацию о номере карты, ФИО владельца,
//CVC, дата завершения работы карты и т.д. Предусмотреть 
//механизмы для инициализации полей класса. Если значение 
//для инициализации неверное, генерируйте исключение.

using System;

class CreditCard
{
    public string Number { get; private set; }
    public string FullName { get; private set; }
    public string CVC { get; private set; }
    public DateTime ExpiryDate { get; private set; }

    public CreditCard(string number, string fullName, string cvc, string expiryDate)
    {
        if (string.IsNullOrWhiteSpace(number) || number.Length != 16)
            throw new ArgumentException("Номер карты должен состоять из 16 цифр!");
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("ФИО владельца не может быть пустым!");
        if (string.IsNullOrWhiteSpace(cvc) || cvc.Length != 3)
            throw new ArgumentException("CVC должен состоять из 3 цифр!");
        if (!DateTime.TryParse(expiryDate, out DateTime date))
            throw new ArgumentException("Неверная дата окончания действия карты!");

        Number = number;
        FullName = fullName;
        CVC = cvc;
        ExpiryDate = date;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Номер карты: {Number}\nВладелец: {FullName}\nCVC: {CVC}\nСрок действия: {ExpiryDate:MM/yyyy}");
    }

    static void Main3()
    {
        try
        {
            CreditCard card = new CreditCard("1234567812345678", "Иванов Иван Иванович", "123", "12/2026");
            card.ShowInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}

// Задание 4
// Пользователь вводит в строку с клавиатуры математи
//ческое выражение. Например, 3*2*1*4. Программа должна 
//посчитать результат введенного выражения. В строке мо
//гут быть только целые числа и оператор *. Для обработки 
//ошибок ввода используйте механизм исключений.
using System;

class Program4
{
    static void Main4()
    {
        Console.Write("Введите выражение с умножением (например 3*2*1*4): ");
        string input = Console.ReadLine();

        try
        {
            string[] numbers = input.Split('*');
            int result = 1;
            foreach (string numStr in numbers)
            {
                if (!int.TryParse(numStr, out int num))
                    throw new FormatException("Неверный формат числа!");
                result *= num;
            }

            Console.WriteLine("Результат: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число выходит за пределы int!");
        }
    }
}
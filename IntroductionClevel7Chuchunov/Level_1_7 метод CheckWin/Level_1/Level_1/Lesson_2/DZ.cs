using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_2
{
    class DZ
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите минимальную температуру за сутки: ");
        //    string minTempStr = Console.ReadLine().Replace('.', ',');
        //    Console.Write("Введите максимальную температуру за сутки: ");
        //    string maxTempStr = Console.ReadLine().Replace('.', ',');

        //    bool isValidMinTemp = float.TryParse(minTempStr, out float minTemp);
        //    bool isValidMaxTemp = float.TryParse(maxTempStr, out float maxTemp);

        //    if (isValidMinTemp && isValidMaxTemp)
        //    {
        //        Console.WriteLine($"Среднесуточная температура равна {(minTemp + maxTemp) / 2.0f:f2}");
        //    }
        //    else if (!isValidMinTemp)
        //    {
        //        Console.WriteLine("Введено некорректное значение минимальной температуры. Невозможно вычислить среднесуточную температуру.");
        //    }
        //    else if (!isValidMaxTemp)
        //    {
        //        Console.WriteLine("Введено некорректное значение максимальной температуры. Невозможно вычислить среднесуточную температуру.");
        //    }
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    string storeName = "ООО \"Вкусвилл\"";
        //    string tin = "7734675810";
        //    string address = "117031, г. Москва, ул. Адмирала Лазарева, д.63";
        //    int shift = 412;
        //    int receiptNumber = 5;
        //    DateTime date = new DateTime(2021, 1, 21, 11, 41, 0);
        //    string cashier = "Муравьева Анастасия Васильевна";

        //    (string title, double price, double quantity, double vat)[] purchases = {
        //    ("Масло оливковое, шт", 448.00, 1, 0.1),
        //    ("Молоко цельное, шт", 58.00, 1, 0.1),
        //    ("Гель для мытья посуды, шт", 116.00, 1, 0.2),
        //    ("Яблоко карамелька, кг", 115.00, 0.736, 0.1)
        //    };

        //    //Итоговая сумма
        //    double result = 0.0;

        //    Console.WriteLine($"{storeName,52}");
        //    Console.WriteLine($"{"",-38}ИНН {tin}");
        //    Console.WriteLine($"{"",-40}Магазин");
        //    Console.WriteLine($"{address,70}");
        //    Console.WriteLine($"{"",-35}Кассовый чек. Приход");
        //    Console.WriteLine($"Смена: {shift}");
        //    Console.WriteLine($"Чек №: {receiptNumber} {"",42} Кассир: {cashier}");
        //    Console.WriteLine($"{date}");
        //    Console.WriteLine(("").PadRight(90, '-'));

        //    Console.WriteLine($"№{"",-5}{"Наименование",-43}{"Цена за ед.",-19}{"Кол.",-17}Сумма\n");
        //    for (int i = 0; i < purchases.Length; i++)
        //    {
        //        double sum = purchases[i].quantity * purchases[i].price; //Стоимость позиции
        //        Console.WriteLine($"{i + 1}. {purchases[i].title,-43}{purchases[i].price,10:f2}{purchases[i].quantity,16:f3}{sum,18:f2}");
        //        Console.WriteLine($"{"",-5}Товар");
        //        Console.WriteLine($"{"",-5}Полный расчет");
        //        Console.WriteLine($"{"",-5}НДС {purchases[i].vat:p0}{purchases[i].vat * sum,78:f2}");
        //        result += sum;
        //    }

        //    Console.WriteLine(("").PadRight(90, '-'));
        //    Console.WriteLine($"Итого{result,85:f2}");
        //    Console.WriteLine(("").PadRight(90, '-'));

        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    Console.Write("Введите порядковый номер текущего месяца: ");
        //    string inputMonth = Console.ReadLine();
        //    Console.Write("Введите среднюю температуру: ");
        //    string inputTemp = Console.ReadLine().Replace('.', ',');

        //    bool isValidMonth = int.TryParse(inputMonth, out int monthNumber);
        //    isValidMonth = isValidMonth || (monthNumber < 1 || monthNumber > 12);
        //    bool isValidTemp = float.TryParse(inputTemp, out float averageTemp);

        //    if (!isValidMonth || !isValidTemp)
        //    {
        //        Console.WriteLine("Введены некорректные данные.");
        //        Console.ReadKey();
        //        return;
        //    }

        //    bool isWinterMonth = (monthNumber == 12) || (monthNumber == 1) || (monthNumber == 2);
        //    if (isWinterMonth && averageTemp > 0)
        //    {
        //        Console.WriteLine("Дождливая зима.");
        //    }
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    Console.Write("Введите целое число: ");
        //    string inputValue = Console.ReadLine();
        //    bool isValid = int.TryParse(inputValue, out int number);

        //    if (!isValid)
        //    {
        //        Console.WriteLine("Введено некорректное число.");
        //        Console.ReadKey();
        //        return;
        //    }

        //    if ((number % 2) == 0)
        //    {
        //        Console.WriteLine($"{number} - чётное число.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} не является чётным числом.");
        //    }

        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    int year = Convert.ToInt32(Console.ReadLine());
        //    bool res = (year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0);
        //}
    }
}

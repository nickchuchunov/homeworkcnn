using System;

namespace IntroductionClevel2Chuchunov
{
    class Program
    {
        static void Main(string[] args)
        { /* 1. запросить у пользователя минимальную и максимальную температуру 
           * за сутки и вывести среднесуточную температуру.*/

            Console.WriteLine("сообщите минемальную температуру прошедшего дня:");
            double mintemdey = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сообщите максимальную температуру прошедшего дня:");
            double maxtemdey = Convert.ToDouble(Console.ReadLine());
            double avertempdey = (mintemdey + maxtemdey) / 2;
            Console.WriteLine("средняя температура: " + avertempdey);

            /*2. запросить у пользователя порядковый 
             * номер текущего месяца и вывести его название */

            Console.WriteLine("сообщите номер текущего месяца");
            int numbermonth = Convert.ToInt32(Console.ReadLine());
            string month = "название месяца";
            switch (numbermonth)
            {
                case 1: month = "январь"; break;
                case 2: month = "февраль"; break;
                case 3: month = "март"; break;
                case 4: month = "апрель"; break;
                case 5: month = "май"; break;
                case 6: month = "июнь"; break;
                case 7: month = "июль"; break;
                case 8: month = "август"; break;
                case 9: month = "сентябрь"; break;
                case 10: month = "октябрь"; break;
                case 11: month = "ноябрь"; break;
                case 12: month = "декабрь"; break;
            };
            Console.WriteLine("месяц под номером" + numbermonth + " - " + month);

            /*3. определить, является ли введённое пользователем число чётным.*/
            Console.WriteLine("сообщите любое целочисленное значение");

            int parity = Convert.ToInt32(Console.ReadLine());
            if (parity % 2 != 0) { Console.WriteLine(parity + " - нечетное число"); }
            else { Console.WriteLine(parity + " - четное число"); };

            /*для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека 
             * в интернете и схематично нарисуйте его в консоли,
             * только за место динамических, по вашему мнению, данных
             * (это может быть дата, название магазина, сумма покупок) подставляйте переменные,
             * которые были заранее заготовлены до вывода на консоль. */

            DateTime datechec = DateTime.Now;
            string product = "мыло nature жид 500 г.";
            string article = " 3947152m"; // артикул
            double price = 119.99; // цена
            double discount = 0.9; // скидка
            float quantity = 1; // количесвто
            double cost = price * discount * quantity; // стоимость
            Console.WriteLine("пятёрочка  \n кассовый чек {0} \n {1} \n артикул {2} \n цена {3} \n скидка {4} \n  кол-во {5}\n итого {6} \n", datechec, product, article, price, discount, quantity, cost);
        }
    }
}

using System;

namespace IntroductionClevel_1Chuchunov
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Николай";
            DateTime timecnn = new DateTime(2021, 2, 11);
            Console.WriteLine("введите ваше имя");

            string name2 = Console.ReadLine();
            if (name2.Length != 0) { Console.WriteLine("Привет: " + name2 + " сегодня " + timecnn); }
            else { Console.WriteLine("Привет: " + name1 + " сегодня " + timecnn); }
        }
    }
}

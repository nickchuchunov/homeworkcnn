using System;

namespace IntroductionClevel4._1Chuchunov
{
    class Program
    {

        enum seasonyear1 : int { Winter = 1, Spring = 2, Summer = 3, Autumn = 4 };

        static void Main(string[] args)
        {

            /*1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и 
    * возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО. */




           static string GetFullName (string lastName, string firstName,  string patronymic) {  string LFP = lastName + " " + firstName + " " + patronymic; return LFP;  };

             string firstNam1 = "Николай";
             string lastName1 = "Чучунов";
             string patronymic1 = "Николаевич";

             string a = GetFullName(lastName1, firstNam1, patronymic1);
             Console.WriteLine(a); 




            /*2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую 
             * число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран. */

             Console.WriteLine("введите числа разделенные пробелом");
              string b = Console.ReadLine();
              char[] b1 = b.ToCharArray();
              char ds = Convert.ToChar(" ");
              double[] gr1 = new double[b1.Length];
              int j = 0;
              for (int i = 0; i < b1.Length; i++) { if (b1[i] != ds) { j++; gr1[j] = Char.GetNumericValue(b1[i]); }; };
              double gr3 = 0; 


              foreach (double gr2 in gr1) { gr3 += gr2; };
              Console.WriteLine(gr3); 


            /*3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
              * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12». */


            
            static int SeasonYear(int month, out int seasonyear)
            {
                seasonyear=0;
                switch (month)
                {
                    case 1: seasonyear = (int)seasonyear1.Winter; break;
                    case 2: seasonyear = (int)seasonyear1.Winter; break;
                    case 3: seasonyear = (int)seasonyear1.Spring; break;
                    case 4: seasonyear = (int)seasonyear1.Spring; break;
                    case 5: seasonyear = (int)seasonyear1.Spring; break;
                    case 6: seasonyear = (int)seasonyear1.Summer; break;
                    case 7: seasonyear = (int)seasonyear1.Summer; break;
                    case 8: seasonyear = (int)seasonyear1.Summer; break;
                    case 9: seasonyear = (int)seasonyear1.Autumn; break;
                    case 10: seasonyear = (int)seasonyear1.Autumn; break;
                    case 11: seasonyear = (int)seasonyear1.Autumn; break;
                    case 12: seasonyear = (int)seasonyear1.Winter; break;
                        
                };
                return seasonyear;
            }

            Console.WriteLine("Укажите номер месяца");
            int moth1 = Convert.ToInt16(Console.ReadLine());

            SeasonYear( moth1, out int seasonyear5);
            Console.WriteLine("месяц с номером {0} пренадлежит декаде {1}", moth1, seasonyear5);

























































































        }

    }
    }



































    
    
    
    
    

   






















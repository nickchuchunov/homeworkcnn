using System;

namespace Level_1.Lesson_1
{
    class MainClass
    {

        Season TWO_SE = Season.Spring;
        //static void Main(string[] args)
        //{
            //  Console.WriteLine("Hello world!");

            //byte b1 = 1; // -128 127 8
            //short s1 = 20000; // -32k 32k  16
            //int i = 3000; // -2,2 2,2 32
            //long l1 = 500L;  // 64

            //float f1 = 12.2f;
            //double d1 = 45.6;

            //bool flag = true;
            //char c1 = 'y';

            //string str1 = "Hello world";

            //Console.WriteLine($"{b1} {s1} {str1} {c1}");



            //int varall = 3000;
            //{
            //    int scope = 5;
            //    console.writeline($"{scope} {varall}");
            //}

            //{
            //    int scope = 15;
            //    console.writeline($"{scope} {varall}");
            //}

            //int dec = 42;
            //int hex = 0x2a;
            //int bin = 0b00001;

            //  DateTime date = new DateTime(2015, 8, 4, 16, 23, 42);
            //date.AddDays(15);
            //Console.WriteLine(date);

            //dec += 50;

            //    int dec = 42;

            // dec++;
            //    Console.WriteLine(dec++);

            //bool res = true || false;

            //Console.WriteLine(res);

            //int know = 0b011111;

            //int back = 0b010000;
            //int front = 0b011010;
            //int des = 0b0100000;

            //int backProf = know & back;

            //Console.WriteLine(backProf == back);

            //string str = "human";
            //int age = 30;

            //if (str == "human" && age >= 60)
            //{
            //    Console.WriteLine("old human");
            //} 
            //else if (str == "human" && age <= 18)
            //{
            //    Console.WriteLine("young human");
            //}
            //else
            //{
            //    Console.WriteLine("mid human");
            //}

            //int a = 20;
            //string b = "mynumber = ";
            //a *= a;
            //Console.WriteLine(b + a);

            //Console.WriteLine("Hello");

            //int dayOfWeek = 200;

            //if (dayOfWeek == 100)
            //{
            //    return;
            //}


            //Console.WriteLine("WORLD!");

            //string title = "";

            //switch (dayOfWeek)
            //{
            //    case 0:
            //    case 1:
            //        title = "Вторник";
            //        break;
            //    case 2:
            //        title = "Среда";
            //        break;
            //    default :
            //        title = "Неизвестно!";
            //        break;
            //}

            //Console.WriteLine(title);


            //Season twoSeason = Season.Spring;
            //Console.WriteLine(twoSeason);
            //  Season two_season = Season.Spring;



            //int a = 10;

            //a++;

            //int b = 10 + 7;


            //string str = Console.ReadLine();

            //Console.WriteLine(str == "Hello" ? "Yes" : "No");


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            //for (int i = 0, j = 5; i < j ; i++, j--)
            //{
            //    Console.WriteLine("i: " + i + " j: " + j);
            //}


        //    for (char i = 'A'; i <= 'z'; i++)
        //    {
        //        Console.WriteLine(Convert.ToInt32(i));
        //    }



        //}





            [Flags]
        enum Season
        {
            Spring = 0,
            Summer = 1,
            Autumn = 2,
            Winter = 3
        }


        enum Status
        {
            New = 0,
            Succes = 1,
            Error = 2
        }
    }
}

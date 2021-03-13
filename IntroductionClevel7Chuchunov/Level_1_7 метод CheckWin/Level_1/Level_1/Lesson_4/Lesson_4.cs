using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_4
{
    class Lesson_4
    {
        //static void Main(string[] args)
        //{
            // info("hello");
            // calc(1, 2, 5);
            // (string user, int res) = calcNumbers("user1", 1, 2);
            // Console.WriteLine($"{res}{user}");

            //calc(10, 5);

            //int res1 = res + 10;


            //checkName("Admin", 10);
            //checkName("user2", 20);

            // int a = 10 > 0 ? 1 : 0;

            // Console.WriteLine(a);

            //int a = 10;
            //testInt(a);
            //Console.WriteLine(a);

            //int[] a = { 1, 2, 3 };
            //testArray(a);

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}    

            //string s = "hello";
            //testString(s);
            //Console.WriteLine(s);
            //int a = 10;
            //testInt(ref a);
            //Console.WriteLine(a);

            //int[] a = { 1, 2, 3 };
            //int[] b = { 1, 2, 3 };

            //int[] linkTo = a;

            //Console.WriteLine(a.Equals(linkTo));
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(b.Equals(linkTo));

            //string f = "123";
            //string s = "123";
            //string t = "12";
            //t += "3";

            //Console.WriteLine(f == s);
            //Console.WriteLine(f == t);
            //Console.WriteLine(s == t);

            //int a = 10;
            //testInt(out a);
            //string test;

            //testMsg1(out test);

            //calc("msg", 1, 2, 3, 4, 5);
            //calc("msg", 1, 2, 3, 4, 5, 10, 11, 12, 13, 15);

        //    Console.WriteLine(GetFactorial(15));
        //}

        static int GetFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            return number * GetFactorial(number - 1);
        }


        static void testMsg1(out string s)
        {

            s = "Hello";
            Console.WriteLine($"{s}");
        }

        static void testInt(out int a)
        {
            a = 10;
            a++;
        }

        static void testString(string s)
        {
            s += "1";
        }

        static void testArray(int[] a)
        {
            a[1] = 600;
        }

        static (string user, int res) calcNumbers(string user, int a, int b)
        {
            int res = a + b;
            return (user, res);
        }

        static void info(string msg)
        {
            if (msg == "user")
            {
                return;
            }
            Console.WriteLine($"msg: {msg}");
        }

        static void calc(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"res: {res}");
        }

        static void calc(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine($"res: {res}");
        }

        static void calc(string str, params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length;  i++)
            {
                sum += values[i];
            }
            Console.WriteLine(sum);
        }

        static void checkName(string user, int age)
        {
            if (user == "user1" && age > 10)
            {
                Console.WriteLine("сигареты покупать рано");
            }
            else if (user == "user2" && age > 20)
            {
                Console.WriteLine("сигареты покупать можно");
            }
        }

    }
}

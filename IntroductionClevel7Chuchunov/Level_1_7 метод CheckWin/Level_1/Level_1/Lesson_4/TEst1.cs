using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_4
{
    class TEst1
    {
        //static void Main(string[] args)
        //{
        //new A();

        //    Console.WriteLine(GetFac(5));
        //}


        //static int GetFac(int num)
        //{
        //    if (num == 1)
        //    {
        //        return num;
        //    }
        //    return num * GetFac(num - 1);
        //}
    }













/// <summary>
/// 1
/// </summary>
    class Test2
    {
        public static void changeNum(int a)
        {
            a = 3;
        }

        //static void Main(String[] args)
        //{
        //    Aa a = new Aa();
        //    int i = 7;
        //    changeNum(i);
        //    Console.WriteLine(i);
        //    Console.WriteLine(a.i);
        //}

        class Aa
        {
           public int i = 5;

            public Aa()
            {
                ++i;
            }
        }
    }





    /// <summary>
    /// 2
    /// </summary>
    class Pr1
    {
        static bool SomeMethod()
        {
            Console.WriteLine("SomeMethod start");
            return true;
        }

        //static void Main(string[] args)
        //{
        //    if (true & false & SomeMethod())
        //    {
        //        Console.WriteLine("Main start");
        //    }
        //}
    }




    /// <summary>
    /// 3
    /// </summary>
    class Pr2
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Test.Foo(1) + Test.Foo(2) * Test.Foo(3));
        //}
    }

    class Test
    {
        public static int Foo(int o)
        {
            Console.WriteLine(o);
            return o;
        }
    }



    /// <summary>
    /// 3 чем отличаются
    /// </summary>
    /// double[,] array
    /// double[][] array

}

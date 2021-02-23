using System;

namespace IntroductionClevel3Chuchunov
{
    class Program
    {
        static void Main(string[] args)


        {
            /* 1.Написать программу, выводящую элементы двумерного массива по диагонали.*/
             int[][] Diagonal = new int[3][];
             Diagonal[0] = new int[] {1, 2, 3 };
             Diagonal[1] = new int[] { 4, 5, 6 };
             Diagonal[2] = new int[] { 7, 8, 9 };
             for (int i = 0; i < Diagonal.GetLength(0); i++) { for (int j = 0; j < Diagonal.GetLength(0); j++) { if (i == j) { Console.WriteLine(Diagonal[i][j]); } } }; 




            /*2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий 
             * список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email. */
             object[][] PhoneDirectory = new object[5][];
            PhoneDirectory[0] = new object[] {"Андрей", 89994706357};
            PhoneDirectory[1] = new object[] { "Валентин", 89994706356 };
            PhoneDirectory[2] = new object[] { "Елена", 89994706355 };
            PhoneDirectory[3] = new object[] { "Станислав", 89994706354 };
            PhoneDirectory[4] = new object[] { "Юрий", 89994706353 }; 

            for (int i = 0; i < PhoneDirectory.GetLength(0); i++)
            { for (int j = 0; j <= 1; j++) { Console.WriteLine("имя {0} Номер телефона {1}", PhoneDirectory[i][0], PhoneDirectory[i][1]); } } 



            /* 3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello). */

            Console.WriteLine("введите текст для преобразования в обратный порядок");

            string s = Console.ReadLine();
             byte[] s2 = System.Text.Encoding.Default.GetBytes(s);
             Array.Reverse(s2);
            string s3 = System.Text.Encoding.Default.GetString(s2);
            Console.WriteLine(s3);




            /*Задание Номер 3 . 2-й способ вывода строки в обраьном порядке */
            Console.WriteLine("Вывод текста в обратном порядке способ №2");
            Console.WriteLine("введите текст для преобразования в обратный порядок");

            string m = Console.ReadLine();
            byte[] m2 = System.Text.Encoding.Default.GetBytes(m);




            byte[] m4 = new Byte[m2.Length];

            int q = 0;
            for (int i = m2.Length - 1; i >= 0; i--)
            { q = q + 1; m4[q - 1] = m2[i]; };
            string m3 = System.Text.Encoding.Default.GetString(m4);
            Console.WriteLine(m3);



        }
    }
}

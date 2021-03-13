using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level_1.Lesson_3
{
    class DZ
    {
        //static void Main(string[] args)
        //{
            //1 выриант 1
            //Написать программу, выводящую элементы двумерного массива по диагонали.
            //int[,] array_1 = { { 2, 6, 9 }, { 12, 1, 4 }, { 3, 5, 8 } };
            //Console.Write("Элементы массива по диагонали:");
            //for (int i = 0; i < array_1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array_1.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            Console.Write($" {array_1[i, j]}");
            //    }
            //}
            //Console.WriteLine();

            //2
            //Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: 
            //первый элемент хранит имя контакта, второй — номер телефона/email.
            //string[,] array_2 = {
            //    { "Алексей", "+79004002211"},
            //    { "Татьяна", "+74956677888"},
            //    { "Владимир", "vladimir@gmail.com"},
            //    { "Анастасия", "anastasiya@mail.com"},
            //    { "Георгий", "+79990055533"}};
            //Console.WriteLine("Телефонный справочник:");
            //for (int i = 0; i < array_2.GetLength(0); i++)
            //{
            //    Console.WriteLine($"{array_2[i, 0]}, {array_2[i, 1]}");
            //}

            //3
            //Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
            //Console.WriteLine("Введите строку:");
            //string str_3 = Console.ReadLine();
            //Console.WriteLine("Обратный порядок:");
            //for (int i = str_3.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str_3[i]);
            //}
            //Console.WriteLine();

            //4
            //«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            //char[,] array_4 = {
            //    { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O'},
            //    { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            //    { 'O', 'X', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O'},
            //    { 'O', 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O'},
            //    { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            //    { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X'},
            //    { 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X'},
            //    { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            //    { 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            //    { 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'X', 'O', 'O'}};
            //Console.WriteLine("«Морской бой»:");

            //for (int i = 0; i < array_4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array_4.GetLength(1); j++)
            //    {
            //        Console.Write($"{array_4[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //5 вариант 1
            //Написать программу, которой на вход подается одномерный массив и число n (может быть положительным, или отрицательным), 
            //при этом программа должена сместить все элементы массива на n позиций.
            //Для усложнения задачи нельзя пользоваться вспомогательными массивами.
            //var int_5 = 12;
            //char[] array_5 = { '5', '8', 'A', '9', 'v', '3', '1', 'z', 'S' };

            //Console.WriteLine($"Массив:{new string(array_5)}, сдвиг:{int_5}");

            //var cycle_true_num = Math.Abs(int_5) % array_5.Length;
            //var isnegative = Math.Sign(int_5) < 0;
            //for (int i = 0; i < cycle_true_num; i++)
            //{
            //    var temp_element = isnegative ? array_5[array_5.Length - 1] : array_5[0];
            //    if (isnegative)
            //    {
            //        for (int j = array_5.Length - 1; j > 0; j--)
            //        {
            //            var temp = array_5[j - 1];
            //            array_5[j - 1] = temp_element;
            //            temp_element = temp;
            //        }
            //        array_5[array_5.Length - 1] = temp_element;
            //    }
            //    else
            //    {
            //        for (int j = 0; j < array_5.Length - 1; j++)
            //        {
            //            var temp = array_5[j + 1];
            //            array_5[j + 1] = temp_element;
            //            temp_element = temp;
            //        }
            //        array_5[0] = temp_element;
            //    }
            //}

            //Console.WriteLine($"Новый массив:{new string(array_5)}");

            //Console.ReadLine();


            //5 вариант 2
            //int[] array = { 1, 2, 3, 4, 5 };

            //int value = 7;

            //bool flag;
            //if (value < 0)
            //{
            //    flag = true;
            //    value = -value;
            //}
            //else
            //{
            //    flag = false;
            //}

            //int lastIndex = array.Length - 1;
            //for (int i = 0; i < value; i++)
            //{
            //    int temp;
            //    if (flag)
            //    {
            //        temp = array[0];
            //    }
            //    else
            //    {
            //        temp = array[lastIndex];
            //    }

            //    for (int j = 0; j < lastIndex; j++)
            //    {
            //        if (flag)
            //        {
            //            array[j] = array[j + 1];
            //        }
            //        else
            //        {
            //            array[lastIndex - j] = array[lastIndex - j - 1];
            //        }
            //    }
            //    if (flag)
            //    {
            //        array[lastIndex] = temp;
            //    }
            //    else
            //    {
            //        array[0] = temp;
            //    }
            //}

            //array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
       // }
        }
}

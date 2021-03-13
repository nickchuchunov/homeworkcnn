using Level_1.Lesson_5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Level_1.Lesson_6
{
    class Lesson_6
    {
        //static void Main(string[] args)
        //{

            //    int x = 10;
            //    int y = x / 0;

            //Console.WriteLine("END!");

            //try
            //{
            //    int x = 10;
            //    int y = x / 0;
            //}
            //catch
            //{
            //    Console.WriteLine("Во время выполнения деления произошла ошибка");
            //}
            //Console.WriteLine("Продолжение выполнения программы");





            //string log = string.Empty; // пустая строка - ""
            //log += $"Начало работы приложения";
            //try
            //{
            //    int x = 10;
            //    int y = x / 1;
            //    log += $"{Environment.NewLine}Результат деления: {y}";
            //}
            //catch
            //{
            //    log += $"{Environment.NewLine}Во время выполнения деления произошла ошибка";
            //}
            //finally
            //{
            //    File.WriteAllText("log.txt", log);
            //}






            //try
            //{
            //    object x = null;
            //    int y = (int)x / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Деление на ноль");
            //}






            //try
            //{
            //    //int[] array = new int[5];
            //    //array[50] = 100;
            //    object x = null;
            //    int y = (int)x / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Деление на ноль");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Обращение к null");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("выход за пределы массива");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Что-то еще пошло не так");
            //}


            //try
            //{
            //    //int[] array = new int[5];
            //    //array[50] = 100;
            //    object x = null;
            //    int y = (int)x / 0;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}


            //Console.WriteLine("end");












            //try
            //{
            //    object x = 10;
            //    int y = (int)x / 0;
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine($"Произошла ошибка: {ex.Message}");
            //    Console.WriteLine(ex.StackTrace);
            //}




            // DivideByZeroException - исключение, деление на 0
            // ArgumentException — исключение, которое возникает, когда среди передаваемых методу аргументов есть недопустимые.
            // ArithmeticException — исключение, которое возникает при ошибках операций арифметического приведения или преобразования.
            // AccessViolationException — исключение, которое возникает при попытке чтения или записи в защищённую область памяти.
            // UnauthorizedAccessException — исключение, которое возникает в случае запрета доступа операционной системой из - за ошибки ввода-вывода или особого типа ошибки безопасности.
            // IndexOutOfRangeException — исключение, возникающее при попытке обращения к элементу массива с индексом, который находится за пределами массива.
            // InvalidCastException — исключение, которое возникает в случае недопустимого приведения или явного преобразования.
            // NullReferenceException — исключение, которое возникает при операциях с объектом, равным null, например при попытке получить доступ к его свойствам.
            // OutOfMemoryException — исключение, которое возникает при недостаточном объёме памяти для продолжения выполнения программы.
            // StackOverflowException — исключение, которое возникает при переполнении стека выполнения из - за чрезмерного количества вложенных вызовов методов.








            //try
            //{
            //    Building building = new Building(3, 1);
            //    string address = GetAddress(building);
            //}
            //catch (AddressException)
            //{
            //    Console.WriteLine("Здание не содержит адреса");
            //}










            //try
            //{
            //    Building building = new Building(3, 1);
            //    building.Address = "ул. Победы";
            //    // Для задания корректного адреса раскомментируйте следующую строку:
            // //    building.Address = "ул. Победы, 23";
            //    string address = GetAddress(building);
            //    Console.WriteLine($"Адрес здания: {address}");
            //}
            //catch (AddressException ex) when (ex.Code == ErrorCodes.NoAddress)
            //{

            //    Console.WriteLine("Здание не содержит адреса");
            //}
            //catch (AddressException ex) when (ex.Code == ErrorCodes.NoBuilding)
            //{

            //    Console.WriteLine("Адрес не содержит номер дома");
            //}














            //  Console.WriteLine(args[0]);











            //Process notepad = Process.Start("notepad.exe");
            //Console.WriteLine("Нажмите любую клавишу для завершения процесса...");
            //Console.ReadKey();
            //notepad.Kill();
            //Console.WriteLine(notepad.ExitCode); // -1









            //Process notepad = Process.Start("notepad.exe");
            //Console.WriteLine("Для продолжения, закройте окно Блокнота...");
            //notepad.WaitForExit();
            //Console.WriteLine(notepad.ExitCode); // 0








            //Process notepad = Process.Start("notepad.exe", @"D:\some file.txt");
            //notepad.WaitForExit();
            //Console.WriteLine(notepad.ExitCode);






            //int sum = 0;
            //for (int i = 0; i < args.Length; i++)
            //{
            //    sum += Convert.ToInt32(args[i]);
            //}
            //Console.Write(sum);










            //Process process = new Process();
            //process.StartInfo.FileName = @"C:\Users\Artem_new\source\repos\Calculator\Calculator\bin\Debug\netcoreapp3.1\Calculator.exe";
            //process.StartInfo.Arguments = "1 2 3 4 5 6 7";
            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.Start();
            //string output = process.StandardOutput.ReadToEnd();

            //Console.WriteLine(output);
            //process.WaitForExit();
            //Console.WriteLine(process.ExitCode);

            //sqrt(-10);
            // b();
            //}

            //static string GetAddress(Building building)
            //{
            //    if (string.IsNullOrEmpty(building.Address))
            //    {
            //        throw new AddressException();
            //    }

            //    return building.Address;
            //}

            //try
            //{
            //    sqrt(-10);
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}

            //Console.WriteLine("END!");
        //}

        static int sqrt(int n)
        {
            if (n > 0)
            {
                return n / 2;
            }
            throw new DivideByZeroException("нельзя отрицательное!");
        }


        //static string GetAddress(Building building)
        //{
        //    if (string.IsNullOrEmpty(building.Address))
        //    {
        //        throw new AddressException();
        //    }

        //    return building.Address;
        //}




        static string GetAddress(Building building)
        {
            if (string.IsNullOrEmpty(building.Address))
            {
                throw new AddressException(ErrorCodes.NoAddress);
            }

            if (building.Address.Split(' ').Length < 3)
            {
                throw new AddressException(ErrorCodes.NoBuilding);
            }

            return building.Address;
        }


    }
}

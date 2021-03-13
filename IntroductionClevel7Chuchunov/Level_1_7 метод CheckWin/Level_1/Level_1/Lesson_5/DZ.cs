using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Level_1.Lesson_5
{
    class DZ
    {
        //static void Main(string[] args)
        //{
        //    // ReadDataAndSaveFile();
        //    // AppendTime();
        //    BinFile();
        //}

        static void ReadDataAndSaveFile()
        {
            Console.WriteLine("Input file path to save data");

            var path = Console.ReadLine();
            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Incorrect Path");
                return;
            }

            if (!path.EndsWith(".txt")) path += ".txt";
            using var fs = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
            using var sw = new StreamWriter(fs);


            Console.WriteLine("Input data to save in text file, press Esc to stop");
            sw.AutoFlush = true;
            while (true)
            {
                var inputKey = Console.ReadKey();

                if (inputKey.Key == ConsoleKey.Escape)
                    break;
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    sw.Write("\n");
                    Console.WriteLine();
                }
                else sw.Write(inputKey.KeyChar);
            }


            // Program Stop
            Console.WriteLine("\nWork Done, cya");
        }


        static void AppendTime() {
            using var sw = File.AppendText("startup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss tt");
            sw.WriteLine(time);
            Console.WriteLine($"I add to startup.txt new time, it's {time}, go check");
        }

        static void BinFile()
        {
            const string file = "test.bin";

            Console.WriteLine("Input a case of number's in range [0..255] separating with whitespace");
            var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (input is null)
            {
                Console.WriteLine("incorrect input");
                return;
            }

            var array = new byte[input.Length];
            for (var i = 0; i < array.Length; i++)
            {
                if (!byte.TryParse(input[i], out var number))
                {
                    Console.WriteLine($"Incorrect number {input[i]}");
                    return;
                }

                array[i] = number;
            }

            using (var bw = new BinaryWriter(File.OpenWrite(file)))
            {
                bw.Write(array);
                bw.Flush();
            }

            Console.WriteLine("see what now in file {file}");

            Console.WriteLine("i read it for you");
            byte[] newData;
            using (var br = new BinaryReader(File.OpenRead(file)))
            {
                newData = br.ReadBytes(array.Length);
            }

            for (var i = 0; i < newData.Length; i++)
            {
                Console.Write(newData[i] + " ");
            }
        }
    }
}

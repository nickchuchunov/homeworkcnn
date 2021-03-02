using System;
using System.Text.Json;
using System.IO;
using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters.Binary;

namespace IntroductionClevel5Chuchunov
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.*/


            Console.WriteLine("введите текст");
            string file1 = Console.ReadLine();
            BuildingHom house = new BuildingHom(file1);
            house.Floors = file1;
            string json1 = JsonSerializer.Serialize(house);
            File.WriteAllText("house1.txt", json1); 


            /* 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».*/

            DateTime PresentTime = DateTime.Now;
            string time4 = Convert.ToString(PresentTime);
            PresentTime  time1 = new PresentTime(time4);
            time1.Time2 = time4;
            string json2 = JsonSerializer.Serialize(time1);
            string[] asdf = new string[1];
             asdf[0] = json2; 

     

            File.AppendAllLines("time.txt", asdf); 






            /*3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.*/
            Console.WriteLine("Введите числа от 0 до 255");
            string FileNumbers = Console.ReadLine();
            BuildingHom HouseNumbers = new BuildingHom(FileNumbers);
            HouseNumbers.Floors = FileNumbers;
            byte[] json11 = JsonSerializer.SerializeToUtf8Bytes(HouseNumbers);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("housemumbers.bin", FileMode.OpenOrCreate), json11);








        }

       

        public class BuildingHom {
            public string Floors { get; set; }
           
            public BuildingHom(String floors) { Floors = floors; } }


        public class PresentTime {
           public string Time2 { get; set; }
            public PresentTime(string time2) { Time2 = time2; }

        }
        
    }
}

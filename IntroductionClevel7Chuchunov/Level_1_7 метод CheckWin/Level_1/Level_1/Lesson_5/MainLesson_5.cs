using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Level_1.Lesson_5
{
    class MainLesson_5
    {
        //static void Main(string[] args)
        //{

            //Cat cat3 = new Cat();

            //Cat cat1 = new Cat(15, "cat1");
            //Cat cat2 = new Cat(20, "cat2");

            //cat1.Age = -50;


            //cat1.info();
            //cat2.info();



            //Building house = new Building(9, 3);
            //house.Address = "ул. Ленина, 12";
            //house.OpenDoor(1);
            //house.IsHeatable = true;

            //string filename = "text.txt";
            //File.WriteAllText(filename, "str1"); // записываем в файл строку

            //File.AppendAllText(filename, Environment.NewLine); // вставляем перенос строки

            //File.AppendAllText(filename, "str10\n");
            //File.AppendAllText(filename, "str11\n");

            //File.AppendAllLines(filename, new[] { "str2", "str3" }); // добавляем еще две строки

            //string fileText = File.ReadAllText(filename);

            //Console.WriteLine(fileText);

            //string[] fileLines = File.ReadAllLines(filename);

            //Console.WriteLine(fileLines[1]); // str2

            //byte[] array = { 1, 2, 3, 5, 7, 9, 11 };
            //File.WriteAllBytes("bytes.bin", array);
            //byte[] fromFile = File.ReadAllBytes("bytes.bin");

            //foreach (var item in fromFile)
            //{
            //    Console.WriteLine(item);
            //}

            //Building house = new Building(12, 4);
            //house.Address = "ул. Мира, 24";
            //house.IsHeatable = true;

            //string json = JsonSerializer.Serialize(house);
            //Console.WriteLine(json);
            //File.WriteAllText("house1.json", json);


            //string json = File.ReadAllText("house.json");
            //Console.WriteLine(json);
            //Building house = JsonSerializer.Deserialize<Building>(json);
            //Console.WriteLine();

            //Building house = new Building(12, 4);
            //house.Address = "ул. Мира, 24";
            //house.IsHeatable = true;

            //StringWriter stringWriter = new StringWriter();
            //XmlSerializer serializer = new XmlSerializer(typeof(Building));
            //serializer.Serialize(stringWriter, house);
            //string xml = stringWriter.ToString();
            //File.WriteAllText("house.xml", xml);

            //string xmlText = File.ReadAllText("house.xml");
            //StringReader stringReader = new StringReader(xmlText);
            //XmlSerializer serializer = new XmlSerializer(typeof(Building));
            //Building house = (Building)serializer.Deserialize(stringReader);
            //Console.WriteLine(house.Address); // ул. Мира, 24
            //Console.WriteLine(house.Floors); // 12
            //Console.WriteLine(house.Entrances); // 4

            //Building house = new Building(5, 2);
            //house.Address = "ул. Победы, 14";
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(new FileStream("house.bin", FileMode.OpenOrCreate), house);


            //BinaryFormatter formatter = new BinaryFormatter();
            //Building building = (Building)formatter.Deserialize(new FileStream("house.bin", FileMode.Open));
            //Console.WriteLine(building.Address); // ул. Победы, 14



            // null операторы
            //Building house = new Building(5, 2);
            //house.Address = "Горького, 34";
            //Console.WriteLine(house.Address.Split(' ')[1]); // 34








            //Building house = new Building(5, 2);
            //Console.WriteLine(house.Address.Split(' ')[1]);

            //Building house = new Building(5, 2);
            //if (house.Address != null)
            //{
            //    Console.WriteLine(house.Address.Split(' ')[1]);
            //}

            // PrintHouseNumber(null);


            //Building house = new Building();
            //Console.WriteLine(house.Address ?? "Нет адреса"); // Нет адреса
            //house.Address = "Тургенева, 18";
            //Console.WriteLine(house.Address ?? "Нет адреса"); // Тургенева, 18





            //string workDir = @"E:\ExampleDir";

            //Console.WriteLine(Directory.Exists(workDir)); // Проверяет, существует ли заданная директория

            //string notesDir = Path.Combine(workDir, "Notes"); // "D:\ExampleDir\Notes"

            //Directory.CreateDirectory(notesDir); // Создаем вложенную директорию

            //string noteText = "Этот файл создан автоматически";

            //string notePath = Path.Combine(notesDir, "Note 1.txt"); // "D:\ExampleDir\Notes\Note 1.txt"

            //File.WriteAllText(notePath, noteText);

            //string copyOfNotePath = Path.Combine(workDir, "Copy of Note 1.txt"); // "D:\ExampleDir\Copy of Note 1.txt"
            //File.Copy(notePath, copyOfNotePath); // Копируем созданную заметку в "D:\ExampleDir\Copy of Note 1.txt"

            //Console.WriteLine(File.Exists(copyOfNotePath)); // Проверяет, существует ли заданный файл

            //File.Move(copyOfNotePath, Path.Combine(notesDir, "Note 2.txt")); // Перемещаем заметку в "D:\ExampleDir\Notes\Note 2.txt"



            // Создаем директорию "D:\ExampleDir\Documents" и перемещаем в нее директорию Notes
            //Directory.CreateDirectory(Path.Combine(workDir, "Documents"));
            //Directory.Move(notesDir, Path.Combine(workDir, "Documents", "Notes"));


            //// File.Delete(Path.Combine(workDir, "Note 2.txt"));

            // // Перечень всех файлов и папок, вложенных в workDir
            // string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            //for (int i = 0; i < entries.Length; i++)
            //{
            //    Console.WriteLine(entries[i]);
            //}

            // ZipFile.CreateFromDirectory(@"E:\ExampleDir", @"E:\result.zip");

            //ZipFile.ExtractToDirectory(@"E:\result.zip", @"E:\Example\Dir");

            //MainLesson_5 lesson5 = new MainLesson_5();
            //lesson5.test();

            //test();
       // }

        void test()
        {
            Console.WriteLine("HEllo!");
        }

        static void PrintHouseNumber(Building house)
        {
            Console.WriteLine(house?.Address?.Split(' ')[1]);
        }

        //static void PrintHouseNumber(Building house)
        //{
        //    if (house == null)
        //    {
        //        return;
        //    }
        //    if (house.Address == null)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(house.Address.Split(' ')[1]);
        //}
    }
}

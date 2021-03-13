using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Level_1.Lesson_6.DZ
{
    class MainDZ
    {
        //static void Main(string[] args)
        //{
            //Console.WriteLine("Введите путь к каталогу, чтобы отобразить его дерево: ");
            //string folderPath = Console.ReadLine();
            //Console.WriteLine("Введите название файла для сохранения дерева каталогов: ");
            //MyDirectory dir = new MyDirectory(folderPath, Console.ReadLine());
            //dir.GetDirsRecurs();
            //dir.Show();










            //string format = (args.Length > 0) ? args[0] : "json";
            //string fileName = $"todo.{format}";

            //List<ToDo> todoList = ReadFile(format, fileName);
            //ShowList(todoList);

            //while (true)
            //{
            //    Console.Write($"'i' - редактировать задачу\n" +
            //                   "'n' - добавить новую задачу\n" +
            //                   "'q' - выход: ");
            //    string choise = Console.ReadLine();
            //    Console.WriteLine();
            //    switch (choise)
            //    {
            //        case "i":
            //        case "ш":
            //            Edit(ref todoList);
            //            break;
            //        case "n":
            //        case "т":
            //            Add(ref todoList);
            //            break;
            //        case "q":
            //        case "й":
            //            Save(format, fileName, todoList);
            //            return;
            //        default:
            //            Console.WriteLine("Ошибка.");
            //            break;
            //    }
            //    ShowList(todoList);
            //}












            //int sum = 0;
            //Random random = new Random();
            //string[,] sArray = new string[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sArray[i, j] = random.Next(1, 50).ToString();
            //    }
            //}

            //// sArray[2, 3] = "sdf";

            //try
            //{
            //    sum = sumArray(sArray);
            //}
            //catch (MyArraySizeExeption e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}
            //catch (MyArrayDataException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}
            //Console.WriteLine(sum);









            // 1.	Создать класс "Сотрудник" с полями: ФИО, должность, телефон,
            // зарплата, возраст;
            //Employee e = new Employee("Rahid", "Semov",
            //        "Petrovich", "8(495)000-11-22", "art@mail.ru",
            //        "developer", 80000, 1985);

            // 5.	Создать массив из 5 сотрудников. С помощью цикла вывести
            // информацию только о сотрудниках старше 40 лет;

            //Employee[] employees = {
            //    e,
            //    new Employee("Andrey", "Viktorovich",
            //            "Bezrukov", "8(495)111-22-33", "art@mail.ru",
            //            "fitter", 52000, 1973),
            //    new Employee("Evgeniy", "Viktorovich",
            //            "Del'finov", "8(495)222-33-44", "art@mail.ru",
            //            "project manager", 40000, 1963),
            //    new Employee("Natalia", "Pavlovna",
            //            "Keks", "8(495)333-44-55", "art@mail.ru",
            //            "senior developer", 90000, 1990),
            //    new Employee("Tatiana", "Sergeevna",
            //            "Krasotkina", "8(495)444-55-66", "art@mail.ru",
            //            "accountant", 50000, 1983)
            //};

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    if (employees[i].getAge() > 40)
            //        Console.WriteLine(employees[i].GetFullInfo());
            //}

            //Console.WriteLine("--------------------------------------------------------");

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].GetFullInfo());
            //}

            //Console.WriteLine("--------------------------------------------------------");
       // }

        public static int sumArray(string[,] sArray)
        {
            int sum = 0;
            if (sArray.GetLength(0) != 4) throw new MyArraySizeExeption();
            for (int i = 0; i < sArray.GetLength(0); i++)
            {
                for (int j = 0; j < sArray.GetLength(1); j++)
                {
                    try
                    {
                        sum += Int32.Parse(sArray[i,j]);
                    }
                    catch (Exception e)
                    {
                        throw new MyArrayDataException(i, j);
                    }

                }
            }
            return sum;
        }


            static void ShowList(List<ToDo> todoList)
            {
                for (int i = 0; i < todoList.Count; i++)
                {
                    string isTaskDone = todoList[i].IsDone ? "[X]" : "";
                    Console.WriteLine($"{i}  {isTaskDone,3} {todoList[i].Title}");
                }
                Console.WriteLine();
            }

            static void Edit(ref List<ToDo> todoList)
            {
                if (todoList.Count == 0)
                {
                    Console.WriteLine("Список задач пуст.");
                    return;
                }
                Console.Write("Введите порядковый номер задачи: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < todoList.Count)
                        todoList[number].IsDone = true;
                    else
                    {
                        Console.WriteLine($"Указан неверный номер задачи. Введите номер от 0 до {todoList.Count - 1}");
                        Edit(ref todoList);
                    }
                }
            }

            static void Add(ref List<ToDo> todoList)
            {
                Console.Write("Введите текст задачи: ");
                string task = Console.ReadLine();
                todoList.Add(new ToDo(task));
            }

            static List<ToDo> ReadFile(string format, string fileName)
            {
                List<ToDo> todoList;

                switch (format)
                {
                    case "xml":
                        todoList = ReadXml(fileName);
                        break;
                    case "bin":
                        todoList = ReadBin(fileName);
                        break;
                    case "json":
                    default:
                        todoList = ReadJson(fileName);
                        break;
                }

                return todoList;
            }

            static void Save(string format, string fileName, List<ToDo> todoList)
            {
                switch (format)
                {
                    case "xml":
                        SaveXml(todoList, fileName);
                        break;
                    case "bin":
                        SaveBin(todoList, fileName);
                        break;
                    case "json":
                    default:
                        SaveJson(todoList, fileName);
                        break;
                }
            }

            static List<ToDo> ReadXml(string fileName)
            {
                List<ToDo> todoList = new List<ToDo>();
                if (File.Exists(fileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    {
                        todoList = (List<ToDo>)serializer.Deserialize(fs);
                    }
                }
                return todoList;
            }

            static List<ToDo> ReadJson(string fileName)
            {
                List<ToDo> todoList = new List<ToDo>();
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    todoList = JsonSerializer.Deserialize<List<ToDo>>(jsonString);
                }
                return todoList;
            }

            static List<ToDo> ReadBin(string fileName)
            {
                List<ToDo> todoList = new List<ToDo>();
                if (File.Exists(fileName))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    {
                        todoList = (List<ToDo>)formatter.Deserialize(fs);
                    }
                }
                return todoList;
            }

            static void SaveXml(List<ToDo> todoList, string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    serializer.Serialize(fs, todoList);
                }

            }

            static void SaveJson(List<ToDo> todoList, string fileName)
            {
                string jsonSerialize = JsonSerializer.Serialize(todoList);
                File.WriteAllText(fileName, jsonSerialize);
            }

            static void SaveBin(List<ToDo> todoList, string fileName)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    formatter.Serialize(fs, todoList);
                }
            }
        }
}

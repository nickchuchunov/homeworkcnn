using System;
using System.Text.Json;
using System.IO;
using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters.Binary;

namespace IntroductionClevel6Chuchunov
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.*/

          FileList file = new  FileList();






            /*2. Список задач (ToDo-list) написать приложение для ввода списка задач;
            задачу описать классом ToDo с полями Title и IsDone;
            на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
            если задача выполнена, вывести перед её названием строку «[x]»;
            вывести порядковый номер для каждой задачи;
            при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
            записать актуальный массив задач в файл tasks.json/xml/bin.*/

            /* Console.WriteLine("Опишите задачи которую нужно добавить в список  ");
            string title = Console.ReadLine();
            string isdone = " ";
            int number = 1;
            ToDo Todo1 = new ToDo( title, isdone, number);
            Todo1.Title = title;
            Todo1.IsDone = isdone;
            Todo1.Number = number;




            String Todo2 = JsonSerializer.Serialize(Todo1); // сереализация экземпляра класса ToDo

            File.AppendAllText("Todo.json", Todo2); // запись в фил

            String filstring = File.ReadAllText("Todo.json"); // чтение из файла

            ToDo ToDo3 = JsonSerializer.Deserialize<ToDo>(filstring); // десереализация - ОШИБКА

            for (int i=1; ToDo3.Number == ToDo3.Number; ++i) { ToDo3.Number = i; }; // изменение номера п. п. задачи

            string Todo4 = JsonSerializer.Serialize(ToDo3);  // Сереализация измененного объекта для записи в блокнот

            File.WriteAllText("tasks1.txt", Todo4); // полная перезапись блокнота новые задачи + старые */


            /* 3. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
            при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
            Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
            Если в каком-то элементе массива преобразование не удалось
            (например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, с детализацией в какой именно ячейке лежат неверные данные.
            В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета. */



           string[,] arrey4x4sum = new string[4, 4] { {"1", "2", "3", "4"}, {"5", "6", "7", "8" }, {"9", "10", "11", "12" }, {"13", "14", "15", "16" } };
            int smarrei2;
            Array4х4 Array4х4new = new Array4х4(arrey4x4sum, out smarrei2);

            Console.WriteLine(smarrei2); 




            /*4.Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
Конструктор класса должен заполнять эти поля при создании объекта;
Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
Создать массив из 5 сотрудников

Пример:
Person[] persArray = new Person[5]; // Вначале объявляем массив объектов
persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30); // потом для каждой ячейки массива задаем объект
persArray[1] = new Person(...);
...
persArray[4] = new Person(...);

С помощью цикла вывести информацию только о сотрудниках старше 40 лет; */


         string[][] persArray = new string[5] [];

            persArray[0] = new string [] { "Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", "30000", "30" };
            persArray[1] = new string[] { "Alexandr Ivan", "Engineer", "Alexandr@mailbox.com", "892312317", "30000", "36" };
            persArray[2] = new string[] { "Dmitriy Kuzin", "Engineer", "DKuzin@mailbox.com", "892312318", "30000", "41" };
            persArray[3] = new string[] { "Kudiniv Vitaliy", "Engineer", "VKudiniv@mailbox.com", "892312319", "30000", "40" };
            persArray[4] = new string[] { "Boyko Mixail", "Engineer", "MixailBoyko@mailbox.com", "892312320", "30000", "42" };

            Employee khb = new Employee(persArray);

            Employee[] lnl1 = new Employee[6]; 

















































        }
    }







}

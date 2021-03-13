using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_5
{
    class Cat
    {
        public int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public string Name { get; set; }

        public Cat()
        {
        }

        public Cat(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void info()
        {
            Console.WriteLine($"{Age} {Name}");
        }
    }
}



//public int Age
//{
//    get
//    {
//        return Age;
//    }

//    set
//    {
//        age = value;
//    }
//}
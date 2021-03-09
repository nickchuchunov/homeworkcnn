using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionClevel6Chuchunov
{
    class Employee
    {
        public string LastFirstPatronymic { get; set; } // фамилия имя отчество
        public string Post { get; set; } // Должность
        public string Email { get; set; } // почта
        public string Pfone { get; set; } // телефон
        public string Salary { get; set; } // зарплата
        public int Age { get; set; } // возвраст
        public Employee[][] argEmployee = new Employee[5][];



        public Employee(string[][] arreyEmployee ) {

           

            





            

            for (int k = 0; k < arreyEmployee.GetLength(0); k++) {
                  LastFirstPatronymic =arreyEmployee[k][0];
                   Post = arreyEmployee[k] [1];
                   Email = arreyEmployee[k] [2];
                   Pfone = arreyEmployee[k] [3];
                   Salary = arreyEmployee[k] [4];
                   Age= Convert.ToInt32(arreyEmployee[k] [5]);


                if (Age >= 40) { Console.WriteLine(" фамилия имя отчество{0} Должность {1} почта {2} телефон {3} зарплата {4} возвраст {5} ", LastFirstPatronymic, Post, Email, Pfone, Salary, Age); };




                } 







        }



    }
}

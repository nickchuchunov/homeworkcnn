// Decompiled with JetBrains decompiler
// Type: IntroductionClevel6Chuchunov.Employee
// Assembly: IntroductionClevel6Chuchunov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 937EBE25-9469-4B2E-BDCF-E16079CB99BF
// Assembly location: C:\IntroductionClevel6Chuchunov\IntroductionClevel6Chuchunov\bin\Release\netcoreapp3.1\IntroductionClevel6Chuchunov.dll

using System;

namespace IntroductionClevel6Chuchunov
{
  internal class Employee
  {
    public Employee[][] argEmployee = new Employee[5][];

    public string LastFirstPatronymic { get; set; }

    public string Post { get; set; }

    public string Email { get; set; }

    public string Pfone { get; set; }

    public string Salary { get; set; }

    public int Age { get; set; }

    public Employee(string[][] arreyEmployee)
    {
      for (int index = 0; index < arreyEmployee.GetLength(0); ++index)
      {
        this.LastFirstPatronymic = arreyEmployee[index][0];
        this.Post = arreyEmployee[index][1];
        this.Email = arreyEmployee[index][2];
        this.Pfone = arreyEmployee[index][3];
        this.Salary = arreyEmployee[index][4];
        this.Age = Convert.ToInt32(arreyEmployee[index][5]);
        if (this.Age >= 40)
          Console.WriteLine(" фамилия имя отчество{0} Должность {1} почта {2} телефон {3} зарплата {4} возвраст {5} ", (object) this.LastFirstPatronymic, (object) this.Post, (object) this.Email, (object) this.Pfone, (object) this.Salary, (object) this.Age);
      }
    }
  }
}

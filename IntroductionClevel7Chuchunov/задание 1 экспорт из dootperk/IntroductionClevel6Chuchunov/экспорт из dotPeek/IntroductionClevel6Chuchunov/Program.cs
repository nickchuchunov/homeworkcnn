// Decompiled with JetBrains decompiler
// Type: IntroductionClevel6Chuchunov.Program
// Assembly: IntroductionClevel6Chuchunov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 937EBE25-9469-4B2E-BDCF-E16079CB99BF
// Assembly location: C:\IntroductionClevel6Chuchunov\IntroductionClevel6Chuchunov\bin\Release\netcoreapp3.1\IntroductionClevel6Chuchunov.dll

using System;

namespace IntroductionClevel6Chuchunov
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      FileList fileList = new FileList();
      int sumarrey;
      Array4х4 array4х4 = new Array4х4(new string[4, 4]
      {
        {
          "1",
          "2",
          "3",
          "4"
        },
        {
          "5",
          "6",
          "7",
          "8"
        },
        {
          "9",
          "10",
          "11",
          "12"
        },
        {
          "13",
          "14",
          "15",
          "16"
        }
      }, out sumarrey);
      Console.WriteLine(sumarrey);
      Employee employee = new Employee(new string[5][]
      {
        new string[6]
        {
          "Ivanov Ivan",
          "Engineer",
          "ivivan@mailbox.com",
          "892312312",
          "30000",
          "30"
        },
        new string[6]
        {
          "Alexandr Ivan",
          "Engineer",
          "Alexandr@mailbox.com",
          "892312317",
          "30000",
          "36"
        },
        new string[6]
        {
          "Dmitriy Kuzin",
          "Engineer",
          "DKuzin@mailbox.com",
          "892312318",
          "30000",
          "41"
        },
        new string[6]
        {
          "Kudiniv Vitaliy",
          "Engineer",
          "VKudiniv@mailbox.com",
          "892312319",
          "30000",
          "40"
        },
        new string[6]
        {
          "Boyko Mixail",
          "Engineer",
          "MixailBoyko@mailbox.com",
          "892312320",
          "30000",
          "42"
        }
      });
      Employee[] employeeArray = new Employee[6];
    }
  }
}

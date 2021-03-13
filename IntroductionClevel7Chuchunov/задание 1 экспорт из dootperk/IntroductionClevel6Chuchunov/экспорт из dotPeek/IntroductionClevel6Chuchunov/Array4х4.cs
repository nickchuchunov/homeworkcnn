// Decompiled with JetBrains decompiler
// Type: IntroductionClevel6Chuchunov.Array4х4
// Assembly: IntroductionClevel6Chuchunov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 937EBE25-9469-4B2E-BDCF-E16079CB99BF
// Assembly location: C:\IntroductionClevel6Chuchunov\IntroductionClevel6Chuchunov\bin\Release\netcoreapp3.1\IntroductionClevel6Chuchunov.dll

using System;

namespace IntroductionClevel6Chuchunov
{
  public class Array4х4
  {
    public int[,] arreyInt4x4 = new int[4, 4];
    public static int sumarrey;

    public Array4х4(string[,] arreyString4х4, out int sumarrey)
    {
      if (arreyString4х4.GetLength(0) > 4)
      {
        Console.WriteLine("ваш массив больше чем 4х4");
        throw new RankException();
      }
      sumarrey = 0;
      int[,] numArray = new int[4, 4];
      for (int index1 = 0; index1 < arreyString4х4.GetLength(0); ++index1)
      {
        for (int index2 = 0; index2 < arreyString4х4.GetLength(0); ++index2)
        {
          try
          {
            numArray[index1, index2] = Convert.ToInt32(arreyString4х4[index1, index2]);
          }
          catch (FormatException ex)
          {
            Console.WriteLine("в строке {0} и в столбце {1} неправильные данные", (object) index1, (object) index2);
          }
        }
      }
      for (int index1 = 0; index1 < numArray.GetLength(0); ++index1)
      {
        for (int index2 = 0; index2 < numArray.GetLength(0); ++index2)
          sumarrey += numArray[index1, index2];
      }
    }
  }
}

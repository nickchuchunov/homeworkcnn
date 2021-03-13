// Decompiled with JetBrains decompiler
// Type: IntroductionClevel6Chuchunov.ToDo
// Assembly: IntroductionClevel6Chuchunov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 937EBE25-9469-4B2E-BDCF-E16079CB99BF
// Assembly location: C:\IntroductionClevel6Chuchunov\IntroductionClevel6Chuchunov\bin\Release\netcoreapp3.1\IntroductionClevel6Chuchunov.dll

using System;

namespace IntroductionClevel6Chuchunov
{
  [Serializable]
  public class ToDo
  {
    public string Title { get; set; }

    public string IsDone { get; set; }

    public int Number { get; set; }

    public ToDo(string title, string isdone, int number)
    {
      this.Title = title;
      this.IsDone = isdone;
      this.Number = number;
    }

    public ToDo()
    {
    }
  }
}

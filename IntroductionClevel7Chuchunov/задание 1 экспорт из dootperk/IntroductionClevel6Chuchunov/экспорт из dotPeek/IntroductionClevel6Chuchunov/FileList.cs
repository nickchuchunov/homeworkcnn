// Decompiled with JetBrains decompiler
// Type: IntroductionClevel6Chuchunov.FileList
// Assembly: IntroductionClevel6Chuchunov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 937EBE25-9469-4B2E-BDCF-E16079CB99BF
// Assembly location: C:\IntroductionClevel6Chuchunov\IntroductionClevel6Chuchunov\bin\Release\netcoreapp3.1\IntroductionClevel6Chuchunov.dll

using System;
using System.IO;

namespace IntroductionClevel6Chuchunov
{
  public class FileList
  {
    public FileList()
    {
      Console.WriteLine("укажите путь дериктории для создания списка каталога файлов в текстовом файле");
      string str = Console.ReadLine();
      Console.WriteLine("укажите имя текстового файла с расширением txt для записи списка ");
      string path2 = Console.ReadLine();
      Console.WriteLine(Directory.Exists(str));
      File.WriteAllLines(Path.Combine(str, path2), Directory.GetFileSystemEntries(str, "*", SearchOption.AllDirectories));
    }
  }
}

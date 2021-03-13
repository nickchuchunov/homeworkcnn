using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IntroductionClevel6Chuchunov
{
   public class FileList
    {
        public FileList() {

            Console.WriteLine("укажите путь дериктории для создания списка каталога файлов в текстовом файле");
            string trec = Console.ReadLine();
            Console.WriteLine("укажите имя текстового файла с расширением txt для записи списка ");
            string fail = Console.ReadLine();

            string HomeDir = trec;
            Console.WriteLine(Directory.Exists(HomeDir));
            string DirInvestment = Path.Combine(HomeDir, fail);
            string[] HomeDirInvestment = Directory.GetFileSystemEntries(HomeDir, "*", SearchOption.AllDirectories);
            File.WriteAllLines(DirInvestment, HomeDirInvestment);





        }






    }
}

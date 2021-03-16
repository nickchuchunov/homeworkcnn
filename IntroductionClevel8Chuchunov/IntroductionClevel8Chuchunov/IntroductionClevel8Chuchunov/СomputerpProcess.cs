using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace IntroductionClevel8Chuchunov
{
    public class СomputerpProcess

    {

        public СomputerpProcess ()
       
        {

           // Console.WriteLine("задайте имя файла с расширением exe для запуска процесса ");
           // string StartFile = Console.ReadLine();

           // Process proces = Process.Start(StartFile);




           // Process[] processes = Process.GetProcessesByName(StartFile);
            Process[] processes = Process.GetProcesses();
            //Console.WriteLine(processes);


          for (int i=0; i< processes.Length; i++) 

         {
             Console.WriteLine("Id процесса {0} имя процесса {1} ", i, Convert.ToString(processes[i]));

          }


            Console.WriteLine("ВВЕДИТЕ ID ПРОЦЕССА КОТОРЫЙ НУЖНО ЗАВЕРШИТЬ");

            int StartFile = Convert.ToInt32(Console.ReadLine());

            processes[StartFile].Kill();



            







        }












        //    Console.WriteLine(args[0]);
        //Console.WriteLine(args.Length);











        //Process notepad = Process.Start("notepad.exe");
        //Console.WriteLine("Нажмите любую клавишу для завершения процесса...");
        //Console.ReadKey();
        //notepad.Kill();
        //Console.WriteLine(notepad.ExitCode); // -1








    }
}

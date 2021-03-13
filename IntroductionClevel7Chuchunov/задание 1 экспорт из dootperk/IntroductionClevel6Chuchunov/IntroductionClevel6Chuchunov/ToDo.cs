using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;


namespace IntroductionClevel6Chuchunov
{
    [Serializable]
    public class ToDo
    {
       
        public  string Title { get; set; }
        public  string  IsDone  { get; set; }
        public int Number { get; set; }
        
        public ToDo(string  title, string  isdone, int number) { Title = title; IsDone = isdone; Number = number;  }

        public ToDo() {  }





















    }



    



    
}

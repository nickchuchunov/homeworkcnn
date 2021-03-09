using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IntroductionClevel6Chuchunov
{
    public class Array4х4
    {
       public string[,] arreyString4х4 = new string[4, 4];

        public int[,] arreyInt4x4 = new int[4, 4];
       
        


        public static int sumarrey;

        
            

public Array4х4( string[,] arreyString4х4, out int sumarrey  ) 
        {
            bool gr = arreyString4х4.GetLength(0) > 4;
            if (gr = true) { Console.WriteLine("ващ массив больше чем 4х4"); throw new RankException(); };

           


            

            sumarrey = 0;
           
            int[,] arreyInt4x4 = new int[4, 4];
            for (int i=0; i< arreyString4х4.GetLength(0);  i++) { for (int j = 0; j < arreyString4х4.GetLength(0); j++) { try { arreyInt4x4[i, j] = Convert.ToInt32(arreyString4х4[i, j]); } catch (FormatException) { Console.WriteLine("в строке {0} и в столбце {1} неправильные данные", i, j); } }; };

            for (int i = 0; i < arreyInt4x4.GetLength(0); i++) { for (int j = 0; j < arreyInt4x4.GetLength(0); j++) {  sumarrey += arreyInt4x4[i, j];  }; };








        }


    }
}

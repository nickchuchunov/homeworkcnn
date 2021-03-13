using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_7
{
    class Cross
    {
        static int SIZE_X = 3;
        static int SIZE_Y = 3;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i,j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i,j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        private static bool CheckWin(char sym)
        { int field1=0;  // объявление переменных в случае заполнения строк и столюуов и диагоналей "х" "0"
          int field2=0;
          int field3=0;
          int field4 = 0;
          int field5 = 0;
          int field6 = 0;
          int field7 = 0;
            int field8 = 0;
            int field9 = 0;
            int field10 = 0;
            int field11 = 0;
            int field12 = 0;
            int field13 = 0;
            int field14 = 0;
            int field15 = 0;
            int field16 = 0;


            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++) // итерация по элементам массива
                {
                    if (field[0, j] == PLAYER_DOT) { field1++; } // условие если строка заполнена "х"
                    if (field[1, j] == PLAYER_DOT) { field2++; }
                    if (field[2, j] == PLAYER_DOT) { field3++; }
                    if (field[i, 0] == PLAYER_DOT) { field4++; }
                    if (field[i, 1] == PLAYER_DOT) { field5++; }
                    if (field[i, 2] == PLAYER_DOT) { field6++; }
                    if (j == i && field[i, j] == PLAYER_DOT) { field7++; } // по диагонали с лево на право а по диагонали с право на лево ?
                    

                    

                    if (field3 == field.Length - 1 || field2 == field.Length - 1 || field1 == field.Length - 1||field4 == field.Length - 1 || field5 == field.Length - 1 || field6 == field.Length - 1 || field7 == field.Length - 1 || field8 == field.Length - 1) { Console.WriteLine("вы победили"); return true; }


                    if (field[0, j] == AI_DOT) { field9++; }
                    if (field[1, j] == AI_DOT) { field10++; }
                    if (field[2, j] == AI_DOT) { field11++; }
                    if (field[i, 0] == AI_DOT) { field12++; }
                    if (field[i, 1] == AI_DOT) { field13++; }
                    if (field[i, 2] == AI_DOT) { field14++; }
                    if (i == j && field[i, j] == AI_DOT) { field15++; }
                 


                   

                    if (field9 == field.Length - 1 || field10 == field.Length - 1 || field11 == field.Length - 1 || field12 == field.Length - 1 || field13 == field.Length - 1 || field14 == field.Length - 1 || field15 == field.Length - 1 || field16 == field.Length - 1) { Console.WriteLine("победил компьютер"); return true; }

                   




                }


            }










            /*  if (field[0,0] == sym && field[0, 1] == sym && field[0, 2] == sym)
              {
                  return true;
              }
              if (field[1, 0] == sym && field[1, 1] == sym && field[1, 2] == sym)
              {
                  return true;
              }
              if (field[2, 0] == sym && field[2, 1] == sym && field[2, 2] == sym)
              {
                  return true;
              }

              if (field[0, 0] == sym && field[1, 0] == sym && field[2, 0] == sym)
              {
                  return true;
              }
              if (field[0, 1] == sym && field[1, 1] == sym && field[2, 1] == sym)
              {
                  return true;
              }
              if (field[0, 2] == sym && field[1, 2] == sym && field[2, 2] == sym)
              {
                  return true;
              }

              if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym)
              {
                  return true;
              }
              if (field[2, 0] == sym && field[1, 1] == sym && field[0, 2] == sym)
              {
                  return true;
              }*/

            return false;
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                AiStep();
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("SkyNet Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }
}

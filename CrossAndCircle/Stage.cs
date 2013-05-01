using System;

namespace CrossAndCircle
{
    public class Stage
    {
        public int[][] Board = 
        {
            new int[3] ,
            new int[3] ,
            new int[3] 
        };

        public void PrintBoard()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if(Board[i][j] == 2)
                    Console.Write("o" + "    "); 
                    else if(Board[i][j] == 1)
                    Console.Write("x" + "    ");
                    else Console.Write(" " + "    ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
                
        }

        public int GameWinner()
        {
            var i = 0;
            var j = 0;
            var count1 = 0;
            var count2 = 0;

            for (j = 0; j < 3; j++)
            {
                if (Board[i][j] == 1) count1++;
                if (Board[i][j] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 1;
            for (j = 0; j < 3; j++)
            {
                if (Board[i][j] == 1) count1++;
                if (Board[i][j] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 2;
            for (j = 0; j < 3; j++)
            {
                if (Board[i][j] == 1) count1++;
                if (Board[i][j] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 0;
            for (j = 0; j < 3; j++)
            {
                if (Board[j][i] == 1) count1++;
                if (Board[j][i] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 1;
            for (j = 0; j < 3; j++)
            {
                if (Board[j][i] == 1) count1++;
                if (Board[i][j] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 2;
            for (j = 0; j < 3; j++)
            {
                if (Board[j][i] == 1) count1++;
                if (Board[j][i] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

 
            for (j = 0; j < 3; j++)
            {
                if (Board[j][j] == 1) count1++;
                if (Board[j][j] == 2) count2++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;
            count1 = count2 = 0;

            i = 0;
            for (j = 2; j >= 0; j--)
            {
                if (Board[i][j] == 1) count1++;
                if (Board[i][j] == 2) count2++;
                i++;
            }

            if (count1 == 3) return 1;
            if (count2 == 3) return 2;

            return 0;
        }
    }
}

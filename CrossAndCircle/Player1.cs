﻿using System;
using CrossAndCircle;

namespace CrossAndCircle
{
    class Player1 : CrossAndCircleGame
    {
        public void PutACross()
        {
            Console.WriteLine("Choose row and column of the table to put your x");
        
            while (true)
            {
                var row = int.Parse(Console.ReadLine());
                var column = int.Parse(Console.ReadLine());

                if (row < 0 || row > 2 || column < 0 || column > 2)
                {
                    Console.WriteLine("The range of row and column is : [0 ; 2]");
                }
                else if (Stage.Board[row][column] != 0)
                {
                    Console.WriteLine("You cannot make that move, try agains");
                }
                else
                {
                    Stage.Board[row][column] = 1;
                    break;
                }
            }
        }
    }
}

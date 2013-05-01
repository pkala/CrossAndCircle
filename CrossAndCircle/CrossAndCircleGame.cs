using System;

namespace CrossAndCircle
{
    public class CrossAndCircleGame
    {
        public static Stage Stage = new Stage();
        public static Boolean Stop = true;

        public void Start()
        {
            var player1 = new Player1();
            var player2 = new Player2();

            var random = new Random();
            var turn = random.Next(0, 1);

            if (turn == 0) turn = -1;

            if( turn == -1) Console.WriteLine("Player1 (cross) starts");
            if( turn == 1) Console.WriteLine("Player2 (circle) starts");

            while (Stop)
            {
                Console.Clear();
                Stage.PrintBoard();

                if (turn == 1)
                {
                    player1.PutACross();
                }

                if (turn == -1)
                {
                    player2.PutACircle();
                }

                turn *= -1;

                if (Stage.GameWinner() != 0)
                {
                    Console.Clear();
                    Stage.PrintBoard();
                    Console.WriteLine(("The winner is player :" + Stage.GameWinner()));
                    Stop = false;
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;
using System.Text;

namespace PII_Game_Of_Life
{
    public class GameLoop
    {
        public static bool[,] RefreshBoard(bool[,] initialBoard)
        {
            int width = initialBoard.GetLength(0);
            int height = initialBoard.GetLength(1); 
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(initialBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                initialBoard = GameBoard.CurrentBoardState(initialBoard);
                Thread.Sleep(300);
            }
        }
    }
}

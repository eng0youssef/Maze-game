using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Maze theGame=new Maze(10,20);
            

            bool playAgain = true;

            while (playAgain)
            {
                theGame.player.x = 1;
                theGame.player.y = 1;
                while (theGame.DrawMaze())
                {
                    theGame.DrawMaze();
                }
                Console.WriteLine("Do you want to play again? (Y/N)");
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key != ConsoleKey.Y)
                {
                    playAgain = false;
                    Console.WriteLine("\nThanks for playing! Goodbye.");
                }
                
            }

            
            
        }
    }


}
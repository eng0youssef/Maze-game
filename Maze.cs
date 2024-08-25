using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Maze
    {
        private int height;
        private int width;
        internal Player player;
        private IMazeObject[,] Object ;
        public Maze(int _height, int _width)
        {
            height = _height;
            width = _width+1;
            Object = new IMazeObject[height, width];
            player= new Player();
               
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput= Console.ReadKey();
            ConsoleKey key=userInput.Key;

            switch(key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(-1,0);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(0, 1);
                    break;
                default: break;
            }

        }
        private void UpdatePlayer(int dx, int dy) 
        {
            
            if((player.x+dx) < height && (player.y + dy < width)
                && (player.x+dx)>=0 && (player.y+dy) >= 0 
                && Object[player.x + dx, player.y + dy].isSolid==false) 
            {
                player.y += dy;
                player.x += dx;

            }  
        }
        public bool DrawMaze()
        {
            Console.Clear();
            for (int i= 0; i < height; i++)
            {
                for (int j = 0; j <width; j++)
                {
                    if (i==0||i==height-1||j==0 ||j==width-2
                        || i % 3 == 0 && j % 3 == 0
                        || i % 4 == 0 && j % 5 == 0
                        || i % 6 == 0 && j % 6 == 0
                        || i % 2 == 0 && j % 2 == 0
                        || i % 5 == 0 && j % 3 == 0
                        || i % 3 == 0 && j % 2 == 0
                        ) 
                    {
                        if (i == height - 3 && j == width - 2
                            )
                        {
                            if (i == player.x && j == player.y)
                            {
                                Console.Write(player.Icon);

                            }
                            else
                            {
                                Object[i, j] = new EmptySpace();
                                Console.Write(Object[i, j].Icon);
                            }
                        }
                        else {
                            Object[i, j] = new Wall();
                            Console.Write(Object[i, j].Icon);
                        }

                    }
                    
                    else if (i==player.x&&j==player.y)
                    {
                        Console.Write(player.Icon);
                    }
                    else
                    {
                        Object[i, j] = new EmptySpace();
                        Console.Write(Object[i, j].Icon);
                    }
                    
                }
                Console.WriteLine();
            }
            if(player.x == height - 3 && player.y== width - 1)
            {
                Console.Clear();
                Console.WriteLine("Great, you have finished solving the maze");
                
                return false;
                
            }
            else { MovePlayer();
                return true;
            }
              
        }
    }
}

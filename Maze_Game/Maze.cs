using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Maze
    {
        public int _Width;
        public int _Heigth;
        public Player _player;
        public IMaze[,] _MazeArray;

        public Maze(int width, int height)
        {
             _Width =width; 
            _Heigth =height;
            _MazeArray= new IMaze[width,height];
            _player = new Player()
            {
                X = 1,
                Y = 1,
            };  
              

        }

        
        public void MovePlayer()
        {

            ConsoleKeyInfo UserInput = Console.ReadKey();
            ConsoleKey consoleKey = UserInput.Key;

            switch (consoleKey)
            {
                case ConsoleKey.UpArrow:
                    UPdatePlayer(0, -1);
                    break; 

                case ConsoleKey.DownArrow:
                    UPdatePlayer(0, 1);
                    break; 

                case ConsoleKey.LeftArrow:
                    UPdatePlayer(-1,0);
                    break; 

                case ConsoleKey.RightArrow:
                    UPdatePlayer(1,0);
                    break;

             }
        }

        public void UPdatePlayer(int dx, int dy)
        {
             int newX = _player.X + dx;
             int newY = _player.Y + dy;
            if (newX < _Width && newX >=0 && newY < _Width && newY >= 0 && _MazeArray[newX, newY].IsSolid==false  )
            {
                _player.X = newX;
                _player.Y = newY;
                DrawMaze();
            }
            

        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int Y = 0; Y < _Heigth; Y++)
            {
                for (int X =0; X< _Width; X++)
                {
                    if (X == 0 || Y == 0 || X == _Width - 1 || Y == _Heigth - 1)
                    {
                        _MazeArray[X, Y] = new Wall();
                        Console.Write(_MazeArray[X, Y].Icon);
                    }
                    else if (X == _player.X && Y == _player.Y)
                    {
                        Console.Write(_player.Icon);

                    }
                    else if()
                    {
                    
                    }
                    else
                    {
                        _MazeArray[X, Y] = new EmptySpaces();
                        Console.Write(_MazeArray[X, Y].Icon);
                    }
                   
                }

                Console.WriteLine();
            }
        }
    }
}

namespace Maze_Game  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");


            Maze maze = new Maze(40,20);
            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
        }
    }
}

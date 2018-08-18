using System;
namespace qqq
{
    public class Main
    {
        public Main()
        {
            MazeGame game = new MazeGame();
            MazeFactory factory = new MazeFactory();
            Maze maze;

            maze = game.CreateMaze(factory); //s

        }
    }
}

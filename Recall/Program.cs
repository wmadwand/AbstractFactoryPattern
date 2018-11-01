using System;
using System.Collections.Generic;

namespace Recall
{
    interface IPlace
    {
        void Enter();
    }

    class Wall : IPlace
    {
        void IPlace.Enter()
        {
            throw new NotImplementedException();
        }
    }

    class Door : IPlace
    {
        void IPlace.Enter()
        {
            throw new NotImplementedException();
        }
    }

    class Room : IPlace
    {
        public Room()
        {
            Console.WriteLine("Room got used");
        }

        void IPlace.Enter()
        {
            throw new NotImplementedException();
        }
    }

    class Maze
    {
        List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {

        }

        public void RemoveRoom() { }
    }

    class MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom()
        {
            return new Room();
        }

        public virtual Door MakeDoor()
        {
            return new Door();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }
    }

    class AirRoom : Room
    {
        public int magicShieldHealth;

        public AirRoom()
        {
            Console.WriteLine("AirRoom got used");
        }
    }

    class AirMazeFactory : MazeFactory
    {
        public override Room MakeRoom()
        {
            return new AirRoom();
        }
    }

    class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();

            Room room1 = factory.MakeRoom();
            Room room2 = factory.MakeRoom();

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }

    class Program
    {
        public static void Main()
        {
            MazeFactory factory = new MazeFactory();
            MazeGame game = new MazeGame();

            Maze maze = game.CreateMaze(factory);

            MazeFactory airMazeFactory = new AirMazeFactory();
            maze = game.CreateMaze(airMazeFactory);
        }
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World!");
//    }
//}


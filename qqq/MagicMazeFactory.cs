using System;
namespace qqq
{
    public class MagicRoom : Room
    {
        public MagicRoom(int num) : base(num)
        {

        }
    }




    public class MagicMazeFactory : MazeFactory
    {
        public MagicMazeFactory()
        {
        }

        public override Room MakeRoom(int n)
        {
            return new MagicRoom(n);
        }

        //---------------------------------------

         

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Player:IMaze
    {
        public bool IsSolid => true;

        public char Icon { get => '@'; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

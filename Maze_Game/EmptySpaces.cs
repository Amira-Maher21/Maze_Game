using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class EmptySpaces:IMaze
    {
        public bool IsSolid => false;

        public char Icon { get => ' '; }
    }
}

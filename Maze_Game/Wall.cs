using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Wall : IMaze
    {
        public bool IsSolid => true;

        public char Icon { get => '#'; }
    }
}

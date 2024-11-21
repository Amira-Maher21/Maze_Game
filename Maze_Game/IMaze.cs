using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public interface IMaze
    {
          bool IsSolid { get; }
           char Icon { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal interface IMazeObject
    {
        string Icon { get; }
        bool isSolid { get; }
    }
}

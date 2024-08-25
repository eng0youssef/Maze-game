using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class EmptySpace : IMazeObject
    {
        public string Icon => " ";

        public bool isSolid => false;
    }
}

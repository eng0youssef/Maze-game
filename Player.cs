using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Player : IMazeObject
    {
        public int x { set; get; }
        public int y { set; get; }
        public string Icon => "@";

        public bool isSolid => false;
    }
}

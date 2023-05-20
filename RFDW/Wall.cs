using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    class Wall : GameObject // Object with collider
    {
        public new string name = "Wall";
        public new string art = "■";

        public Wall(int x, int y, int z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}

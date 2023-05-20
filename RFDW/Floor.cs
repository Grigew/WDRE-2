using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    public class Floor : GameObject // Floor, under all objects
    {
        public new string art = ".";
        public Floor(int x, int y, int z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}

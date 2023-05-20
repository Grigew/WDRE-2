using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    class Enemy : Living
    {
        //settings
        public new string name = "Enemy";
        public new string art = "&";
        public new int speed = 12;

        public Enemy(int x, int y, int z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}

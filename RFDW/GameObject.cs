using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    public class GameObject
    {
        public int hp = 100 / 100;
        public string? name;
        public string art = "○";

        private protected int x = 0;
        private protected int y = 0;
        private protected int z = 0;

        public int X
        {
            get { return x; } 
            private protected set { x = value; }
        }
        public int Y
        {
            get { return y; }
            private protected set { y = value; }
        }
        public int Z
        {
            get { return z; }
            private protected set { z = value; }
        }

        public GameObject(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

    }
}

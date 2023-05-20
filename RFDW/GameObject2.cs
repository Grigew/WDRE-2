using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    internal class GameObject2
    {
        //Cosmetics
        public string? Name { get; set; }
        public string? Sprite { get; set; }
        // Pos
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        // Stats
        public bool IsPlayer { get; set; }
        public bool IsUndying { get; set; }
        public bool IsAlive { get; set; }
        public bool IsCollidable { get; set; }
        public bool IsPhysical { get; set; }

        public GameObject2()  /*(float x = 0, float y = 0, float z = 0, string sprite = null, string name = null, bool isPlayer = false, bool isCollideble = false, bool isAlive = true)*/
        {
            //X = x;
            //Y = y;
            //Z = z;
            //Sprite = sprite;
            //Name = name;
            //IsPlayer = isPlayer;
            //IsCollideble = isCollideble;
            //IsAlive = isAlive;
        }
    }
}

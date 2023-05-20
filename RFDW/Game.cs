using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    static class Game
    {
        // Game settings
        public static bool debug = true;
        public static bool music = true; // (coming soon)

        public static int camera_z; // Camera's z-level
        public static int gravity = 1; // gravity force

        // Objects massive
        public static List<GameObject> sbj = new List<GameObject>(); // All objects massive | [class, id] | 0 - creatures, 1 - walls, 2 - Floors , 3 - Water etc 
        public static int sbj_h = 2; // obj height
        public static int sbj_w = Map.map1.Length/sbj_h; // obj width
        public static int sbj_s = Map.map1.Length; // obj size

        // Other


        // Temp fields

        public static int player_id;
        public static int enemy_id;

        // Other methods
    }
}

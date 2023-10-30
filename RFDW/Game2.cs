using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace RFDW
{
    static internal class Game2
    {
        static public GameObject2[,,] Chunk { get; private set; } = new GameObject2[1000, 1000, 1000];
        static public void CreateChunks(int amount)
        {

        }
        static public void AddToChunk(GameObject2 obj)
        {
            int chunkX = CountObjectChunk(obj, 0);
            int chunkY = CountObjectChunk(obj, 1);
            int chunkZ = CountObjectChunk(obj, 2);
            Console.WriteLine($"Object was added to {chunkX}x {chunkY}y {chunkZ}z chunk");
            Chunk[chunkX, chunkY, chunkZ] = obj;
        }
        static public int CountObjectChunk(GameObject2 obj, int dimension)
        {
            if (dimension > 2 || dimension < 0) { throw new Exception($"Invalid chunk demension ({dimension}). Must be 0 or 1 or 2"); }
            switch (dimension)
            {
                case 0: // X
                    return (int)Math.Round(Math.Abs(obj.X) / 16);
                case 1: // Y
                    return (int)Math.Round(Math.Abs(obj.Y) / 16);   
            }
            return (int)Math.Round(Math.Abs(obj.Z) / 16); // Z
        }
        static public void Update()
        {
        }
    }
}

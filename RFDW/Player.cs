using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace RFDW
{
    class Player : Living
    {
        //settings
        public new string name = "Вы";
        public new string art = "☺";

        public int stamina = 10/10;
        public new int speed = 5;

        public bool noclip = false;

        public void Move(Object? sender, KeyPressEventArgs e)
        {
            char input = char.ToLowerInvariant(e.KeyChar);
            int yMove = 0;
            int xMove = 0;
            //Collision
            if (!noclip) Collision(typeof(Wall));

            /////////// Movement
            // Right
            if (((input == 'd' || input == 'в') && !right_col) || input == '2')
            {
                xMove += 1;
                Console.WriteLine("D-key!");
            }
            // Left

            if (((input == 'a' || input == 'ф') && !left_col) || input == '1') 
            {
                xMove -= 1; ;
                Console.WriteLine("A-key!");
            }

            // Down
            if ((input == 's' || input == 'ы') && !down_col)
            {
                yMove += 1;
                Console.WriteLine("S-key!");
            }
            
            //Up
            if ((input == 'w' || input == 'ц') && !up_col)
            {
                yMove -= 1;
                Console.WriteLine("W-key!");
            }

            if (input == ' ' && !z_up_col)
            {
                Jump();
                Game.camera_z = z;
            }
            x += xMove;
            y += yMove;

            //////////////////////////////////other
            if (stamina < 1) stamina +=1 / 10;
            
        }

        public Player(int x, int y, int z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}

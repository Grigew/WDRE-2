using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    class Living : GameObject // Npc, player, enemy, etc.
    {
        //Settings
        public int speed = 3; // 
        public int jump_force = 1;
        public int attack_pwr = 10/100;
        public bool alive = true;

        // Collision indicators
        public bool z_up_col = false;
        public bool z_down_col = false;
        public bool up_col = false;
        public bool down_col = false;
        public bool left_col = false; // LEFT-COOOOOOOL (it is legendary commentary, 30.03.2023)
        public bool right_col = false;

        // Methods
        public void MoveTo(int toX, int toY)
        {

            // Collision
            Collision(typeof(Wall));

            // Movement
            if (toX < x && !left_col) --x; // Left
            if (toX > x && !right_col) ++x; // right
            if (toY > y && !down_col) ++y; // Down
            if (toY < y && !up_col) --y; // Up
            
            
        }
        
        public void Jump()
        {
            if (!z_down_col || z_up_col) return;
            for (int i = 0; i<jump_force; i++)
            {
                z++;
            }
        }

        public void Collision(Type obj_class)
        {

            z_up_col = false;
            z_down_col = false;
            up_col = false;
            down_col = false;
            left_col = false;
            right_col = false;

            for (int i = 0; i < Game.sbj.Count; i++)
            {
                var wall = Game.sbj[i];
                if (wall == null || (wall.GetType() != typeof(Wall) && wall.GetType() != typeof(Floor))) continue;

                //Console.WriteLine($"{wall} {wall.z} {wall.x} {wall.y}");

                if (wall.GetType() == typeof(Wall))
                {
                    // x and y collision
                    if (wall.Z == z)
                    {
                        // x-collision
                        if (wall.Y == y)
                        {
                            if (wall.X == x + 1) right_col = true; // Right
                            if (wall.X == x - 1 || x == 1) left_col = true; // Left
                        }

                        // y-collision
                        if (wall.X == x)
                        {
                            if (wall.Y == y + 1) down_col = true; // down
                            if (wall.Y == y - 1 || y == 1) up_col = true; // up

                            if (wall.Y == y)
                            {
                                up_col = true; // internal
                                right_col = true; // internal
                                down_col = true; // internal
                                left_col = true; // internal
                            } // internal collision
                        }
                    }

                    // z-collision*
                    else
                    {
                        if (wall.X == x && wall.Y == y)
                        {
                            if (wall.Z == z + 1) z_up_col = true;
                            if (wall.Z == z - 1) z_down_col = true;
                        }
                    }
                }
                else
                {
                    // z-collision*
                    if (wall.X == x && wall.Y == y)
                    {
                        if (wall.Z == z + 1) z_up_col = true;
                        if (wall.Z == z) z_down_col = true;
                    }
                }
            }
        }

        public void Speak(string text)
        {
            Console.WriteLine($"{this} speak: \"{text}\"");
        } 
        public void Live() // Creature's live while
        { 
            if (hp <= 0) { alive = false; }      
        } 
        public Living(int x, int y, int z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
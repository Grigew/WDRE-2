using System;
using System.Drawing;

namespace RFDW
{
    internal class GameObject2
    {
        #region Cosmetics

        public string? Name { get; set; }
        public virtual string? Sprite { get; set; } = "Error";

        #endregion
        #region Pos

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        #endregion
        #region Properties

        #region Physical

        public float Mass { get; protected set; } // Масса, кг
        public float Friction { get; protected set; } // Трение других обьектов об этот обьект
        public float Softness { get; protected set; } // Мягкость (влияет на подпрыгиваемость и энергию высвобождаемую при падении).
        public float Stickiness { get; protected set; } // Липкость 


        public bool[] CollisionSide { get; protected set; } = {
                                                            false,  // 0 Top (+Z)
                                                            false,  // 1 Bottom (-Z)
                                                            false,  // 2 Right Side (+X)
                                                            false,  // 3 Left Side (-X)
                                                            false,  // 4 Front (+Y)
                                                            false}; // 5 Back (-Y)
        /*What   ____
               /┌──┐/│     1 - front(+y)
                │1 │2│     2 - right(+x)
                └──┘/      ...                   
         */

        #endregion
        #region Velocity

        public float VelX { get; protected private set; }
        public float VelY { get; protected private set; }
        public float VelZ { get; protected private set; }

        #endregion
        #region Size

        public float Width { get; protected set; } = 1; // Ширина, m (x, row)
        public float Length { get; protected set; } = 1; // Длина, m (y, col)
        public float Height { get; protected set; } = 1; // Высота, m (z, depth)

        #endregion

        #endregion
        #region Stats

        public bool IsUndying { get; protected set; }
        public bool IsAlive { get; protected set; }
        public bool IsPhysical { get; protected set; }

        #endregion

        public static float friction = 0.01f;
        public GameObject2() 
        {
            Game2.AddToChunk(this);
        }
        public void Physic()
        {
            if (!this.IsPhysical) return;


            //SlowBy(Map.Air_resistance);
            //X
            if (Math.Abs(VelX) < Map.Air_resistance)
            {
                VelX = 0;
            }
            else
            {
                if (VelX > 0)
                {
                    VelX -= Map.Air_resistance;
                }
                else
                {
                    VelX += Map.Air_resistance;
                }
            }
            //Y
            if (Math.Abs(VelY) < Map.Air_resistance)
            {
                VelY = 0;
            }
            else
            {
                if (VelY > 0)
                {
                    VelY -= Map.Air_resistance;
                }
                else
                {
                    VelY += Map.Air_resistance;
                }
            }
            //Z
            if (Math.Abs(VelZ) < Map.Air_resistance)
            {
                VelZ = 0;
            }
            else
            {
                if (VelZ > 0)
                {
                    VelZ -= Map.Air_resistance;
                }
                else
                {
                    VelZ += Map.Air_resistance;
                }
            }
            //X
            if (Math.Abs(VelX) < friction)
            {
                VelX = 0;
            }
            else
            {
                if (VelX > 0)
                {
                    VelX -= friction;
                }
                else
                {
                    VelX += friction;
                }
            }
            //Y
            if (Math.Abs(VelY) < friction)
            {
                VelY = 0;
            }
            else
            {
                if (VelY > 0)
                {
                    VelY -= friction;
                }
                else
                {
                    VelY += friction;
                }
            }
            //Z
            if (Math.Abs(VelZ) < friction)
            {
                VelZ = 0;
            }
            else
            {
                if (VelZ > 0)
                {
                    VelZ -= friction;
                }
                else
                {
                    VelZ += friction;
                }
            }

            VelZ -= Map.Gravity;

            Y += VelY;
            X += VelX;
            Z += VelZ;

            // Collision
            // X
            if (CollisionSide[2]) { VelX = Softness; } // Right
            if (CollisionSide[3]) { VelX = -1 * Softness; } // Left
            // Y
            if (CollisionSide[4]) { VelY = -1 * Softness; } // Front
            if (CollisionSide[5]) { VelY = Softness; } // Back
            // Z
            if (CollisionSide[0]) { VelZ = -1 * Softness; } // Top
            if (CollisionSide[1]) { VelZ = Softness; } // Bottom

        }
        public void CollisionDetect(GameObject2 obj)
        {
            CollisionSide = new bool[] { 
                false,  // 0 Top (+Z)
                false,  // 1 Bottom (-Z)
                false,  // 2 Right Side (+X)
                false,  // 3 Left Side (-X)
                false,  // 4 Front (+Y)
                false}; // 5 Back (-Y)

            /* Рубрика "WHAT"
              
             1---|
             |   |       1 - this. X, Y
             |---2       2 - this. Widgth, Lenth
             
             {-------[-}--------]
             {  obj  [ }  this  ]   (this.x >= obj.Widgth) = true
             {-------[-}--------]
             
            */

            // X
            CollisionSide[2] = (this.X >= obj.X && this.X < obj.Width); // Right
            CollisionSide[3] = (this.X <= obj.X && this.X > obj.Width); // Left
            // Y
            CollisionSide[4] = (this.Y >= obj.Y && this.Y < obj.Width); // Front
            CollisionSide[5] = (this.Y <= obj.Y && this.Y > obj.Width); // Back
            // Z
            CollisionSide[0] = (this.Z >= obj.Z && this.Z < obj.Height); // Top
            CollisionSide[1] = (this.Z <= obj.Z && this.Z > obj.Height); // Bottom
        }
        public void SlowBy(float num)
        {
            //X
            if (Math.Abs(VelX) < num)
            {
                VelX = 0;
            }
            else
            {
                if (VelX > 0)
                {
                    VelX -= num;
                }
                else
                {
                    VelX += num;
                }
            }
            //Y
            if (Math.Abs(VelY) < num)
            {
                VelY = 0;
            }
            else
            {
                if (VelY > 0)
                {
                    VelY -= num;
                }
                else
                {
                    VelY += num;
                }
            }
            //Z
            if (Math.Abs(VelZ) < num)
            {
                VelZ = 0;
            }
            else
            {
                if (VelZ > 0)
                {
                    VelZ -= num;
                }
                else
                {
                    VelZ += num;
                }
            }
        }
    }
}

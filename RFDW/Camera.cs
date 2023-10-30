using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    public class Camera
    {
        
        public int DisplayWidth { get; protected set; }
        public int DisplayHeight { get; protected set; }

        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Z { get; protected set; } 

        public float ScaleFactor { get; set; }
        public int Speed { get; set; }

        public Camera()
        {
            DisplayWidth = 1000;
            DisplayHeight = 1000;
            ScaleFactor = 1.2f;
            Speed = 10;
        }
        public void Move(Object? sender, KeyEventArgs e)
        {
            

            Keys input = e.KeyCode;

            Keys right = Keys.D;
            Keys left = Keys.A;
            Keys up = Keys.W;
            Keys down = Keys.S;
            Keys downZ = Keys.Space;
            Keys upZ = Keys.ShiftKey;

            int xMove = 0;
            int yMove = 0;

            // Movement
            switch (input)
            {
                case Keys key when key == right: // Right
                    xMove += 1;
                    Console.WriteLine(right + "(right) was pressed!");
                    break;
                case Keys key when key == left: // Left
                    xMove -= 1;
                    Console.WriteLine(left + "(left) was pressed!");
                    break;
                case Keys key when key == up: // Up
                    yMove -= 1;
                    Console.WriteLine(up + "(up) was pressed!");
                    break;
                case Keys key when key == down: // Down
                    yMove += 1;
                    Console.WriteLine(down + "(down) was pressed!");
                    break;
            }
            X += Speed * xMove;
            Y += Speed * yMove;

        }
        public void Update(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.TranslateTransform(X, Y);
            g.ScaleTransform(ScaleFactor, ScaleFactor);
        }
    }
}

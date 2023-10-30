using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RFDW
{
    internal class Player2 : Living
    {
        public override string? Sprite { get; set; } = "@";
        
        DateTime lastTime;
        Keys lastInput = Keys.None;

        Keys right = Keys.D;
        Keys left = Keys.A;
        Keys up = Keys.W;
        Keys down = Keys.S;
        Keys downZ = Keys.Space;
        Keys upZ = Keys.ShiftKey;

        public void Move(Object? sender, KeyEventArgs e)
        {
            
            Keys input = e.KeyCode;
            
            TimeSpan timeSinceLastInput = DateTime.Now - lastTime;

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

            if ((lastInput != input) && (timeSinceLastInput.TotalSeconds < 0.01))
            {
                switch (lastInput)
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
            }

            if ((VelX >= 0 && xMove < 0)|| (VelX <= 0 && xMove > 0))
            {
                VelX += Speed * xMove;
            }

            if ((VelY >= 0 && yMove < 0) || (VelY <= 0 && yMove > 0))
            {
                VelY += Speed * yMove;
            }

            lastInput = input;
            lastTime = DateTime.Now;
        }
        public void MoveStop()
        {

            if ((VelX > 0) || (VelX < 0))
            {
                VelX += (Speed/2)* Math.Sign(VelX);
            }

            if ((VelY > 0) || (VelY < 0))
            {
                VelY += (Speed /2)* Math.Sign(VelY);
            }
        }
    }
}

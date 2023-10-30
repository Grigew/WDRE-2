using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFDW
{
    public partial class GameForm2 : Form
    {
        private Point targetPosition;
        Player2 player = new() { X = 1000, Y = 500 };
        Camera cam = new Camera();

        private DateTime lastTime;

        public GameForm2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            targetPosition = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

        }

        #region Form stuffs
        private void timer1_Tick(object sender, EventArgs e)
        {
            Interpolation(player);
            player.Physic();

            //Extrapolation(player);
            //Invalidate();


        }

        private void GameForm2_Paint(object sender, PaintEventArgs e)
        {
            //Interpolation(player);
            DrawObject(e, player);
            //RotateObject(e, player, 90, new PointF(0f, 0f));
            //cam.Update(e);


        }

        private void GameForm2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            targetPosition = me.Location;
        }
        private void GameForm2_KeyDown(object sender, KeyEventArgs e)
        {
            player.Move(sender, e);
            cam.Move(sender, e);
        }
        #endregion

        #region Drawing
        private void DrawObject(PaintEventArgs e, GameObject2 obj)
        {
            Graphics g = e.Graphics;
            string? text = obj.Sprite;
            Font font = new Font("Cascadia Code", 22);
            Brush brush = Brushes.Black;
            PointF point = new PointF(obj.X, obj.Y);

            g.DrawString(text, font, brush, point);
        }
        private void RotateObject(PaintEventArgs e, GameObject2 obj, float angle, PointF pivot)
        {
            Graphics g = e.Graphics;
            PointF point = new PointF(obj.X, obj.Y);

            g.TranslateTransform(pivot.X, pivot.Y);   // перемещаемся на нужную точку
            g.RotateTransform(angle);     // поворачиваем элемент
            g.TranslateTransform(-pivot.X, -pivot.Y); // возвращаемся назад

        }
        #endregion

        #region Linear Algorithms
        private void Extrapolation(GameObject2 obj)
        {
            // Рассчитываем время, прошедшее с последнего обновления
            TimeSpan timeSinceLastUpdate = DateTime.Now - lastTime;

            // Вычисляем новую позицию объекта с помощью экстраполяции
            obj.X = (float)(obj.X + obj.X * timeSinceLastUpdate.TotalSeconds);
            obj.Y = (float)(obj.Y + obj.Y * timeSinceLastUpdate.TotalSeconds);

            // Сохраняем текущее положение и время
            lastTime = DateTime.Now;
            Invalidate();
        }
        private void Interpolation(GameObject2 obj)
        {
            float speed = player.Speed;

            targetPosition = new Point(
                (int)Math.Round(obj.X + obj.VelX),
                (int)Math.Round(obj.Y + obj.VelY));

            obj.X += (int)((targetPosition.X - obj.X) * speed);
            obj.Y += (int)((targetPosition.Y - obj.Y) * speed);
            Invalidate();
        }
        #endregion


        private void GameForm2_KeyUp(object sender, KeyEventArgs e)
        {
            player.MoveStop();
        }
    }
}

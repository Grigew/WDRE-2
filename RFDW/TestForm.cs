using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RFDW
{
    public partial class TestForm : Form
    {
        System.Windows.Forms.TextBox textBox;
        System.Windows.Forms.Button button;
        public TestForm()
        {
            InitializeComponent();

            textBox = new System.Windows.Forms.TextBox { Parent = this, Text = "Some text" };
            button = new System.Windows.Forms.Button { Parent = this, Top = 30, Text = "Click" };
        }
        private void DrawEllipse(Rectangle rectangle, Color color, int width)
        {
            var path = new GraphicsPath();
            path.AddEllipse(rectangle);
            rectangle.Inflate(-width, -width);
            path.AddEllipse(rectangle);

            var panel = new Panel
            {
                Parent = this,
                BackColor = color,
                Region = new Region(path)
            };

            panel.BringToFront();
        }
        private void TestForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "rotatext";
            Font font = new Font("Arial", 16);
            Brush brush = Brushes.Black;
            PointF point = new PointF(50, 50);
            PointF pivot = new PointF(50, 50);

            g.TranslateTransform(pivot.X, pivot.Y);   // перемещаемся на нужную точку
            g.RotateTransform(50);     // поворачиваем элемент
            g.TranslateTransform(-pivot.X, -pivot.Y); // возвращаемся назад


            g.DrawString(text, font, brush, point);
        }
        private void DrawObject(PaintEventArgs e, GameObject2 obj)
        {
            Graphics g = e.Graphics;
            string text = "rotatext";
            Font font = new Font("Arial", 22);
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
    }
}

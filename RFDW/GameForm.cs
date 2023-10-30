using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFDW
{
    public partial class GameForm : Form
    {
        //static Player player = (Player)Game.sbj[Game.player_id];
        static Player2 testPlayer = new();
        //static Enemy enemy = (Enemy)Game.sbj[0, Game.enemy_id];
        Point lyr1;
        public GameForm()
        {
            InitializeComponent();
            Map.Build();
            //this.KeyPress += player.Move;
            this.MouseWheel += new MouseEventHandler(ZMouse);
            //enemy.MoveTo(player.x, player.y);
            this.KeyDown += testPlayer.Move;

        }
        public void ZMouse(object? sender, MouseEventArgs e)
        {
            if (e.Delta <= 0 && Game.camera_z < Map.Map1.GetUpperBound(0))
                Game.camera_z++;
            if (e.Delta > 0 && Game.camera_z > Map.Map1.GetLowerBound(0))
                Game.camera_z--;
        }

        public void Rndr()
        {

            //textBox1.Text = Map.Render().Item1;
            //textBox2.Text = Map.Render().Item2;
            //plr_lbl.Location = new Point((int)Math.Round(testPlayer.X), (int)Math.Round(testPlayer.Y));

            //labelHp.Text = Math.Round(testPlayer.X) + "x " + Math.Round(testPlayer.Y) + "y " + Math.Round(testPlayer.Z) + "z " + Math.Round(testPlayer.VelZ) + "velz " + Math.Round(testPlayer.VelY) + "velY " + testPlayer.VelX + "velX " + Game.camera_z + "camera z";
            //textBox1.Refresh();
            //RenderText8 += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

        private void rndr_tmr_Tick(object sender, EventArgs e)
        {
            Rndr();
        }

        private void physics_update_timer_Tick(object sender, EventArgs e)
        {
            testPlayer.Physic();
        }
        private void RenderText8(PaintEventArgs e)
        {
            TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, "This is some text that will display on multiple lines.", this.Font,
            new Rectangle(10, 10, 100, 50), SystemColors.ControlText, SystemColors.ControlDark, flags);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

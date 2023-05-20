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
        int physic = 0;
        static Player player = (Player)Game.sbj[Game.player_id];
        //static Enemy enemy = (Enemy)Game.sbj[0, Game.enemy_id];
        Point lyr1;
        public GameForm()
        {
            InitializeComponent();
            Map.Build();
            this.KeyPress += player.Move;
            this.MouseWheel += new MouseEventHandler(ZMouse);
            //enemy.MoveTo(player.x, player.y);
            
        }
        public void ZMouse(object? sender, MouseEventArgs e)
        {
            if (e.Delta <= 0 && Game.camera_z < Map.map1.GetUpperBound(0))
                Game.camera_z++;
            if (e.Delta > 0 && Game.camera_z > Map.map1.GetLowerBound(0))
                Game.camera_z--;
        }

        public void Rndr()
        {

            textBox1.Text = Map.Render().Item1;
            textBox2.Text = Map.Render().Item2;

            labelHp.Text = player.X + "x " + player.Y + "y " + player.Z + "z " + Game.camera_z + "camera z";

            //textBox1.Refresh();
        }

        private void rndr_tmr_Tick(object sender, EventArgs e)
        {
            Rndr();
            physic++;
            if (physic % 50 == 1)
            {
                player.Collision(typeof(Wall));
                //if (!player.z_down_col) player.z--;
            }

        }

    }
}

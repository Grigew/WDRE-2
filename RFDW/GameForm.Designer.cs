using System.Threading.Channels;

namespace RFDW
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelHp = new Label();
            render_update_timer = new System.Windows.Forms.Timer(components);
            buttonNoclip = new Button();
            layer2 = new Label();
            layer3 = new Label();
            layer4 = new Label();
            layer5 = new Label();
            layer6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            physics_update_timer = new System.Windows.Forms.Timer(components);
            plr_lbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelHp
            // 
            labelHp.AutoSize = true;
            labelHp.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelHp.ForeColor = Color.Firebrick;
            labelHp.Location = new Point(12, 9);
            labelHp.Name = "labelHp";
            labelHp.Size = new Size(84, 32);
            labelHp.TabIndex = 3;
            labelHp.Text = "♥♥♥♥♥";
            // 
            // render_update_timer
            // 
            render_update_timer.Enabled = true;
            render_update_timer.Interval = 10;
            render_update_timer.Tick += rndr_tmr_Tick;
            // 
            // buttonNoclip
            // 
            buttonNoclip.Font = new Font("Cascadia Code", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            buttonNoclip.ForeColor = Color.Black;
            buttonNoclip.Location = new Point(987, 12);
            buttonNoclip.Name = "buttonNoclip";
            buttonNoclip.Size = new Size(120, 35);
            buttonNoclip.TabIndex = 5;
            buttonNoclip.Text = "NOCLIP!!!";
            buttonNoclip.UseVisualStyleBackColor = true;
            // 
            // layer2
            // 
            layer2.AutoSize = true;
            layer2.BackColor = Color.Transparent;
            layer2.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point);
            layer2.ForeColor = Color.WhiteSmoke;
            layer2.Location = new Point(978, 311);
            layer2.Name = "layer2";
            layer2.Size = new Size(111, 35);
            layer2.TabIndex = 6;
            layer2.Text = "label2";
            // 
            // layer3
            // 
            layer3.AutoSize = true;
            layer3.BackColor = Color.Transparent;
            layer3.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point);
            layer3.ForeColor = Color.WhiteSmoke;
            layer3.Location = new Point(978, 346);
            layer3.Name = "layer3";
            layer3.Size = new Size(111, 35);
            layer3.TabIndex = 7;
            layer3.Text = "layer3";
            // 
            // layer4
            // 
            layer4.AutoSize = true;
            layer4.BackColor = Color.Transparent;
            layer4.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point);
            layer4.ForeColor = Color.WhiteSmoke;
            layer4.Location = new Point(978, 387);
            layer4.Name = "layer4";
            layer4.Size = new Size(111, 35);
            layer4.TabIndex = 8;
            layer4.Text = "layer4";
            // 
            // layer5
            // 
            layer5.AutoSize = true;
            layer5.BackColor = Color.Transparent;
            layer5.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point);
            layer5.ForeColor = Color.WhiteSmoke;
            layer5.Location = new Point(978, 437);
            layer5.Name = "layer5";
            layer5.Size = new Size(111, 35);
            layer5.TabIndex = 9;
            layer5.Text = "layer5";
            // 
            // layer6
            // 
            layer6.AutoSize = true;
            layer6.BackColor = Color.Transparent;
            layer6.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Point);
            layer6.ForeColor = Color.WhiteSmoke;
            layer6.Location = new Point(978, 478);
            layer6.Name = "layer6";
            layer6.Size = new Size(111, 35);
            layer6.TabIndex = 10;
            layer6.Text = "layer6";
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Cascadia Code Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(673, 245);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(256, 245);
            textBox1.TabIndex = 11;
            textBox1.Text = "Game!";
            textBox1.UseSystemPasswordChar = true;
            textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.AcceptsTab = true;
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Cascadia Code Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.Location = new Point(397, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(256, 245);
            textBox2.TabIndex = 12;
            textBox2.Text = "Game!";
            textBox2.UseSystemPasswordChar = true;
            textBox2.WordWrap = false;
            // 
            // physics_update_timer
            // 
            physics_update_timer.Enabled = true;
            physics_update_timer.Interval = 1;
            physics_update_timer.Tick += physics_update_timer_Tick;
            // 
            // plr_lbl
            // 
            plr_lbl.AutoSize = true;
            plr_lbl.Location = new Point(299, 245);
            plr_lbl.Name = "plr_lbl";
            plr_lbl.Size = new Size(38, 15);
            plr_lbl.TabIndex = 13;
            plr_lbl.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(314, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1119, 552);
            Controls.Add(pictureBox1);
            Controls.Add(plr_lbl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(layer6);
            Controls.Add(layer5);
            Controls.Add(layer4);
            Controls.Add(layer3);
            Controls.Add(layer2);
            Controls.Add(buttonNoclip);
            Controls.Add(labelHp);
            DoubleBuffered = true;
            ForeColor = Color.White;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelHp;
        private System.Windows.Forms.Timer render_update_timer;
        private Button buttonNoclip;
        private Label layer2;
        private Label layer3;
        private Label layer4;
        private Label layer5;
        private Label layer6;
        private TextBox textBox1;
        private TextBox textBox2;
        private System.Windows.Forms.Timer physics_update_timer;
        private Label plr_lbl;
        private PictureBox pictureBox1;
    }
}
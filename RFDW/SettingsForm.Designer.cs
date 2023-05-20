namespace RFDW
{
    partial class SettingsForm
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
            buttonVideo = new Button();
            buttonGame = new Button();
            buttonOther = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // buttonVideo
            // 
            buttonVideo.BackColor = Color.Transparent;
            buttonVideo.FlatStyle = FlatStyle.Flat;
            buttonVideo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVideo.ForeColor = Color.White;
            buttonVideo.Location = new Point(166, 12);
            buttonVideo.Name = "buttonVideo";
            buttonVideo.Size = new Size(148, 40);
            buttonVideo.TabIndex = 1;
            buttonVideo.Text = "Видео";
            buttonVideo.UseVisualStyleBackColor = false;
            // 
            // buttonGame
            // 
            buttonGame.BackColor = Color.Transparent;
            buttonGame.FlatStyle = FlatStyle.Flat;
            buttonGame.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGame.ForeColor = Color.White;
            buttonGame.Location = new Point(12, 12);
            buttonGame.Name = "buttonGame";
            buttonGame.Size = new Size(148, 40);
            buttonGame.TabIndex = 2;
            buttonGame.Text = "Игра";
            buttonGame.UseVisualStyleBackColor = false;
            // 
            // buttonOther
            // 
            buttonOther.BackColor = Color.Transparent;
            buttonOther.FlatStyle = FlatStyle.Flat;
            buttonOther.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOther.ForeColor = Color.White;
            buttonOther.Location = new Point(320, 12);
            buttonOther.Name = "buttonOther";
            buttonOther.Size = new Size(148, 40);
            buttonOther.TabIndex = 3;
            buttonOther.Text = "Другое";
            buttonOther.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Cascadia Mono", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(12, 144);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 33);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Font = new Font("Cascadia Mono", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(12, 191);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(148, 33);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Font = new Font("Cascadia Mono", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(12, 238);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(148, 33);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Font = new Font("Cascadia Mono", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(12, 285);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(148, 33);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(483, 435);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(buttonOther);
            Controls.Add(buttonGame);
            Controls.Add(buttonVideo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            Text = "Настройки";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVideo;
        private Button buttonGame;
        private Button buttonOther;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
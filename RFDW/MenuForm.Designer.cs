namespace RFDW
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            buttonStart = new Button();
            buttonSettings = new Button();
            buttonCredits = new Button();
            buttonExit = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            buttonConsole = new Button();
            buttonEditor = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Left;
            buttonStart.BackColor = Color.Transparent;
            buttonStart.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatAppearance.CheckedBackColor = Color.RoyalBlue;
            buttonStart.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonStart.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Cascadia Mono Light", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(12, 397);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(225, 45);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Начать игру";
            buttonStart.TextAlign = ContentAlignment.MiddleLeft;
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Left;
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.CheckedBackColor = Color.RoyalBlue;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Cascadia Mono Light", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.WhiteSmoke;
            buttonSettings.Location = new Point(12, 499);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(225, 45);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "Настройки";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonCredits
            // 
            buttonCredits.Anchor = AnchorStyles.Left;
            buttonCredits.BackColor = Color.Transparent;
            buttonCredits.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonCredits.FlatAppearance.BorderSize = 0;
            buttonCredits.FlatAppearance.CheckedBackColor = Color.RoyalBlue;
            buttonCredits.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonCredits.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonCredits.FlatStyle = FlatStyle.Flat;
            buttonCredits.Font = new Font("Cascadia Mono Light", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCredits.ForeColor = Color.WhiteSmoke;
            buttonCredits.Location = new Point(12, 554);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(225, 45);
            buttonCredits.TabIndex = 2;
            buttonCredits.Text = "Информация";
            buttonCredits.TextAlign = ContentAlignment.MiddleLeft;
            buttonCredits.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Left;
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatAppearance.CheckedBackColor = Color.RoyalBlue;
            buttonExit.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonExit.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Cascadia Mono Light", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.WhiteSmoke;
            buttonExit.Location = new Point(12, 609);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(225, 45);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.TextAlign = ContentAlignment.MiddleLeft;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonQuit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(1329, 639);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 5;
            label2.Text = "v-0.04 alpha";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Mono SemiBold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 217);
            label3.Name = "label3";
            label3.Size = new Size(225, 57);
            label3.TabIndex = 6;
            label3.Text = "Left-Col\r\n";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(325, 21);
            label1.TabIndex = 7;
            label1.Text = "Reference to fear and hope for dawn";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonConsole
            // 
            buttonConsole.BackColor = Color.DimGray;
            buttonConsole.FlatStyle = FlatStyle.Flat;
            buttonConsole.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsole.Location = new Point(12, 12);
            buttonConsole.Name = "buttonConsole";
            buttonConsole.Size = new Size(44, 44);
            buttonConsole.TabIndex = 9;
            buttonConsole.Text = "</>";
            buttonConsole.TextAlign = ContentAlignment.MiddleRight;
            buttonConsole.UseVisualStyleBackColor = false;
            buttonConsole.Click += buttonConsole_Click;
            // 
            // buttonEditor
            // 
            buttonEditor.Anchor = AnchorStyles.Left;
            buttonEditor.BackColor = Color.Transparent;
            buttonEditor.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonEditor.FlatAppearance.BorderSize = 0;
            buttonEditor.FlatAppearance.CheckedBackColor = Color.RoyalBlue;
            buttonEditor.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonEditor.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonEditor.FlatStyle = FlatStyle.Flat;
            buttonEditor.Font = new Font("Cascadia Mono Light", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditor.ForeColor = Color.WhiteSmoke;
            buttonEditor.Location = new Point(12, 448);
            buttonEditor.Name = "buttonEditor";
            buttonEditor.Size = new Size(225, 45);
            buttonEditor.TabIndex = 11;
            buttonEditor.Text = "Редактор карт";
            buttonEditor.TextAlign = ContentAlignment.MiddleLeft;
            buttonEditor.UseVisualStyleBackColor = false;
            buttonEditor.Click += buttonEditor_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1434, 666);
            Controls.Add(buttonEditor);
            Controls.Add(buttonConsole);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonExit);
            Controls.Add(buttonCredits);
            Controls.Add(buttonSettings);
            Controls.Add(buttonStart);
            DoubleBuffered = true;
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonSettings;
        private Button buttonCredits;
        private Button buttonExit;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button buttonConsole;
        private Button buttonEditor;
    }
}
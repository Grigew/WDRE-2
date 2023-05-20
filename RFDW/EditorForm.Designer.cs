namespace RFDW
{
    partial class EditorForm
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            update = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(894, 515);
            numericUpDown1.Margin = new Padding(5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 21);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(894, 494);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 3;
            label1.Text = "Z-уровень";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 12;
            dataGridView1.Size = new Size(874, 527);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // update
            // 
            update.Interval = 300;
            update.Tick += update_Tick;
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(976, 550);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "EditorForm";
            Text = "Map editor";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer update;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RFDW
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
            build();
            //dataGridView1.DataSource = Map.map1;
        }
        public void edtr()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    Map.Map1[(int)numericUpDown1.Value, i, j] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
        }

        public void build()
        {
            int z = (int)numericUpDown1.Value;

            DataTable table = new DataTable();
            for (int k = 0; k < Map.Map1.GetLength(2); k++)
            {
                table.Rows.Add(Convert.ToString(k));
            }

            for (int j = 0; j < Map.Map1.GetLength(1); j++)
            {
                table.Columns.Add(Convert.ToString(j));
                Console.WriteLine("Col {0}", j);
                
                for (int k = 0; k < Map.Map1.GetLength(2); k++)
                {
                    
                    DataRow row = table.Rows[j];

                    row[k] = Map.Map1[z, j, k];

                    Console.WriteLine("Row {0} {1}", j, k);
                }
            }

            dataGridView1.DataSource = table;
        }

        private void update_Tick(object sender, EventArgs e)
        {
            edtr();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0) numericUpDown1.Value = 1;
            else if (numericUpDown1.Value > Map.Map1.GetLength(0)-1) numericUpDown1.Value = Map.Map1.GetLength(0)-1;
            else build();
        }
    }
}

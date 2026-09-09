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

namespace lab1
{
    public partial class Form_twodimen_array : Form
    {

        findDuplicate fd = new findDuplicate();

        public Form_twodimen_array()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_rows_Click(object sender, EventArgs e)
        {
        }

        private void Form_twodimen_array_Load(object sender, EventArgs e)
        {

        }

        private void button_draw_matrix_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            fd.Rows = int.Parse(textBox_rows.Text);
            fd.Cols = int.Parse(textBox_cols.Text);

            fd.generateRandomArray();

            dataGridView1.ColumnCount = fd.Cols;
            dataGridView1.RowCount = fd.Rows;
            for (int i = 0; i < fd.Rows; i++)
            {
                for (int j = 0; j < fd.Cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = fd.array[i, j];
                }
            }
            label_result.Text = "";
        }

        private void textBox_rows_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_find_duplicate_Click(object sender, EventArgs e)
        {
            var (index00, index01, index10, index11) = fd.findDuplicateInArray();
            dataGridView1.Rows[index00].Cells[index01].Style.BackColor = Color.Red;
            dataGridView1.Rows[index10].Cells[index11].Style.BackColor = Color.Red;
            label_result.Text = $"Дублікати знайдено: ({index00}, {index01}) та ({index10}, {index11})";
        }
    }
}

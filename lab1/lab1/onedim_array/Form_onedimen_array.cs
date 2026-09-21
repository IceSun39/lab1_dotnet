using lab1.lab1.onedim_array;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form_onedimen_array : Form
    {
        public Form_onedimen_array()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            CalcFreeDrop calc = new CalcFreeDrop();
            int t = 0;

            t = Convert.ToInt32(textBox_time.Text);
            if (t <= 0)
            {
                MessageBox.Show("Час має бути додатнім числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calc.Calculate(t);

            for (int i = 0; i < calc.n; i++)
            {
                dataGridView1.Rows.Add(
                    i + 1,
                    Math.Round(calc.distances[i], 2)
                    );
            }

        }

        private void Form_onedimen_array_Load(object sender, EventArgs e)
        {

        }
    }
}

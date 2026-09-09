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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.Winforms
{
    public partial class Edit_carte : Form
    {
        public Edit_carte()
        {
            InitializeComponent();
        }

        private void ecoleajout_Click(object sender, EventArgs e)
        {
            ECOLE edit = new ECOLE();
            edit.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ecolemodif_Click(object sender, EventArgs e)
        {
            ECOLE edit = new ECOLE();
            edit.Show();
        }

        private void ecolsupprim_Click(object sender, EventArgs e)
        {
            PARENT edit = new PARENT();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ECOLE edit = new ECOLE();
            edit.Show();
        }
    }
}

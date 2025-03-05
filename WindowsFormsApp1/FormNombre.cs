using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNombre : Form
    {
        public FormNombre()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            buttonMostrar.Text = txtNombre.Text == string.Empty ? 
                buttonMostrar.Text : txtNombre.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = listBox1.Text;
        }

        private void Submit1_Click(object sender, EventArgs e)
        {
            FormBoostrap formBoostrap = new FormBoostrap();
            Hide();
            formBoostrap.ShowDialog();
            Show();
        }
    }
}

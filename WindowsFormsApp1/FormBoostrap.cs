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
    public partial class FormBoostrap : Form
    {
        public FormBoostrap()
        {
            InitializeComponent();
        }

        private void FormBoostrap_Load(object sender, EventArgs e)
        {
            comboLocation.SelectedIndex = 0;
            comboCriticity.SelectedIndex = 0;
            comboPercent.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;  
            ComboType.SelectedIndex = 0;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSubmit_Click(object sender, EventArgs e)
        {
            string text = $@"Title: {TxtTitle.Text}
location: {comboLocation.Text}
type: {ComboType.Text}
criticity: {comboCriticity.Text}
description: 
[{TxtDescription.Text}]
";

            if (checkBoxProd.Checked)
                text += checkBoxProd.Text + "\n";
            if (checkBoxPreprod.Checked)
                text += checkBoxPreprod.Text + "\n";
            if (checkBoxDemo.Checked)
                text += checkBoxDemo.Text + "\n";

            text += $@"{dateTimePicker.Text}
Duration {DurationInHours.Value}
Status: {comboStatus.Text}
Percent complete: {comboPercent.Text}";

            MessageBox.Show(text);
                
        }
    }
}

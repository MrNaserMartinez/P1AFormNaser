using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AFormNaser.Formularios
{
    public partial class FMRIngreso : Form
    {
        public FMRIngreso()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {

            facu.Items.Add("Ingeneieria");
            facu.Items.Add("Medicina");
            facu.Items.Add("Derecho");

        }

        private void facu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(facu.SelectedItem.ToString());
        }

        private void bsuma_Click(object sender, EventArgs e)
        {

            int n1 = Convert.ToInt32(txt1.Text);
            int n2 = Convert.ToInt32(txt2.Text);
            resultado.Text = (n1 + n2).ToString();
        }
    }
}

using P1AFormNaser.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P1AFormNaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mi guapo");
        }

        private void ingreso_Click(object sender, EventArgs e)
        {
            if (textBoxusr.Text.ToUpper().Equals("ADMIN") && textBoxpassword.Text.ToUpper().Equals("ADMIN"))
            {
                FMRIngreso froma = new FMRIngreso();
                froma.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrase;a incorrecta");
                textBoxusr.Clear();
                textBoxpassword.Clear();
            }
        }

        private void textBoxusr_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

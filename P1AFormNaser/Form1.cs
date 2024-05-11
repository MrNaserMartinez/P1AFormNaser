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

        private int intentosFallidos = 0;
        private const int maximoIntentos = 3;

        private void ingreso_Click(object sender, EventArgs e)
        {
            if (textBoxusr.Text.ToUpper().Equals("ADMIN") && textBoxpassword.Text.ToUpper().Equals("ADMIN"))
            {
                FMRIngreso froma = new FMRIngreso();
                froma.Show();
            }
            else
            {
                intentosFallidos++;

                // Verificar si se alcanzó el límite de intentos fallidos
                if (intentosFallidos >= maximoIntentos)
                {
                    MessageBox.Show("Has excedido el número máximo de intentos fallidos. El botón de ingreso será desactivado.");
                    ingreso.Enabled = false; // Desactivar el botón
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    textBoxusr.Clear();
                    textBoxpassword.Clear();
                }
            }
        }

        private void textBoxusr_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_2._0
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(txtNomb.Text == "juancho" && txtContra.Text == "123tamarindo")
            {
                MessageBox.Show("Se ha inciado sesión correctamente. ");
            }
            else
            {
                MessageBox.Show("Error en el Nombre de usuario o contraseña. INTENTA DE NUEVO. ");

                txtNomb.Text = "";
                txtContra.Text = "";
                txtNomb.Focus();
            }
        }
    }
}

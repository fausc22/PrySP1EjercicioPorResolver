using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1EjercicioPorResolver
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" &&
                txtContrasenia.Text == "@1a") ||
                (txtUsuario.Text == "John" &&
                txtContrasenia.Text == "*2b") ||
                (txtUsuario.Text == "Ceci" &&
                txtContrasenia.Text == "*@3c") ||
                (txtUsuario.Text == "God" &&
                txtContrasenia.Text == "*@#4d") )
                
                {
                this.Hide();
                frmInicio f = new frmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
                

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");
                intentos++;
                if(intentos == 2)
                {
                    this.Close();
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" &&
                 txtContrasenia.Text == "@1a") ||
                 (txtUsuario.Text == "John" &&
                 txtContrasenia.Text == "*2b") ||
                 (txtUsuario.Text == "Ceci" &&
                 txtContrasenia.Text == "*@3c") ||
                 (txtUsuario.Text == "God" &&
                 txtContrasenia.Text == "*@#4d"))
            {
                LstModulo.Enabled = true;
            }
            else
            {
                LstModulo.Enabled = false;

            }
        }
    }
}


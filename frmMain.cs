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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // declaro variable intentos 
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //primer usuario
            if (txtUsuario.Text == "Adm" && txtContrasenia.Text == "@1a")
            {
                if (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA")
                {
                    MessageBox.Show("Bienvenido");

                }

                

            }
            else
            {   //segundo usuario
                if (txtUsuario.Text == "John" && txtContrasenia.Text == "*2b")
                {
                    if (LstModulo.Text == "SIST")
                    {
                        MessageBox.Show("Bienvenido");
                    }
                    

                }
                else
                {   //tercer usuario
                    if (txtUsuario.Text == "Ceci" && txtContrasenia.Text == "*@3c")
                    {
                        if (LstModulo.Text == "ADM" || LstModulo.Text == "VTA")
                        {
                            MessageBox.Show("Bienvenido");

                        }
                        

                    }
                    else
                    {   //cuarto usuario
                        if (txtUsuario.Text == "God" && txtContrasenia.Text == "*@#4d")
                        {
                            if (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA" || LstModulo.Text == "SIST")
                            {
                                MessageBox.Show("Bienvenido");

                            }

                            
                        }
                        else
                        {
                            intentos++; //va sumando los intentos
                            MessageBox.Show("Usuario y/o contraseña incorrecta. Acceso denegado");
                            if (intentos == 2) // si es mas de 2 cierra el formulario
                            {
                                this.Close();
                            }


                        }
                    }
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
            if (LstModulo.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if(txtContrasenia.Text != "")
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


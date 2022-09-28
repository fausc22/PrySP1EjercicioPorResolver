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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            this.Hide(); //oculta el formulario
            frmMain f = new frmMain(); //crea el formulario
            f.Text = lblLogo.Text;
            f.ShowDialog(); //visualiza y ejecuta el formulario nuevo
            this.Show(); //visualiza nuevamente
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQatarPAVI.LogicaNegocio;

namespace TPQatarPAVI.Presentación
{
    public partial class LoginForm : Form
    {
        Usuario usr;
        Usuario usrCorrecto;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usr = new Usuario(txtUsr.Text, txtPrfl.Text);

            usrCorrecto = new Usuario("Ramiro", "Tester");

            if (usr.nombreUsuario.Equals(usrCorrecto.nombreUsuario) && usr.perfilUsuario.Equals(usrCorrecto.perfilUsuario))
            {
                MessageBox.Show("Datos correctos");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}

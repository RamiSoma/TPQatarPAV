using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQatarPAVI.CapaServicios;
using TPQatarPAVI.LogicaNegocio;

namespace TPQatarPAVI.Presentación
{
    public partial class LoginForm : Form
    {
        UsuarioService gestorUsr = new UsuarioService();
        Usuario usr = new Usuario();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text == null || txtPswd.Text == null)
            {
                MessageBox.Show("Debe continuar todos los campos para continuar");
                return;
            }
            this.usr.nombreUsu = txtUsr.Text;
            this.usr.pswdUsu = txtPswd.Text;

            this.usr.idUsu = this.gestorUsr.encontrarUsuario(usr);

            if (this.usr.idUsu != 0)
            {
                // MessageBox.Show("Ingreso satisfactorio");
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
                txtUsr.Text = "";
                txtPswd.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

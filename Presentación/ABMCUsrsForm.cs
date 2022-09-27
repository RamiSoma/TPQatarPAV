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

namespace TPQatarPAVI.Presentación
{
    public partial class ABMCUsrsForm : Form
    {
        PerfilService prfl = new PerfilService();
        UsuarioService usr = new UsuarioService();
        enum Modo
        {
            Alta,
            Modificacion
        }
        Modo modo;
        public ABMCUsrsForm()
        {
            InitializeComponent();
            txtMail.Visible = false;
        }
        private void ABMCUsrsForm_Load(object sender, EventArgs e)
        {
           
            CargarCombo(cmbBoxPrfls, prfl.traerTodos());
            CargarCombo(cmbFiltroPerfil, prfl.traerTodos()); 
            HabilitarEdicion(false);
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["mail"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["rol"],
                                tabla.Rows[i]["contraseña"]);
            }
        }
        private void HabilitarEdicion(bool v)
        {
            lblId.Visible = v;
            txtUsuario.Visible = v;
            lblUsuario.Visible = v;
            txtPswd.Visible = v;
            lblPswd.Visible = v;
            btnGuardar.Visible = v;
            btnCancelar.Visible = v;
            lblPrfl.Visible = v;
            cmbBoxPrfls.Visible = v;
            lblIdUsr.Visible = v;
            txtApellido.Visible = v;
            lblApellido.Visible = v; 
            lblNombre.Visible = v;
            txtNombre.Visible = v;
            lblMail.Visible = v;
            lblMailFijo.Visible = v;



        }
        private void CargarUsr()
        {
            lblId.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[0].Value);
            txtNombre.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[1].Value);
            txtApellido.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[2].Value);
            lblMail.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[3].Value);
            txtUsuario.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[4].Value);
            txtPswd.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[6].Value);
            cmbBoxPrfls.Text = Convert.ToString(dGridUsrs.SelectedRows[0].Cells[5].Value);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" ||txtPswd.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarEdicion(false);
                if (modo == Modo.Alta)
                {
                    usr.crearUsr(txtNombre.Text, txtApellido.Text,txtMail.Text, txtUsuario.Text, txtPswd.Text, cmbBoxPrfls.Text);
                    txtMail.Visible = false;
                }
                if (modo == Modo.Modificacion)
                {
                    usr.modificarUsr(lblId.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtPswd.Text, cmbBoxPrfls.Text);
                }
                CargarGrilla(dGridUsrs, usr.traerTodos(txtFiltroNombre.Text, cmbFiltroPerfil.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            CargarUsr();
            modo = Modo.Modificacion;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            cmbBoxPrfls.SelectedIndex = 0;
            txtUsuario.Text = "";
            txtPswd.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            lblId.Text = "*";
            txtMail.Visible = true;
            txtMail.Text = "";
            modo = Modo.Alta;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int idUsr = Convert.ToInt32(dGridUsrs.SelectedRows[0].Cells[0].Value);   
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el usuario seleccionado?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                usr.eliminarUsr(idUsr);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(dGridUsrs, usr.traerTodos(txtFiltroNombre.Text, cmbFiltroPerfil.Text) );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}

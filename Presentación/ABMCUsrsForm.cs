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
        public ABMCUsrsForm()
        {
            InitializeComponent();
        }
        private void ABMCUsrsForm_Load(object sender, EventArgs e)
        {
           
            CargarCombo(cmbBoxPrfls, prfl.traerTodos());
            CargarGrilla(dGridUsrs, usr.traerTodos());
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
                                tabla.Rows[i]["rol"]);
            }
        }
        private void HabilitarEdicion(bool v)
        {
            txtNombre.Enabled = v;
            txtPswd.Enabled = v;
            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;
            cmbBoxPrfls.Enabled = v;
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(false);
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
            txtNombre.Text = "";
            cmbBoxPrfls.Text = "";
            txtPswd.Text = "";
        }
    }
}

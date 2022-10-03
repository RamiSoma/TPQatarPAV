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
    public partial class ABMCPartForm : Form
    {
        RondaService rnd = new RondaService();
        GrupoService grupo = new GrupoService();
        PaisService pais = new PaisService();
        public ABMCPartForm()
        {
            InitializeComponent();
            CargarCombo(cmbRonda, rnd.traerTodos());
            CargarCombo(cmbFiltroRonda, rnd.traerTodos());
            CargarCombo(cmbGrupo, grupo.traerTodos());
            CargarCombo(cmbPaisLocal, pais.traerTodos("",""));
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABMCPartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbGrupo.Visible = true;
            lblTxtGrupo.Visible = true;
        }

        private void cmbRonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRonda.Text == "Fase de Grupo")
            {
                cmbGrupo.Visible = true;
                lblTxtGrupo.Visible = true;
            }
            else
            {
                cmbGrupo.Visible = false;
                lblTxtGrupo.Visible = false;
            };
        }
    }
}

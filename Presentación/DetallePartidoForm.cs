using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQatarPAVI.Presentación
{
    public partial class DetallePartidoForm : Form
    {
        public string idPartido;
        public DetallePartidoForm()
        {
            InitializeComponent();
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_partido"],
                                tabla.Rows[i]["minuto"],
                                tabla.Rows[i]["tipo_doc_jg"],
                                tabla.Rows[i]["nro_doc_jg"],
                                tabla.Rows[i]["evento"]);
            }
        }

        private void DetallePartidoForm_Load(object sender, EventArgs e)
        {
            lblMostrarId.Text = idPartido;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

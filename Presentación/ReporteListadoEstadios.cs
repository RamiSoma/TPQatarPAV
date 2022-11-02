using Microsoft.Reporting.WinForms;
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
    public partial class ReporteListadoEstadios : Form
    {
        DataTable tablaEstadios;
        ReportDataSource ds;
        EstadioService est = new EstadioService();

        public ReporteListadoEstadios()
        {
            InitializeComponent();
        }
        private void CargarComboOrden()
        {
            cmbBoxOrden.Items.Add("Ascendente");
            cmbBoxOrden.Items.Add("Descendente");
            cmbBoxOrden.SelectedIndex = 0;
        }
        private void ReporteListadoEstadios_Load(object sender, EventArgs e)
        {
            CargarComboOrden();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            bool esAsc = cmbBoxOrden.Text == "Ascendente";
            tablaEstadios = est.traerPartidosPorEstadio(esAsc);
            ds = new ReportDataSource("DatosEstadio", tablaEstadios);

            reportEstadios.LocalReport.DataSources.Clear();
            reportEstadios.LocalReport.DataSources.Add(ds);
            reportEstadios.RefreshReport();
        }

        private void cmbBoxOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

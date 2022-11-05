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
    public partial class ReporteListadoArbitros : Form
    {
        ReportDataSource ds;
        DataTable tablaArbs = new DataTable();
        ArbitroService arb = new ArbitroService();
        public ReporteListadoArbitros()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void CargarComboEstadisticas()
        {
            cmbEstadisticas.Items.Add("Tarjeta Amarilla");
            cmbEstadisticas.Items.Add("Tarjeta Roja");
            cmbEstadisticas.SelectedIndex = 0;
        }
        private void CargarComboOrden()
        {
            cmbBoxOrden.Items.Add("Ascendente");
            cmbBoxOrden.Items.Add("Descendente");
            cmbBoxOrden.SelectedIndex = 1;
        }
        private void ReporteListadoArbitros_Load(object sender, EventArgs e)
        {
            CargarComboOrden();
            CargarComboEstadisticas();
            this.reportArbs.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            bool esTarjAmarilla = cmbEstadisticas.Text == "Tarjeta Amarilla";
            bool esAsc = cmbBoxOrden.Text == "Ascendente";
            tablaArbs = arb.filtrarPorCantEventos(esTarjAmarilla, esAsc);
            ds = new ReportDataSource("DatosArbitro", tablaArbs);

            reportArbs.LocalReport.SetParameters(new ReportParameter("tarjeta", cmbEstadisticas.Text));
            reportArbs.LocalReport.DataSources.Clear();
            reportArbs.LocalReport.DataSources.Add(ds);
            reportArbs.RefreshReport();
        }

        private void reportAbs_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ReporteListadoPaises : Form
    {
        DataTable tablaPais = new DataTable();
        ReportDataSource ds;
        JugadorService jug = new JugadorService();
        public ReporteListadoPaises()
        {
            InitializeComponent();
        }
        private void CargarComboOrden()
        {
            cmbBoxOrden.Items.Add("Ascendente");
            cmbBoxOrden.Items.Add("Descendente");
            cmbBoxOrden.SelectedIndex = 1;
        }
        private void CargarComboEstadisticas()
        {
            cmbEstadisticas.Items.Add("Gol");
            cmbEstadisticas.Items.Add("Asistencia");
            cmbEstadisticas.Items.Add("Tarjeta Amarilla");
            cmbEstadisticas.Items.Add("Tarjeta Roja");
            cmbEstadisticas.SelectedIndex = 0;
        }
        private void ReporteListadoPaises_Load(object sender, EventArgs e)
        {
            CargarComboOrden();
            CargarComboEstadisticas();
            nmPaises.Value = 5;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string nEvento = jug.transformarAEventoBD(cmbEstadisticas.Text);
            bool ascendente = (cmbBoxOrden.Text == "Ascendente");
            tablaPais = jug.obtenerEstadisticasPorPais(Convert.ToInt32(nmPaises.Value), nEvento, ascendente);
            ds = new ReportDataSource("DatosPaises", tablaPais);


            reportPaises.LocalReport.SetParameters(new ReportParameter("estadistica", nEvento));
            reportPaises.LocalReport.SetParameters(new ReportParameter("estadisticaTitulo", cmbEstadisticas.Text));
            reportPaises.LocalReport.DataSources.Clear();
            reportPaises.LocalReport.DataSources.Add(ds);
            reportPaises.RefreshReport();
        }

        private void reportPaises_Load(object sender, EventArgs e)
        {

        }
    }
}

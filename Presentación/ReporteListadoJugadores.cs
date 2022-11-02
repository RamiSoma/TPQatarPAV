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
    public partial class ReporteListadoJugadores : Form
    {
        JugadorService jug = new JugadorService();
        PaisService pais = new PaisService();
        DataTable tablaJugs = new DataTable();
        ReportDataSource ds;
        public ReporteListadoJugadores()
        {
            InitializeComponent();
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, bool esFiltro)
        {
            if (esFiltro)
            {
                DataRow row = tabla.NewRow();
                row[tabla.Columns[0].ColumnName] = "Todos";
                tabla.Rows.InsertAt(row, 0);
            };
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboEstadisticas()
        {
            cmbEstadisticas.Items.Add("Gol");
            cmbEstadisticas.Items.Add("Asistencia");
            cmbEstadisticas.Items.Add("Tarjeta Amarilla");
            cmbEstadisticas.Items.Add("Tarjeta Roja");
            cmbEstadisticas.SelectedIndex = 0;
        }
        private void CargarComboOrden()
        {
            cmbBoxOrden.Items.Add("Ascendente");
            cmbBoxOrden.Items.Add("Descendente");
            cmbBoxOrden.SelectedIndex = 0;
        }
        private void ReporteListadoJugadores_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbPais,pais.traerTodos("",""),true);
            CargarComboEstadisticas();
            CargarComboOrden();
            this.reportJugs.RefreshReport();
        }
        
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string nEvento = jug.transformarAEventoBD(cmbEstadisticas.Text);
            string nPais = cmbPais.Text;
            bool ascendente = (cmbBoxOrden.Text == "Ascendente");

            if (cmbPais.Text == "Todos")
            {
                nPais = "";
            }
            tablaJugs = jug.obtenerFiltrados(nPais, Convert.ToInt32(nmJugadores.Value), nEvento, ascendente);
            ds = new ReportDataSource("DatosJugadores", tablaJugs);

            reportJugs.LocalReport.SetParameters(new ReportParameter("estadistica", nEvento));
            reportJugs.LocalReport.SetParameters(new ReportParameter("estadisticaTitulo", cmbEstadisticas.Text));
            reportJugs.LocalReport.DataSources.Clear();
            reportJugs.LocalReport.DataSources.Add(ds);
            reportJugs.RefreshReport();
        }

        private void reportJugs_Load(object sender, EventArgs e)
        {
            nmJugadores.Value = 15;
        }

        private void cmbEstadisticas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

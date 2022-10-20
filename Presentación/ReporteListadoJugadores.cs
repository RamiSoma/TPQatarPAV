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
        private void ReporteListadoJugadores_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbPais,pais.traerTodos("",""),true);
            CargarComboEstadisticas();
            this.reportJugs.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = jug.traerTodos("");

            ReportDataSource ds = new ReportDataSource("DatosJugadores", tabla);

            reportJugs.LocalReport.DataSources.Clear();
            reportJugs.LocalReport.DataSources.Add(ds);
            reportJugs.LocalReport.Refresh();
        }

        private void reportJugs_Load(object sender, EventArgs e)
        {
            
        }
    }
}

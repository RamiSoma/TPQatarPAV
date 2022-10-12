using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQatarPAVI.CapaServicios;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Presentación
{
    public partial class DetallePartidoForm : Form
    {
        public string idPartido;
        private bool finalizoPartido;
        PartidoService part = new PartidoService();
        Partidos partido = new Partidos();
        JugadorService jug = new JugadorService();
        EventoService evento = new EventoService();
        public DetallePartidoForm()
        {
            InitializeComponent();
            HabilitarAM(false);
            HabilitarABM(false);
        }

        private void FinPartido(bool v)
        {
            NumAM.Visible = v;
            
        }
        private void ChequearFinPartido()
        {
            if (finalizoPartido)
            {
                btnFinalizarPartido.Visible = false;
                HabilitarABM(false);
            }
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["minuto"],
                                tabla.Rows[i]["nro_doc_jg"],
                                tabla.Rows[i]["nombreCompleto"],
                                tabla.Rows[i]["evento"],
                                tabla.Rows[i]["id_evento"]);
            }
        }
        private void CargarComboEventos()
        {
            cmbEventoAM.Items.Add("Gol");
            cmbEventoAM.Items.Add("Asistencia");
            cmbEventoAM.Items.Add("Tarjeta Amarilla");
            cmbEventoAM.Items.Add("Tarjeta Roja");
            cmbEventoAM.SelectedIndex = 0;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName; 
            combo.ValueMember = tabla.Columns[1].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarPartido()
        {
            DataTable tabla = part.obtenerPartidoId(idPartido);
            partido.paisLocal = Convert.ToString(tabla.Rows[0]["pais_1"]);
            partido.paisVisita = Convert.ToString(tabla.Rows[0]["pais_2"]);
            partido.tipoDocArb = Convert.ToString(tabla.Rows[0]["tipo_doc_arb"]);
            partido.nroDocArb = Convert.ToString(tabla.Rows[0]["nro_doc_arb"]);
            partido.nombreArb = Convert.ToString(tabla.Rows[0]["nombreArbitro"]);
            partido.fecha = Convert.ToString(tabla.Rows[0]["fecha"]).Substring(0,10);
            partido.ronda = Convert.ToString(tabla.Rows[0]["ronda"]);
            partido.grupo = Convert.ToString(tabla.Rows[0]["grupo"]);
            partido.estadio = Convert.ToString(tabla.Rows[0]["estadio"]);
        }
        private void CargarLabels()
        {
            lblMostrarEstadio.Text = partido.estadio;
            lblMostrarFecha.Text = partido.fecha;
            lblMostrarGrupo.Visible = false;
            label6.Visible = false;
            lblMostrarArb.Text = partido.nombreArb;
            lblMostrarRonda.Text = partido.ronda;
            lblMostrarEstadio.Text = partido.estadio;
            if (partido.ronda == "1" )
            {
                lblMostrarGrupo.Visible = true;
                label6.Visible = true;
                lblMostrarGrupo.Text = partido.grupo;
            }
           
        }
       
        private void HabilitarABM (bool v)
        {
            btnAgregar.Visible = v;
            btnEliminar.Visible = v;  
            btnRestaurar.Visible = v;
        }

        private void InfoPartido(bool v)
        {
            label1.Visible =v;
            ck_nomb_local.Visible = v;
            label4.Visible = v;
            lblGolesLocal.Visible = v;
            lblGolesVisita.Visible = v;
            ck_nomb_visita.Visible = v;
            btnFinalizarPartido.Visible = v;
        }
        private void HabilitarAM(bool v)
        {
            lblMinutoAM.Visible = v;
            NumAM.Visible = v;
            NumAM.Maximum = 120;
            cmbEventoAM.Visible = v;
            cmbJugadoresAM.Visible = v;
            btnGuardarAM.Visible = v;
            btnCancelarAM.Visible = v; 
            lblEventoAM.Visible = v;
            lblJugAM.Visible = v;
            lblPaisAM.Visible = v;
        }

        private void DetallePartidoForm_Load(object sender, EventArgs e)
        {
            lblMostrarId.Text = idPartido;
            CargarPartido();
            CargarLabels();
            ck_nomb_local.Text = partido.paisLocal;
            ck_nomb_visita.Text = partido.paisVisita;
            CargarComboEventos();
            finalizoPartido = part.chequearFinPartido(idPartido);
            ChequearFinPartido();
            CargarGoles();
        }
        private void CargarGoles()
        {
            DataTable goles = part.obtenerPartidoId(idPartido);
            lblGolesLocal.Text = Convert.ToString(goles.Rows[0]["goles_p1"]);
            lblGolesVisita.Text = Convert.ToString(goles.Rows[0]["goles_p2"]);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarAM(true);
            HabilitarABM(false);
            InfoPartido(false);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ck_nomb_local_CheckedChanged(object sender, EventArgs e)
        {
            if (finalizoPartido)
            {
                ck_nomb_visita.Checked = false;
                CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, ck_nomb_local.Text));
            }
            else
            {
                ck_nomb_visita.Checked = false;
                lblPaisAM.Text = ck_nomb_local.Text;
                HabilitarABM(true);
                //cargar jugadores del local
                CargarCombo(cmbJugadoresAM, jug.traerJugadoresPais(ck_nomb_local.Text));
                //cargar grilla con eventos del local
                CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, ck_nomb_local.Text));
            }
        }

        private void ck_nomb_visita_CheckedChanged(object sender, EventArgs e)
        {
            if (finalizoPartido)
            {
                ck_nomb_local.Checked = false;
                CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, ck_nomb_visita.Text));
            }
            else
            {
                ck_nomb_local.Checked = false;
                lblPaisAM.Text = ck_nomb_visita.Text;
                HabilitarABM(true);
                //cargar jugadores del visita
                CargarCombo(cmbJugadoresAM, jug.traerJugadoresPais(ck_nomb_visita.Text));
                //cargar grilla con eventos del visita
                CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, ck_nomb_visita.Text));
                CargarGoles();
            }
        }

        private void btnGuardarAM_Click(object sender, EventArgs e)
        {
            HabilitarAM(false);
            HabilitarABM(true);
            InfoPartido(true);
            evento.crearEvento(idPartido, NumAM.Value.ToString(), cmbJugadoresAM.SelectedValue.ToString(), cmbEventoAM.Text);
            CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, lblPaisAM.Text));
            if (cmbEventoAM.Text == "Gol") // jugador, partidos
            {
                jug.anotar(cmbJugadoresAM.SelectedValue.ToString(), cmbEventoAM.Text,"sumar");
                part.modificarGol(idPartido,lblPaisAM.Text,"sumar");
                CargarGoles();
            }

            if (cmbEventoAM.Text == "Tarjeta Roja" || cmbEventoAM.Text == "Tarjeta Amarilla" || cmbEventoAM.Text == "Asistencia") //jugador
            {
                jug.anotar(cmbJugadoresAM.SelectedValue.ToString(), cmbEventoAM.Text,"sumar");
            }

        }

        private void btnCancelarAM_Click(object sender, EventArgs e)
        {
            HabilitarAM(false);
            HabilitarABM(true);
            InfoPartido(true);
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGridEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idEvento = dGridEventos.SelectedRows[0].Cells[4].Value.ToString();
            string jugador = dGridEventos.SelectedRows[0].Cells[2].Value.ToString();
            DialogResult rta = MessageBox.Show("¿Estas seguro que deseas eliminar el evento seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rta == DialogResult.Yes)
            {
                evento.eliminarEvento(idEvento);
                CargarGrilla(dGridEventos, evento.traerEventosPorId(idPartido, lblPaisAM.Text));
                CargarGoles();
            }
        }

        private void lblGolesLocal_Click(object sender, EventArgs e)
        {

        }

        private void cmbEventoAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizarPartido_Click(object sender, EventArgs e)
        {
            part.finalizarPartido(idPartido, partido.paisLocal, lblGolesLocal.Text, partido.paisVisita, lblGolesVisita.Text);
            finalizoPartido = true;
            HabilitarABM(false);
            InfoPartido(true);
            btnFinalizarPartido.Visible=false;
        }
    }
}

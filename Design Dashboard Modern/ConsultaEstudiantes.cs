using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Design_Dashboard_Modern
{
    public partial class ConsultaEstudiantes : Form
    {
        private readonly EstudianteService estudianteService;
        public ConsultaEstudiantes()
        {
            InitializeComponent();
            estudianteService = new EstudianteService();
        }

        private void Consultar()
        {
            var response = estudianteService.ConsultarTodos();
            LlenarDtg(response);
            TxtTotalVotaron.Text = estudianteService.TotalizarVotos().ToString();
        }

        private void ConsultarFiltrarVoto()
        {

            var response = estudianteService.ConsultarSiVoto(CmbFiltro.Text);
            LlenarDtg(response);
            TxtConteoVotaron.Text = estudianteService.ContarSiVotos().ToString();

        }

        private void ConsultarFiltrarNoVoto()
        {
            var response = estudianteService.ConsultarNoVoto(CmbFiltro.Text);
            LlenarDtg(response);
            TxtConteoNoVotaron.Text = estudianteService.ContarNoVotos().ToString();
        }
        private void BuscarDtg()
        {
            var response = estudianteService.BuscarDtg(TxtIdentificacion.Text);
            if (response != null)
            {
                EstudianteResponse respuesta = estudianteService.BuscarPorIdentificacion(TxtIdentificacion.Text);
                Estudiante estudiante = respuesta.Estudiante;
                if (estudiante == null)
                {
                    var Messg = estudianteService.ConsultaNoEncontradaIdentificacion();
                    MessageBox.Show(Messg.Message);
                }
                LlenarDtg(response);
            }
        }

        private void LlenarDtg(ConsultaEstudianteResponse response)
        {
            if (response.Encontrado)
            {
                foreach (var item in response.Estudiante)
                {
                    DtgEstudiante.Rows.Add(item.Identificacion, item.Nombre, item.Voto, item.NumeroVoto);
                }
            }
        }
        private void VaciarTextBox()
        {
            TxtTotalVotaron.Text = "";
            TxtConteoNoVotaron.Text = "";
            TxtConteoVotaron.Text = "";
        }
        private void BtReservaHab_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtcancelarHab_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PulsacionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgEstudiante.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                var respuesta = estudianteService.ConsultaVacia();
                MessageBox.Show(respuesta.Message);

            }
            else if (CmbFiltro.Text.Equals("TODOS"))
            {
                Consultar();
            }
            else if (CmbFiltro.Text.Equals("NO"))
            {
                ConsultarFiltrarNoVoto();
            }
            else
            {
                ConsultarFiltrarVoto();
            }
        }

        private void BtCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtConsultarIdentificacion_Click(object sender, EventArgs e)
        {
            DtgEstudiante.Rows.Clear();
            VaciarTextBox();
            var filtrado = TxtIdentificacion.Text;
            if (filtrado.Equals(""))
            {
                var respuesta = estudianteService.ConsultaVaciaBuscarDtg();
                MessageBox.Show(respuesta.Message);
            }
            else
            {
                BuscarDtg();
            }
        }
    }
}

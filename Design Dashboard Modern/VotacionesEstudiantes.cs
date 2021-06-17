using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Design_Dashboard_Modern
{
    public partial class VotacionesEstudiantes : Form
    {
        EstudianteService CandidatoService = new EstudianteService();
        EstudianteService estudianteService = new EstudianteService();
        public VotacionesEstudiantes()
        {
            InitializeComponent();
           
        }

        private void BuscarDtg()
        {
           
            EstudianteResponse respuesta = estudianteService.BuscarPorIdentificacion(TxtIdentificacion.Text);
            Estudiante estudiante = respuesta.Estudiante;
            if (estudiante != null)
            {
                TxtNombre.Text = estudiante.Nombre;
                var response = estudianteService.BuscarDtg(TxtIdentificacion.Text);
                if (response != null)
                {
                    DtgVotaciones.Enabled = true;
                    BtRegistrarVoto.Enabled = true;
                    ConsultarTodosCandidatos();
                }
            }
            else
            {
                LimpiarTxt();
                var Messg = estudianteService.ConsultaNoEncontradaIdentificacion();
                MessageBox.Show(Messg.Message);
                DtgVotaciones.Rows.Clear();
                BtRegistrarVoto.Enabled = false;
                DtgVotaciones.Enabled = false;
            }
            
        }
        private void ConsultarTodosCandidatos()
        {            
            var response = CandidatoService.ConsultarTodosCandidatosDtg();
            foreach (var item in response.Candidato)
            {
                DtgVotaciones.Rows.Add(item.NumeroTarjeton, item.Nombre);
            }
        }
        
        private void ConsultarGanancias_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelarGanancias_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
            DtgVotaciones.Rows.Clear();
        }
        private void LimpiarTxt()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            BtRegistrarVoto.Enabled = false;
            DtgVotaciones.Enabled = false;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgVotaciones.Rows.Clear();
            var filtrado = TxtIdentificacion.Text;
            if (filtrado.Equals(""))
            {
                var respuesta = estudianteService.ConsultaVaciaBuscarDtg();
                MessageBox.Show(respuesta.Message);
                BtRegistrarVoto.Enabled = false;
                DtgVotaciones.Enabled = false;
            }
            else
            {
                BuscarDtg();               
            }
        }

        private void DtgVotaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             BtRegistrarVoto.Enabled = true;
            DtgVotaciones.Enabled = true;
             DtgVotaciones.Refresh();
    
        }

        private void DtgVotaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

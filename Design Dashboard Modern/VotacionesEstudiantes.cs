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
            var response = estudianteService.BuscarDtg(TxtIdentificacion.Text);
            if (response != null)
            {
                EstudianteResponse respuesta = estudianteService.BuscarPorIdentificacion(TxtIdentificacion.Text);
                Estudiante estudiante = respuesta.Estudiante;
                if (estudiante != null)
                {
                    TxtNombre.Text = estudiante.Nombre;
                }
                else
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
                    DtgVotaciones.Rows.Add(item.Identificacion, item.Nombre, item.Voto, item.NumeroVoto);
                }
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
        }
        private void LimpiarTxt()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";  
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
            }
            else
            {
                BuscarDtg();
                
            }
        }
    }
}

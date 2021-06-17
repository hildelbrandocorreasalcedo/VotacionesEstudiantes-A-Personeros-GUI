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
    public partial class RegistrosCandidatos : Form
    {
        
        EstudianteService CandidatoService = new EstudianteService();
        public RegistrosCandidatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabTelefono_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        

        private bool validarcampos()
        {
            bool ok = true;
            if(TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Por Favor Ingrese los Nombres");
            }           
            if (TxtNumeroTarjeton.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNumeroTarjeton, "Por Favor Ingrese El Numero del Tarjeton");
            }
            if (TxtCantidadVotos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCantidadVotos, "Este Campo Es Obligatorio");
            }
            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtNumeroTarjeton, "");
            errorProvider1.SetError(TxtNombre, "");
        }
        private void BorrarMensajesErrorIdentificacion()
        {
            errorProvider1.SetError(TxtNumeroTarjeton, "");
            
        }
       

        private void ButCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtNumeroTarjeton.Text, out numero))
            {
                errorProvider1.SetError(TxtNumeroTarjeton, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtNumeroTarjeton, "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistroPensionado_Load(object sender, EventArgs e)
        {

        }

        private void LabFechanacimiento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PanelColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtRegistrar_Click_2(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                Candidatos candidato = MapearCandidato();
                string mensaje = CandidatoService.GuardarCandidato(candidato);
                MessageBox.Show(mensaje);
                LimpiarTxt();
            }
            
        }
        private Candidatos MapearCandidato()
        {
            Candidatos candidato = new Candidatos();
            candidato.NumeroTarjeton = TxtNumeroTarjeton.Text;
            candidato.Nombre = TxtNombre.Text;
            candidato.CantidadVotos = int.Parse(TxtCantidadVotos.Text);
            return candidato;
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                if (TxtNumeroTarjeton.Text != "" && TxtNombre.Text != "" && TxtCantidadVotos.Text != "")
                {
                    Candidatos candidato = MapearCandidato();
                   // candidato.CalcularCantidadVotos();
                    string mensaje = CandidatoService.ModificarCandidato(candidato);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("rectifique los campos");
                }
                LimpiarTxt();
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            BorrarMensajesErrorIdentificacion();
            if (validarcampos())
            {
                string numeroTarjeton = TxtNumeroTarjeton.Text;
                if (numeroTarjeton != "")
                {
                    RespuestaBusqueda respuesta = CandidatoService.BuscarCandidato(numeroTarjeton);
                    if (respuesta.Candidato != null)
                    {
                        numeroTarjeton = TxtNumeroTarjeton.Text;
                        var mensaje = CandidatoService.EliminarCandidato(numeroTarjeton);
                        MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show($"El candidato con el numero de tarjeton {numeroTarjeton} no se encuentra registrado");
                    }
                }
                LimpiarTxt();
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {  
                errorProvider1.SetError(TxtNombre, "");
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string numeroTarjeton = TxtNumeroTarjeton.Text;
            if (numeroTarjeton != "")
            {
                RespuestaBusqueda respuesta = CandidatoService.BuscarCandidato(numeroTarjeton);

                if (respuesta.Candidato != null)
                {
                    Candidatos candidato = respuesta.Candidato;
                    TxtNombre.Text = candidato.Nombre;
                    TxtCantidadVotos.Text = candidato.CantidadVotos.ToString();
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("digite el numero de tarjeton a buscar");
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            TxtNumeroTarjeton.Text = "";
            TxtNombre.Text = "";
            TxtCantidadVotos.Text = "0";
        }
    }
}

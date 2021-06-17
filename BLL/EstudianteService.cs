using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class EstudianteService
    {
        private readonly EstudianteRepository estudianteRepository;
        private readonly EstudianteRepository CandidatoRepository;

        public EstudianteService()
        {
            estudianteRepository = new EstudianteRepository();
            CandidatoRepository = new EstudianteRepository();
        }

        public string GuardarCandidato(Candidatos candidato)
        {
            try
            {
                if (CandidatoRepository.BuscarCandidato(candidato.NumeroTarjeton) == null)
                {
                    CandidatoRepository.GuardarCandidato(candidato);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"El Numero de Tarjeton {candidato.NumeroTarjeton} ya se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de Datos: " + e.Message;
            }
        }

        public string EliminarCandidato(string numeroTarjeton)
        {
            try
            {
                if (CandidatoRepository.BuscarCandidato(numeroTarjeton) != null)
                {
                    CandidatoRepository.EliminarCandidato(numeroTarjeton);
                    return $"El candidato con numero de tarjeton {numeroTarjeton} ha sido eliminada satisfacatoriamente";
                }
                return $"El numero de tarjeton {numeroTarjeton} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public string ModificarCandidato(Candidatos candidato)
        {
            try
            {
                if (CandidatoRepository.BuscarCandidato(candidato.NumeroTarjeton) != null)
                {

                    CandidatoRepository.ModificarCandidato(candidato);
                    return $"El candidato con numero de tarjeton {candidato.NumeroTarjeton} ha sido modificada satisfacatoriamente";
                }
                return $"El numero de tarjeton {candidato.NumeroTarjeton} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }
        public RespuestaBusqueda BuscarCandidato(string NumeroTarjeton)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Candidatos candidato = CandidatoRepository.BuscarCandidato(NumeroTarjeton);
                if (candidato == null)
                {
                    respuesta.Mensaje = $"El candidato con numero de tarjeton {NumeroTarjeton} no se encuentra registrado";
                    respuesta.Candidato = null;
                }
                else
                {
                    respuesta.Candidato = candidato;
                    respuesta.Mensaje = "Candidato encontrado\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.Candidato = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public RespuestaConsulta ConsultarTodosCandidatos()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Candidatos> Candidatoss = CandidatoRepository.ConsultarTodosCandidatos();
                if (Candidatoss.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de candidatos";
                    respuesta.Candidatos = Candidatoss;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.Candidatos = null;
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.Candidatos = null;
            }
            return respuesta;
        }

        public ConsultaCandidatoResponse ConsultarTodosCandidatosDtg()
        {
            try
            {
                List<Candidatos> candidato = CandidatoRepository.ConsultarTodosCandidatosDtg();
                if (candidato != null)
                {
                    return new ConsultaCandidatoResponse(candidato);
                }
                else
                {
                    return new ConsultaCandidatoResponse("El candidato buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {

                return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public class ConsultaCandidatoResponse
        {
            public List<Candidatos> Candidato { get; set; }
            public string Message { get; set; }
            
            public ConsultaCandidatoResponse(List<Candidatos> candidato)
            {
                Candidato = new List<Candidatos>();
                Candidato = candidato;
            }
            public ConsultaCandidatoResponse(string message)
            {
                Message = message;
            }
        }
            //////////////////////////////////------------------------///////////////////////////////////////
            /////////////////////////////////------Estudiantes-------///////////////////////////////////////
            ////////////////////////////////------------------------///////////////////////////////////////
        public string Guardar(Estudiante estudiante)
        {
            try
            {

                if (estudianteRepository.Buscar(estudiante.Identificacion) == null)
                {
                    estudianteRepository.Guardar(estudiante);
                    return $"se han guardado Satisfactoriamente los datos de: {estudiante.Nombre} ";
                }
                else
                {
                    return $"Lo sentimos, con la Identificación {estudiante.Identificacion} ya se encuentra registrada";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }

        public EstudianteResponse BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                Estudiante estudiante = estudianteRepository.Buscar(identificacion);
                if (estudiante != null)
                {
                    return new EstudianteResponse(estudiante);
                }
                else
                {
                    return new EstudianteResponse($"La persona con la identificación {identificacion} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new EstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaVacia()
        {
            try
            {
                return new ConsultaEstudianteResponse("Escoja una Opción de Filtrado");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaVaciaBuscarDtg()
        {
            try
            {               
                 return new ConsultaEstudianteResponse("Escriba la identificacion a buscar");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaNoEncontradaIdentificacion()
        {
            try
            {
                return new ConsultaEstudianteResponse("La identificacion buscada no se encuentra, vuelva a intentarlo con otra identificacion");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultarTodos()
            {
            try
            {
                List<Estudiante> estudiante = estudianteRepository.ConsultarTodos();
                if (estudiante != null)
                {
                    return new ConsultaEstudianteResponse(estudiante);
                }
                else
                {
                    return new ConsultaEstudianteResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultarSiVoto(string voto)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.FiltrarVoto(voto);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse("el estudiante buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {

                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }


        public ConsultaEstudianteResponse ConsultarNoVoto(string voto)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.FiltrarNoVoto(voto);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse("el estudiante buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse BuscarDtg(string identificacion)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.BuscarDtg(identificacion);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse($"La persona con la identificación {identificacion} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public int TotalizarVotos()
        {
            return estudianteRepository.TotalizarVotos();
        }

        public int ContarSiVotos()
        {
            return estudianteRepository.ContarSiVotos();
        }

        public int ContarNoVotos()
        {
            return estudianteRepository.ContarNoVotos();
        }
    }
    public class EstudianteResponse
    {
        public Estudiante Estudiante { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public EstudianteResponse(Estudiante estudiante)
        {
            Estudiante = new Estudiante();
            Estudiante = estudiante;
            Encontrado = true;
        }
        public EstudianteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

    public class ConsultaEstudianteResponse
    {
        public List<Estudiante> Estudiante { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaEstudianteResponse(List<Estudiante> estudiante)
        {
            Estudiante = new List<Estudiante>();
            Estudiante = estudiante;
            Encontrado = true;
        }
        public ConsultaEstudianteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

}

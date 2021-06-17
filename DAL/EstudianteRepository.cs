using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;


namespace DAL
{
    public class EstudianteRepository
    {
        private readonly string FileName = "Estudiante.txt";
        private readonly string FileNameCandidatos = "Candidatos.txt";

        public IList<Candidatos> candidatos;
        public EstudianteRepository()
        {
            candidatos = new List<Candidatos>();
        }

        public void GuardarCandidato(Candidatos candidato)
        {

            FileStream file = new FileStream(FileNameCandidatos, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{candidato.NumeroTarjeton};{candidato.Nombre};{candidato.CantidadVotos} ");
            writer.Close();
            file.Close();
        }

        public IList<Candidatos> ConsultarTodosCandidatos()
        {           
            FileStream fileStream = new FileStream(FileNameCandidatos, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Candidatos candidato = MapearCandidato(linea);
                candidatos.Add(candidato);
            }
            lector.Close();
            fileStream.Close();
            return candidatos;
        }
        public List<Candidatos> ConsultarTodosCandidatosDtg()
        {
            List<Candidatos> candidatos = new List<Candidatos>();
            FileStream fileStream = new FileStream(FileNameCandidatos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Candidatos candidato = MapearCandidato(linea);
                candidatos.Add(candidato);
            }
            lector.Close();
            fileStream.Close();
            return candidatos;
        }

        public Candidatos MapearCandidato(string linea)
        {
            Candidatos candidato = new Candidatos();
            string[] datos = linea.Split(';');
            candidato.NumeroTarjeton = datos[0];
            candidato.Nombre = datos[1];
            candidato.CantidadVotos = int.Parse(datos[2]);
            return candidato;
        }


        public void EliminarCandidato(string numeroTarjeton)
        {
            candidatos.Clear();
            candidatos = ConsultarTodosCandidatos();
            FileStream fileStream = new FileStream(FileNameCandidatos, FileMode.Create);
            fileStream.Close();
            foreach (var item in candidatos)
            {
                if (item.NumeroTarjeton != numeroTarjeton)
                {
                    GuardarCandidato(item);
                }
            }
        }

        public void ModificarCandidato(Candidatos candidato)
        {
            candidatos.Clear();
            candidatos = ConsultarTodosCandidatos();
            FileStream fileStream = new FileStream(FileNameCandidatos, FileMode.Create);
            fileStream.Close();
            foreach (var item in candidatos)
            {
                if (item.NumeroTarjeton != candidato.NumeroTarjeton)
                {
                    GuardarCandidato(item);
                }
                else
                {
                    GuardarCandidato(candidato);
                }
            }
        }

        public Candidatos BuscarCandidato(string numeroTarjeton)
        {
            candidatos.Clear();
            candidatos = ConsultarTodosCandidatos();
            Candidatos persona = new Candidatos();
            foreach (var item in candidatos)
            {
                if (item.NumeroTarjeton.Equals(numeroTarjeton))
                {
                    return item;
                }
            }
            return null;
        }
//////////////////////////////////------------------------///////////////////////////////////////
/////////////////////////////////------Estudiantes-------///////////////////////////////////////
////////////////////////////////------------------------///////////////////////////////////////
        public void Guardar(Estudiante estudiante)
        {

            FileStream file = new FileStream(FileName, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{estudiante.Identificacion};{estudiante.Nombre};{estudiante.Voto};{estudiante.NumeroVoto} ");
            writer.Close();
            file.Close();
        }

        public Estudiante Buscar(string identificacion)
        {
            List<Estudiante> estudiantes = ConsultarTodos();
            foreach (var item in estudiantes)
            {
                if (Encontrado(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        private bool Encontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }

        private Estudiante Map(string linea)
        {
            Estudiante estudiante = new Estudiante();
            char delimiter = ';';
            string[] matrizEstudiante = linea.Split(delimiter);
            estudiante.Identificacion = matrizEstudiante[0];
            estudiante.Nombre = matrizEstudiante[1];
            estudiante.Voto = matrizEstudiante[2];
            estudiante.NumeroVoto = matrizEstudiante[3];

            return estudiante;
        }

        public List<Estudiante> ConsultarTodos()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Estudiante estudiante = Map(linea);
                estudiantes.Add(estudiante);
            }
            reader.Close();
            file.Close();
            return estudiantes;
        }

        public List<Estudiante> FiltrarVoto(string voto)
        {

            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradas =
                (from estudiante in estudiantes
                 where estudiante.Voto.Equals("SI")
                 select estudiante).ToList();
            return estudiantesFiltradas;
        }

        public List<Estudiante> FiltrarNoVoto(string voto)
        {

            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradas =
                (from estudiante in estudiantes
                 where estudiante.Voto.Equals("NO")
                 select estudiante).ToList();
            return estudiantesFiltradas;
        }
        public List<Estudiante> BuscarDtg(string identificacion)
        {
            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradasBuscado =
                (from estudiante in estudiantes
                 where estudiante.Identificacion.Equals(identificacion)
                 select estudiante).ToList();
            return estudiantesFiltradasBuscado;
        }
        
        public int TotalizarVotos()
        {
            return ConsultarTodos().Count();
        }
        public int ContarSiVotos()
        {
            return ConsultarTodos().Where(p => p.Voto == "SI").Count();
        }
        public int ContarNoVotos()
        {
            return ConsultarTodos().Where(p => p.Voto == "NO").Count();
        }
    }
}

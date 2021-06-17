using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Estudiante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Voto { get; set; }
        public string NumeroVoto { get; set; }

        public Estudiante()
        {

        }
        public Estudiante(string identificacion, string nombre, string voto, string tipoAyuda)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Voto = voto;
            NumeroVoto = tipoAyuda;
        }
    }
}

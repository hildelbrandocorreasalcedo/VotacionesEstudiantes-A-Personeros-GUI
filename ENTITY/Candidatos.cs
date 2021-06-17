using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Candidatos
    {
        public string NumeroTarjeton { get; set; }
        public string Nombre { get; set; }
        public int CantidadVotos  { get; set; }

        public Candidatos()
        {

        }
        public Candidatos(string numeroTarjeton, string nombre, int cantidadVotos)
        {
            NumeroTarjeton = numeroTarjeton;
            Nombre = nombre;
            CantidadVotos = cantidadVotos; 
        }
        public override string ToString()
        {
            return $"Numero de Tarjeton:{NumeroTarjeton} Nombre: {Nombre} CantidadVotos: {CantidadVotos}";
        }
    }
}

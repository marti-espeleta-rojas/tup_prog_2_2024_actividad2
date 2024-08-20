using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula2
{
    internal class Policia
    {
        public int DNI { get; set; }
        public string Nombre { get; private set; }
        public int NumeroPlaca { get; private set; }

        public Policia (int dni, string nombre, int numeroPlaca)
        {
            DNI = dni;
            Nombre=nombre;
            NumeroPlaca = numeroPlaca; 
        }

        public string VerDatos()
        {
            string datos = $"DNI: {DNI}, Nombre: {Nombre}, Numero de Placa: {NumeroPlaca}";
            return datos;
        }
    }
}

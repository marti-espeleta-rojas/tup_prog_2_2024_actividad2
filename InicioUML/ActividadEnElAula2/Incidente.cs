using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula2
{
    internal class Incidente
    {
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int TipoIncidente { get; private set; }
        public Policia OficialACargo { get; private set; }
        public Persona Sujeto { get; private set; }

        public Incidente(Policia oficial, Persona sujeto, int tipoIncidente) 
        {
            OficialACargo = oficial;
            Sujeto = sujeto;
            TipoIncidente = tipoIncidente;
        }
        public string VerDescripcion()
        {
            string descripcion = $""
        }
    }
}

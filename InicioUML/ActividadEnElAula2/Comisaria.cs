using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula2
{
    internal class Comisaria
    {
        public int CantidadIncidentes { get; private set; }
        private ArrayList incidentes;
        private Policia[] agentes = new Policia[2];
        private Guardia[] guardias;
        private Guardia guardia;
        int contGuardias = 0;
        int cantPoli = 0;
        public Comisaria()
        {
            incidentes = new ArrayList();
            guardias = new Guardia[2];
        }
        public bool AsignarPolicia(Policia poli)
        {
            if (cantPoli < 2)
            {
                agentes[cantPoli++] = poli;
            }
            return true;
        }
        public Policia VerAgente(int numeroPlaca)
        {
            Policia policia = null;
            for (int i=0; i<cantPoli; i++) 
            {
                if (agentes[i].NumeroPlaca == numeroPlaca)
                {
                    policia = agentes[i];
                }
            }
            return policia;
        }
        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
        {
            Incidente nueva = new Incidente(agente, sujeto, tipoIncidente);
            incidentes.Add(nueva);
        }
        public void AsignarGuardia(int numero, int h1, int m1, int tiempoMinutos, Policia agente)
        {
            int i = 0;
            guardia = new Guardia();
            guardia = guardias[i++];
            guardia.AsignarPolicia(agente, h1, m1, tiempoMinutos);

        }
        public Incidente VerIncidente(int idx)
        {
            if (idx>=0 && idx < CantidadIncidentes)
            {
                return incidentes[idx] as Incidente;
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEnElAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Comisaria comisaria = new Comisaria();
        Persona persona;
        private void btnAsignaciondeGuardias_Click(object sender, EventArgs e)
        {
            Guardia guardia = new Guardia();
            Policia poli1 = new Policia(47175514, "Joaco", 17714);
            Policia poli2 = new Policia(24264435, "Josefa", 43221);
            comisaria.AsignarGuardia(Convert.ToInt32(dmdNroGuardia.Text), Convert.ToInt32(dmdDesdeHora.Text), Convert.ToInt32(dmdDesdeMinuto.Text), Convert.ToInt32(dmdDuracion.Text), poli1);
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            persona = new Persona(Convert.ToInt32(tbDNI.Text), tbPersona.Text);
            comisaria.RegistrarIncidente();
            tbPersona.Clear();
            tbMotivo.Clear();
            tbDNI.Clear();
        }

        private void btnCreacionComisaria_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListarIncidentes_Click(object sender, EventArgs e)
        {

        }
    }
}

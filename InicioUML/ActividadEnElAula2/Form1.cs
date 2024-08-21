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

        Comisaria comisaria;
        Persona persona;
        Policia poli;
        private void btnAsignaciondeGuardias_Click(object sender, EventArgs e)
        {
            Guardia guardia = new Guardia();
            Policia poli = new Policia(47175514, "Joaco", 17714);
            comisaria.AsignarGuardia(Convert.ToInt32(nmNroGuardia.Text), Convert.ToInt32(nmHoraDesde.Text), Convert.ToInt32(nmMinutoDesde.Text), Convert.ToInt32(nmDuracion.Text), poli);
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            persona = new Persona(Convert.ToInt32(tbDNI.Text), tbPersona.Text);
            comisaria.RegistrarIncidente(poli, persona, tbMotivo.Text, Convert.ToInt32(nmHoraHora.Text), Convert.ToInt32(nmHoraMinuto.Text), Convert.ToInt32(cbxTipoIncidente.SelectedIndex));
            tbPersona.Clear();
            tbMotivo.Clear();
            tbDNI.Clear();
        }

        private void btnCreacionComisaria_Click(object sender, EventArgs e)
        {
            comisaria = new Comisaria();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListarIncidentes_Click(object sender, EventArgs e)
        {
            FormVerIncidente ver = new FormVerIncidente();
            Incidente inci = null;
            inci.VerDescripcion();
            ver.ShowDialog();
        }
    }
}

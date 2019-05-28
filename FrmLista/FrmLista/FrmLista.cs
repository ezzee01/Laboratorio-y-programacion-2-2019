using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmPersona;

namespace FrmLista
{
    public partial class FrmLista : Form
    {
        public FrmPersona.FrmPersona frmPersona = new FrmPersona.FrmPersona();

        public FrmLista()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (frmPersona.ShowDialog() == DialogResult.OK)
            {                
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Persona aux in frmPersona.personas)
            {
                lstPersonas.Items.Add(aux.ToString());
            }
        }
    }
}

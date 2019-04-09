using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6
{
  public partial class frmRegistro : Form
  {
    public frmRegistro()
    {
      InitializeComponent();
    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }

    private void lblSubTitulo_Click(object sender, EventArgs e)
    {

    }

    private void txtNombre_TextChanged(object sender, EventArgs e)
    {
      lblNombre.Visible = false;
      if (txtNombre.Text == "")
      {
        lblNombre.Visible = true;
      }
    }

    private void lblNombre_Click(object sender, EventArgs e)
    {

    }

    private void txtApellido_TextChanged(object sender, EventArgs e)
    {
      lblApellido.Visible = false;
      if (txtApellido.Text == "")
      {
        lblApellido.Visible = true;
      }
    }

    private void lblApellido_Click(object sender, EventArgs e)
    {

    }

    private void btnContinuar_Click(object sender, EventArgs e)
    {

    }

    private void txtDireccion_TextChanged(object sender, EventArgs e)
    {
      lblDireccion.Visible = false;
      if (txtDireccion.Text == "")
      {
        lblDireccion.Visible = true;
      }
    }

    private void lblDireccion_Click(object sender, EventArgs e)
    {

    }

    private void lblYahoo_Click(object sender, EventArgs e)
    {

    }

    private void txtNumero_TextChanged(object sender, EventArgs e)
    {
      lblNumero.Visible = false;
      if (txtNumero.Text == "")
      {
        lblNumero.Visible = true;
      }
    }

    private void lblNumero_Click(object sender, EventArgs e)
    {

    }

    private void cmbNumeroInicial_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dtpFecha_ValueChanged(object sender, EventArgs e)
    {

    }

    private void frmRegistro_Load(object sender, EventArgs e)
    {

    }

    private void grbSexo_Enter(object sender, EventArgs e)
    {

    }

    private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void rdbOtros_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void txtContraseña_TextChanged(object sender, EventArgs e)
    {
      lblContraseña.Visible = false;
      if (txtContraseña.Text == "")
      {
        lblContraseña.Visible = true;
      }
    }

    private void lblContraseña_Click(object sender, EventArgs e)
    {

    }
  }
}

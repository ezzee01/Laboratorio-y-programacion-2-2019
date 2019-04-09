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
    StringBuilder sb = new StringBuilder();

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
      string nombre;
      lblNombre.Visible = false;
      if (txtNombre.Text == "")
      {
        lblNombre.Visible = true;
      }
      if (long.TryParse(txtNombre.Text, out long i) == false)
      {
        nombre = txtNombre.Text;
        sb.AppendFormat("Nombre: {0}", nombre);
        lblErrorNombre.Visible = false;
      }
      else
      {
        lblErrorNombre.Visible = true;
      }      
    }

    private void lblNombre_Click(object sender, EventArgs e)
    {

    }

    private void txtApellido_TextChanged(object sender, EventArgs e)
    {
      string apellido;
      lblApellido.Visible = false;
      if (txtApellido.Text == "")
      {
        lblApellido.Visible = true;
      }
      if (long.TryParse(txtApellido.Text, out long i) == false)
      {
        apellido = txtApellido.Text;
        sb.AppendFormat("Apellido: {0}", apellido);
        lblErrorApellido.Visible = false;
      }
      else
      {
        lblErrorApellido.Visible = true;
      }
    }

    private void lblApellido_Click(object sender, EventArgs e)
    {

    }

    private void btnContinuar_Click(object sender, EventArgs e)
    {
      MessageBox.Show(sb.ToString());
    }

    private void txtDireccion_TextChanged(object sender, EventArgs e)
    {
      string direccion;
      lblDireccion.Visible = false;
      if (txtDireccion.Text == "")
      {
        lblDireccion.Visible = true;
      }
      if (txtDireccion.Text.Contains("@yahoo.com") == false)
      {
        direccion = txtDireccion.Text;
        sb.AppendFormat("Direccion de correo: {0}@yahoo.com", direccion);
        lblErrorDireccion.Visible = false;
      }
      else
      {
        lblErrorDireccion.Visible = true;
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
      string numero;
      lblNumero.Visible = false;
      if (txtNumero.Text == "")
      {
        lblNumero.Visible = true;
      }
      if (txtNumero.Text.Length <= 10)
      {
        numero = txtNumero.Text;
        sb.AppendFormat("Numero telefonico: {0}", numero);
        lblErrorNumero.Visible = false;
      }
      else
      {
        lblErrorNumero.Visible = true;
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
      string contraseña;
      lblContraseña.Visible = false;
      if (txtContraseña.Text == "")
      {
        lblContraseña.Visible = true;
      }
      if (txtContraseña.Text.Length >= 6)
      {
        contraseña = txtContraseña.Text;
        sb.AppendFormat("Contraseña: ******");
        lblErrorContraseña.Visible = false;
      }
      else
      {
        lblErrorContraseña.Visible = true;
      }
    }

    private void lblContraseña_Click(object sender, EventArgs e)
    {

    }

    private void lblErrorNumero_Click(object sender, EventArgs e)
    {

    }

    private void lblErrorContraseña_Click(object sender, EventArgs e)
    {

    }

    private void lblErrorDireccion_Click(object sender, EventArgs e)
    {

    }

    private void lblErrorNombre_Click(object sender, EventArgs e)
    {

    }

    private void lblErrorApellido_Click(object sender, EventArgs e)
    {

    }
  }
}

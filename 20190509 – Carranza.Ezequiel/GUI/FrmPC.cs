using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GUI
{
  public partial class FrmPC : Form
  {
    public Maquina maquina;

    public FrmPC()
    {
      InitializeComponent();
      maquina = new Maquina("");
    }

    private void FrmPC_Load(object sender, EventArgs e)
    {

    }

    private void txtMarca_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtModelo_TextChanged(object sender, EventArgs e)
    {

    }

    private void nudMemoria_ValueChanged(object sender, EventArgs e)
    {

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (txtMarca.Text != "" || txtModelo.Text != "")
      {
        PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);

        MessageBox.Show(maquina + placa);
      }
      txtModelo.ResetText();
      txtMarca.ResetText();
      nudMemoria.ResetText();
    }

    private void btnSacar_Click(object sender, EventArgs e)
    {
      PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);

      MessageBox.Show(maquina - placa);
      txtModelo.ResetText();
      txtMarca.ResetText();
      nudMemoria.ResetText();
    }

    private void btnSystemInfo_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = maquina.SystemInfo;
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}

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

namespace Sender
{
  public partial class FrmSender : Form
  {
    private ManejadorDeEmisores manejador;
    private List<Emisor.EProducto> productos;

    public FrmSender()
    {
      InitializeComponent();
      productos = new List<Emisor.EProducto>();
      manejador = new ManejadorDeEmisores("West Europe");
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      
    }
  }
}

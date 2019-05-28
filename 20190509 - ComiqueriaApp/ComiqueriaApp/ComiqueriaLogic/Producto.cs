using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public abstract class Producto
  {
    private Guid codigo;
    private string descripcion;
    private double precio;
    private int stock;

    public string Descripcion
    {
      get { return this.descripcion; }
    }

    public double Precio
    {
      get { return this.precio; }
    }

    public int Stock
    {
      get { return this.stock; }
      set
      {
        if (value >= 0)
        {
          this.stock = value;
        }
      }
    }

    protected Producto(string descripcion, int stock, double precio)
    {
      this.descripcion = descripcion;
      this.stock = stock;
      this.precio = precio;
      this.codigo = Guid.NewGuid();
    }

    public static explicit operator Guid(Producto p)
    {
      return p.codigo;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendFormat("Descripción: {0}\n", this.descripcion);
      sb.AppendFormat("Código: {0}\n", this.codigo);
      sb.AppendFormat("Precio: ${0}\n", this.precio);
      sb.AppendFormat("Stock: {0} unidades\n", this.stock);
      return sb.ToString();
    }
  }
}

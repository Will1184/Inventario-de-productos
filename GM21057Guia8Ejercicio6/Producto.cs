using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM21057Guia8Ejercicio6
{
    internal class Producto
    {
        private string nombreProducto, codigoDescuento;
        private double precioProducto;



        public Producto()
        {
        }
        public Producto(string codigodescuento)
        {
            this.codigoDescuento = codigodescuento;
        }
        public Producto(string nombreProducto, double precioProducto)
        {
      
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
        }
    

        public string GetCodigoDescuento()
        { return codigoDescuento; }


        public void SetCodigoDescuento(string value)
        { codigoDescuento = value; }


        public string GetNombreProducto()
        { return nombreProducto; }
        public void SetNombreProducto(string value)
        { nombreProducto = value; }

        public double GetPrecioProducto()
        { return precioProducto; }
        public void SetPrecioProducto(double value)
        { precioProducto = value; }

    
     
        public void TotalImprimir(double total, DataGridView dataGridTotal,Producto producto)
        {
            double ahorro = 0;
            double nuevoTotal = 0;
            int rowEscribire = 0;
          

            if (producto.GetCodigoDescuento() == "COMPRAFACIL")
            {
                ahorro = (25 * total) / 100;
                nuevoTotal = total - ahorro;

                dataGridTotal.Rows[rowEscribire].Cells[0].Value = nuevoTotal.ToString();
                dataGridTotal.Rows[rowEscribire].Cells[1].Value = ahorro.ToString();
            }
            else
            {
                dataGridTotal.Rows[rowEscribire].Cells[0].Value = total;
                dataGridTotal.Rows[rowEscribire].Cells[1].Value = ahorro.ToString();
            }
        }

        public void Imprimir(Producto producto, DataGridView dataGridProductos)
        {
            int rowEscribir = dataGridProductos.Rows.Add();
         
           

            dataGridProductos.Rows[rowEscribir].Cells[0].Value = producto.GetNombreProducto().ToString();
            dataGridProductos.Rows[rowEscribir].Cells[1].Value = producto.GetPrecioProducto().ToString();


            
        }
    }
}

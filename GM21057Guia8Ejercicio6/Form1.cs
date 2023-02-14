namespace GM21057Guia8Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double[] precioProductos = new double[3];
        private static int contador;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public  void borrar()
        {
            textBoxPrecio.Clear();
            textBoxProducto.Clear();
            textBoxCodigoDesc.Clear();
            
        }

        private void buttonIngresar_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto(textBoxProducto.Text, Convert.ToDouble(textBoxPrecio.Text));
            precioProductos[contador++] = Convert.ToDouble(textBoxPrecio.Text);
            producto.Imprimir(producto, dataGridProducto);
            borrar();
        }

     
        private void buttonIngresarCodigo_Click_1(object sender, EventArgs e)
        {
            double totalPagar=0;
            Producto producto = new Producto(textBoxCodigoDesc.Text);
          
            for (int i = 0; i < precioProductos.Length; i++)
            {
                totalPagar += precioProductos[i];
            }
            producto.TotalImprimir(totalPagar, dataGridTotal,producto);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
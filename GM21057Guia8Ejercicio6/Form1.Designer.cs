namespace GM21057Guia8Ejercicio6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonIngresarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoDesc = new System.Windows.Forms.TextBox();
            this.dataGridTotal = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.buttonIngresarCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodigoDesc);
            this.groupBox1.Controls.Add(this.dataGridTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxProducto);
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.dataGridProducto);
            this.groupBox1.Controls.Add(this.buttonIngresar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 388);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(112, 73);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(122, 23);
            this.textBoxPrecio.TabIndex = 27;
            // 
            // buttonIngresarCodigo
            // 
            this.buttonIngresarCodigo.Location = new System.Drawing.Point(288, 208);
            this.buttonIngresarCodigo.Name = "buttonIngresarCodigo";
            this.buttonIngresarCodigo.Size = new System.Drawing.Size(102, 23);
            this.buttonIngresarCodigo.TabIndex = 26;
            this.buttonIngresarCodigo.Text = "Imprimir Total";
            this.buttonIngresarCodigo.UseVisualStyleBackColor = true;
            this.buttonIngresarCodigo.Click += new System.EventHandler(this.buttonIngresarCodigo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese codigo de Descuento";
            // 
            // textBoxCodigoDesc
            // 
            this.textBoxCodigoDesc.Location = new System.Drawing.Point(281, 165);
            this.textBoxCodigoDesc.Name = "textBoxCodigoDesc";
            this.textBoxCodigoDesc.Size = new System.Drawing.Size(122, 23);
            this.textBoxCodigoDesc.TabIndex = 24;
            // 
            // dataGridTotal
            // 
            this.dataGridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total,
            this.ahorro});
            this.dataGridTotal.Location = new System.Drawing.Point(9, 291);
            this.dataGridTotal.Name = "dataGridTotal";
            this.dataGridTotal.RowTemplate.Height = 25;
            this.dataGridTotal.Size = new System.Drawing.Size(242, 76);
            this.dataGridTotal.TabIndex = 23;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // ahorro
            // 
            this.ahorro.HeaderText = "Ahorro";
            this.ahorro.Name = "ahorro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ingrese Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese Producto";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(112, 22);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(122, 23);
            this.textBoxProducto.TabIndex = 19;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(269, 71);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulo,
            this.precio});
            this.dataGridProducto.Location = new System.Drawing.Point(9, 125);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RowTemplate.Height = 25;
            this.dataGridProducto.Size = new System.Drawing.Size(242, 160);
            this.dataGridProducto.TabIndex = 6;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Articulo";
            this.articulo.Name = "articulo";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(269, 20);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 420);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Les juro que esta Fresco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label2;
        private ComboBox comboBoxProducto;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxCodigoDesc;
        private DataGridView dataGridTotal;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn ahorro;
        private Label label5;
        private Label label4;
        private TextBox textBoxProducto;
        private Button buttonSalir;
        private DataGridView dataGridProducto;
        private Button buttonIngresar;
        private DataGridViewTextBoxColumn articulo;
        private DataGridViewTextBoxColumn precio;
        private Button buttonIngresarCodigo;
        private TextBox textBoxPrecio;
    }
}
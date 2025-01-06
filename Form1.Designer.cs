namespace BibliotecaMySQL2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbYearEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbNumeroEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbCantidadPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbCantidadImpresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxImpresos = new System.Windows.Forms.TextBox();
            this.textBoxPaginas = new System.Windows.Forms.TextBox();
            this.textBoxIdioma = new System.Windows.Forms.TextBox();
            this.textBoxVenta = new System.Windows.Forms.TextBox();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.textBoxNumeroEdicion = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxFechaPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.textBoxidLibro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 60;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbId,
            this.dbTitulo,
            this.dbAutor,
            this.dbEditorial,
            this.dbISBN,
            this.dbYearEdicion,
            this.dbGenero,
            this.dbNumeroEdicion,
            this.dbPrecioCompra,
            this.dbPrecioVenta,
            this.dbIdioma,
            this.dbCantidadPaginas,
            this.dbCantidadImpresos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(142)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.Sienna;
            this.dgvProductos.Location = new System.Drawing.Point(12, 397);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(164)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.Size = new System.Drawing.Size(1123, 275);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // dbId
            // 
            this.dbId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dbId.HeaderText = "Id";
            this.dbId.Name = "dbId";
            this.dbId.Width = 30;
            // 
            // dbTitulo
            // 
            this.dbTitulo.HeaderText = "Titulo";
            this.dbTitulo.Name = "dbTitulo";
            this.dbTitulo.Width = 120;
            // 
            // dbAutor
            // 
            this.dbAutor.HeaderText = "Autor";
            this.dbAutor.Name = "dbAutor";
            // 
            // dbEditorial
            // 
            this.dbEditorial.HeaderText = "Editorial";
            this.dbEditorial.Name = "dbEditorial";
            // 
            // dbISBN
            // 
            this.dbISBN.HeaderText = "ISBN";
            this.dbISBN.Name = "dbISBN";
            // 
            // dbYearEdicion
            // 
            this.dbYearEdicion.HeaderText = "Año de Edición";
            this.dbYearEdicion.Name = "dbYearEdicion";
            // 
            // dbGenero
            // 
            this.dbGenero.HeaderText = "Genero";
            this.dbGenero.Name = "dbGenero";
            // 
            // dbNumeroEdicion
            // 
            this.dbNumeroEdicion.HeaderText = "Número de Edición";
            this.dbNumeroEdicion.MinimumWidth = 2;
            this.dbNumeroEdicion.Name = "dbNumeroEdicion";
            this.dbNumeroEdicion.Width = 60;
            // 
            // dbPrecioCompra
            // 
            this.dbPrecioCompra.HeaderText = "Precio de Compra";
            this.dbPrecioCompra.Name = "dbPrecioCompra";
            this.dbPrecioCompra.Width = 60;
            // 
            // dbPrecioVenta
            // 
            this.dbPrecioVenta.HeaderText = "Precio de Venta";
            this.dbPrecioVenta.Name = "dbPrecioVenta";
            this.dbPrecioVenta.Width = 60;
            // 
            // dbIdioma
            // 
            this.dbIdioma.HeaderText = "Idioma";
            this.dbIdioma.Name = "dbIdioma";
            this.dbIdioma.Width = 70;
            // 
            // dbCantidadPaginas
            // 
            this.dbCantidadPaginas.HeaderText = "Páginas";
            this.dbCantidadPaginas.Name = "dbCantidadPaginas";
            this.dbCantidadPaginas.Width = 80;
            // 
            // dbCantidadImpresos
            // 
            this.dbCantidadImpresos.HeaderText = "Cantidad Impresos";
            this.dbCantidadImpresos.Name = "dbCantidadImpresos";
            this.dbCantidadImpresos.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenero.Location = new System.Drawing.Point(110, 343);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(230, 21);
            this.textBoxGenero.TabIndex = 2;
            this.textBoxGenero.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBoxImpresos
            // 
            this.textBoxImpresos.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxImpresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImpresos.Location = new System.Drawing.Point(561, 343);
            this.textBoxImpresos.Name = "textBoxImpresos";
            this.textBoxImpresos.Size = new System.Drawing.Size(230, 21);
            this.textBoxImpresos.TabIndex = 4;
            this.textBoxImpresos.TextChanged += new System.EventHandler(this.textBoxImpresos_TextChanged);
            // 
            // textBoxPaginas
            // 
            this.textBoxPaginas.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaginas.Location = new System.Drawing.Point(561, 303);
            this.textBoxPaginas.Name = "textBoxPaginas";
            this.textBoxPaginas.Size = new System.Drawing.Size(230, 21);
            this.textBoxPaginas.TabIndex = 5;
            this.textBoxPaginas.TextChanged += new System.EventHandler(this.textBoxPaginas_TextChanged);
            // 
            // textBoxIdioma
            // 
            this.textBoxIdioma.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdioma.Location = new System.Drawing.Point(561, 263);
            this.textBoxIdioma.Name = "textBoxIdioma";
            this.textBoxIdioma.Size = new System.Drawing.Size(230, 21);
            this.textBoxIdioma.TabIndex = 6;
            this.textBoxIdioma.TextChanged += new System.EventHandler(this.textBoxIdioma_TextChanged);
            // 
            // textBoxVenta
            // 
            this.textBoxVenta.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVenta.Location = new System.Drawing.Point(561, 223);
            this.textBoxVenta.Name = "textBoxVenta";
            this.textBoxVenta.Size = new System.Drawing.Size(230, 21);
            this.textBoxVenta.TabIndex = 7;
            this.textBoxVenta.TextChanged += new System.EventHandler(this.textBoxVenta_TextChanged);
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompra.Location = new System.Drawing.Point(561, 183);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(230, 21);
            this.textBoxCompra.TabIndex = 8;
            this.textBoxCompra.TextChanged += new System.EventHandler(this.textBoxCompra_TextChanged);
            // 
            // textBoxNumeroEdicion
            // 
            this.textBoxNumeroEdicion.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxNumeroEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroEdicion.Location = new System.Drawing.Point(561, 143);
            this.textBoxNumeroEdicion.Name = "textBoxNumeroEdicion";
            this.textBoxNumeroEdicion.Size = new System.Drawing.Size(230, 21);
            this.textBoxNumeroEdicion.TabIndex = 9;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(110, 143);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(230, 21);
            this.textBoxTitulo.TabIndex = 10;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutor.Location = new System.Drawing.Point(110, 183);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(230, 21);
            this.textBoxAutor.TabIndex = 11;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditorial.Location = new System.Drawing.Point(110, 223);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(230, 21);
            this.textBoxEditorial.TabIndex = 12;
            this.textBoxEditorial.TextChanged += new System.EventHandler(this.textBoxEditorial_TextChanged);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(110, 263);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(230, 21);
            this.textBoxISBN.TabIndex = 13;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // textBoxFechaPublicacion
            // 
            this.textBoxFechaPublicacion.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxFechaPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaPublicacion.Location = new System.Drawing.Point(110, 303);
            this.textBoxFechaPublicacion.Name = "textBoxFechaPublicacion";
            this.textBoxFechaPublicacion.Size = new System.Drawing.Size(230, 21);
            this.textBoxFechaPublicacion.TabIndex = 14;
            this.textBoxFechaPublicacion.TextChanged += new System.EventHandler(this.textBoxFechaPublicacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero de Edicion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cantidad Impresos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad de Paginas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Idioma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Precio de Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(404, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Precio de Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Genero";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 38);
            this.label11.TabIndex = 23;
            this.label11.Text = "Año de Edicion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "ISBN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Editorial";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Autor";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Titulo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.PeachPuff;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(988, 169);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(117, 39);
            this.botonAgregar.TabIndex = 28;
            this.botonAgregar.Text = "Agregar Libro";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(988, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 29;
            this.button2.Text = "Eliminar Libro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(988, 231);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(117, 39);
            this.btn_Modificar.TabIndex = 30;
            this.btn_Modificar.Text = "Modificar Libro";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // textBoxidLibro
            // 
            this.textBoxidLibro.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxidLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxidLibro.Location = new System.Drawing.Point(110, 107);
            this.textBoxidLibro.Name = "textBoxidLibro";
            this.textBoxidLibro.Size = new System.Drawing.Size(37, 21);
            this.textBoxidLibro.TabIndex = 31;
            this.textBoxidLibro.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(193)))), ((int)(((byte)(143)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(434, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD Biblioteca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(82, 3);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(254, 21);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 28);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(811, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 49);
            this.label16.TabIndex = 37;
            this.label16.Text = "Araujo •   Andrada •   Belizan •   Casafus Duarte • Gaona • Maciel • Molina •More" +
    "\r\n";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BibliotecaMySQL2.Properties.Resources.library_book_svgrepo_com;
            this.pictureBox4.Location = new System.Drawing.Point(1067, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BibliotecaMySQL2.Properties.Resources.delete_alt_svgrepo_com_1_;
            this.pictureBox3.Location = new System.Drawing.Point(944, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BibliotecaMySQL2.Properties.Resources.edit_2_svgrepo_com;
            this.pictureBox2.Location = new System.Drawing.Point(944, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(944, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BibliotecaMySQL2.Properties.Resources.header1;
            this.pictureBox5.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1165, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 674);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxidLibro);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFechaPublicacion);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxEditorial);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxNumeroEdicion);
            this.Controls.Add(this.textBoxCompra);
            this.Controls.Add(this.textBoxVenta);
            this.Controls.Add(this.textBoxIdioma);
            this.Controls.Add(this.textBoxPaginas);
            this.Controls.Add(this.textBoxImpresos);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Biblioteca Grupo F CUDI 2A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxImpresos;
        private System.Windows.Forms.TextBox textBoxPaginas;
        private System.Windows.Forms.TextBox textBoxIdioma;
        private System.Windows.Forms.TextBox textBoxVenta;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.TextBox textBoxNumeroEdicion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxEditorial;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxFechaPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox textBoxidLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbYearEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbNumeroEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbCantidadPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbCantidadImpresos;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}


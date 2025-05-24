namespace HuellaAnimalia
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_ventaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nombre_clienteLabel;
            System.Windows.Forms.Label apellido_clienteLabel;
            System.Windows.Forms.Label dni_clienteLabel;
            System.Windows.Forms.Label fecha_ventaLabel;
            System.Windows.Forms.Label notas_ventaLabel;
            System.Windows.Forms.Label metodo_pago_ventaLabel;
            System.Windows.Forms.Label descuento_ventaLabel;
            System.Windows.Forms.Label impuestos_ventaLabel;
            System.Windows.Forms.Label total_sin_impuestos_ventaLabel;
            System.Windows.Forms.Label total_ventaLabel;
            System.Windows.Forms.Label id_ventaLabel1;
            System.Windows.Forms.Label id_productoLabel;
            System.Windows.Forms.Label nombre_productoLabel;
            System.Windows.Forms.Label categoria_productoLabel;
            System.Windows.Forms.Label cantidad_productoLabel;
            System.Windows.Forms.Label precio_venta_productoLabel;
            System.Windows.Forms.Label total_linea_detalle_ventaLabel;
            System.Windows.Forms.Label marca_productoLabel;
            System.Windows.Forms.Label id_clienteLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.nombre_clienteTextBox = new System.Windows.Forms.TextBox();
            this.apellido_clienteTextBox = new System.Windows.Forms.TextBox();
            this.dni_clienteTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notas_ventaTextBox = new System.Windows.Forms.TextBox();
            this.descuento_ventaTextBox = new System.Windows.Forms.TextBox();
            this.impuestos_ventaTextBox = new System.Windows.Forms.TextBox();
            this.total_sin_impuestos_ventaTextBox = new System.Windows.Forms.TextBox();
            this.total_ventaTextBox = new System.Windows.Forms.TextBox();
            this.labelVenta = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_imprimir = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_aniadir = new System.Windows.Forms.Button();
            this.button_ultimo = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_anterior = new System.Windows.Forms.Button();
            this.button_primero = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.comboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_ventaLabel2 = new System.Windows.Forms.Label();
            this.id_productoComboBox = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombre_productoTextBox = new System.Windows.Forms.TextBox();
            this.categoria_productoComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidad_productoTextBox = new System.Windows.Forms.TextBox();
            this.precio_venta_productoTextBox = new System.Windows.Forms.TextBox();
            this.total_linea_detalle_ventaTextBox = new System.Windows.Forms.TextBox();
            this.button_cancelar_detalle = new System.Windows.Forms.Button();
            this.button_aceptar_detalle = new System.Windows.Forms.Button();
            this.marca_productoTextBox = new System.Windows.Forms.TextBox();
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_eliminar_detalle = new System.Windows.Forms.Button();
            this.button_aniadir_detalle = new System.Windows.Forms.Button();
            this.button_ultimo_detalle = new System.Windows.Forms.Button();
            this.button_siguiente_detalle = new System.Windows.Forms.Button();
            this.button_anterior_detalle = new System.Windows.Forms.Button();
            this.button_primero_detalle = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idVentaLabel = new System.Windows.Forms.Label();
            this.button_terminar = new System.Windows.Forms.Button();
            this.ventaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.detalleVentaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.DetalleVentaTableAdapter();
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ClienteTableAdapter();
            this.productoTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ProductoTableAdapter();
            this.categoriaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.button_editar_detalle = new System.Windows.Forms.Button();
            this.labelEuros2 = new System.Windows.Forms.Label();
            this.labelPorcentaje2 = new System.Windows.Forms.Label();
            this.labelEuros1 = new System.Windows.Forms.Label();
            this.labelPorcentaje1 = new System.Windows.Forms.Label();
            this.labelEuros4 = new System.Windows.Forms.Label();
            this.labelEuros3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_ventaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            nombre_clienteLabel = new System.Windows.Forms.Label();
            apellido_clienteLabel = new System.Windows.Forms.Label();
            dni_clienteLabel = new System.Windows.Forms.Label();
            fecha_ventaLabel = new System.Windows.Forms.Label();
            notas_ventaLabel = new System.Windows.Forms.Label();
            metodo_pago_ventaLabel = new System.Windows.Forms.Label();
            descuento_ventaLabel = new System.Windows.Forms.Label();
            impuestos_ventaLabel = new System.Windows.Forms.Label();
            total_sin_impuestos_ventaLabel = new System.Windows.Forms.Label();
            total_ventaLabel = new System.Windows.Forms.Label();
            id_ventaLabel1 = new System.Windows.Forms.Label();
            id_productoLabel = new System.Windows.Forms.Label();
            nombre_productoLabel = new System.Windows.Forms.Label();
            categoria_productoLabel = new System.Windows.Forms.Label();
            cantidad_productoLabel = new System.Windows.Forms.Label();
            precio_venta_productoLabel = new System.Windows.Forms.Label();
            total_linea_detalle_ventaLabel = new System.Windows.Forms.Label();
            marca_productoLabel = new System.Windows.Forms.Label();
            id_clienteLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ventaLabel
            // 
            id_ventaLabel.AutoSize = true;
            id_ventaLabel.Location = new System.Drawing.Point(18, 18);
            id_ventaLabel.Name = "id_ventaLabel";
            id_ventaLabel.Size = new System.Drawing.Size(88, 13);
            id_ventaLabel.TabIndex = 1;
            id_ventaLabel.Text = "Códigode  venta:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(23, 182);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(53, 13);
            id_clienteLabel.TabIndex = 3;
            id_clienteLabel.Text = "Id cliente:";
            id_clienteLabel.Visible = false;
            // 
            // nombre_clienteLabel
            // 
            nombre_clienteLabel.AutoSize = true;
            nombre_clienteLabel.Location = new System.Drawing.Point(268, 181);
            nombre_clienteLabel.Name = "nombre_clienteLabel";
            nombre_clienteLabel.Size = new System.Drawing.Size(81, 13);
            nombre_clienteLabel.TabIndex = 5;
            nombre_clienteLabel.Text = "Nombre cliente:";
            nombre_clienteLabel.Visible = false;
            // 
            // apellido_clienteLabel
            // 
            apellido_clienteLabel.AutoSize = true;
            apellido_clienteLabel.Location = new System.Drawing.Point(138, 182);
            apellido_clienteLabel.Name = "apellido_clienteLabel";
            apellido_clienteLabel.Size = new System.Drawing.Size(81, 13);
            apellido_clienteLabel.TabIndex = 7;
            apellido_clienteLabel.Text = "Apellido cliente:";
            apellido_clienteLabel.Visible = false;
            // 
            // dni_clienteLabel
            // 
            dni_clienteLabel.AutoSize = true;
            dni_clienteLabel.Location = new System.Drawing.Point(18, 71);
            dni_clienteLabel.Name = "dni_clienteLabel";
            dni_clienteLabel.Size = new System.Drawing.Size(80, 13);
            dni_clienteLabel.TabIndex = 9;
            dni_clienteLabel.Text = "DNI del cliente:";
            this.toolTip1.SetToolTip(dni_clienteLabel, "Introduce el DNI del cliente");
            // 
            // fecha_ventaLabel
            // 
            fecha_ventaLabel.AutoSize = true;
            fecha_ventaLabel.Location = new System.Drawing.Point(18, 98);
            fecha_ventaLabel.Name = "fecha_ventaLabel";
            fecha_ventaLabel.Size = new System.Drawing.Size(85, 13);
            fecha_ventaLabel.TabIndex = 13;
            fecha_ventaLabel.Text = "Fecha de venta:";
            this.toolTip1.SetToolTip(fecha_ventaLabel, "Selecciona la fecha de venta");
            // 
            // notas_ventaLabel
            // 
            notas_ventaLabel.AutoSize = true;
            notas_ventaLabel.Location = new System.Drawing.Point(18, 123);
            notas_ventaLabel.Name = "notas_ventaLabel";
            notas_ventaLabel.Size = new System.Drawing.Size(38, 13);
            notas_ventaLabel.TabIndex = 15;
            notas_ventaLabel.Text = "Notas:";
            // 
            // metodo_pago_ventaLabel
            // 
            metodo_pago_ventaLabel.AutoSize = true;
            metodo_pago_ventaLabel.Location = new System.Drawing.Point(445, 18);
            metodo_pago_ventaLabel.Name = "metodo_pago_ventaLabel";
            metodo_pago_ventaLabel.Size = new System.Drawing.Size(88, 13);
            metodo_pago_ventaLabel.TabIndex = 17;
            metodo_pago_ventaLabel.Text = "Método de pago:";
            metodo_pago_ventaLabel.Click += new System.EventHandler(this.metodo_pago_ventaLabel_Click);
            // 
            // descuento_ventaLabel
            // 
            descuento_ventaLabel.AutoSize = true;
            descuento_ventaLabel.Location = new System.Drawing.Point(445, 45);
            descuento_ventaLabel.Name = "descuento_ventaLabel";
            descuento_ventaLabel.Size = new System.Drawing.Size(105, 13);
            descuento_ventaLabel.TabIndex = 19;
            descuento_ventaLabel.Text = "Descuento aplicado:";
            // 
            // impuestos_ventaLabel
            // 
            impuestos_ventaLabel.AutoSize = true;
            impuestos_ventaLabel.Location = new System.Drawing.Point(445, 71);
            impuestos_ventaLabel.Name = "impuestos_ventaLabel";
            impuestos_ventaLabel.Size = new System.Drawing.Size(106, 13);
            impuestos_ventaLabel.TabIndex = 21;
            impuestos_ventaLabel.Text = "Impuestos aplicados:";
            // 
            // total_sin_impuestos_ventaLabel
            // 
            total_sin_impuestos_ventaLabel.AutoSize = true;
            total_sin_impuestos_ventaLabel.Location = new System.Drawing.Point(445, 97);
            total_sin_impuestos_ventaLabel.Name = "total_sin_impuestos_ventaLabel";
            total_sin_impuestos_ventaLabel.Size = new System.Drawing.Size(100, 13);
            total_sin_impuestos_ventaLabel.TabIndex = 23;
            total_sin_impuestos_ventaLabel.Text = "Total sin impuestos:";
            // 
            // total_ventaLabel
            // 
            total_ventaLabel.AutoSize = true;
            total_ventaLabel.Location = new System.Drawing.Point(445, 123);
            total_ventaLabel.Name = "total_ventaLabel";
            total_ventaLabel.Size = new System.Drawing.Size(90, 13);
            total_ventaLabel.TabIndex = 25;
            total_ventaLabel.Text = "Total de la venta:";
            // 
            // id_ventaLabel1
            // 
            id_ventaLabel1.AutoSize = true;
            id_ventaLabel1.Location = new System.Drawing.Point(402, 36);
            id_ventaLabel1.Name = "id_ventaLabel1";
            id_ventaLabel1.Size = new System.Drawing.Size(49, 13);
            id_ventaLabel1.TabIndex = 58;
            id_ventaLabel1.Text = "Id venta:";
            id_ventaLabel1.Visible = false;
            // 
            // id_productoLabel
            // 
            id_productoLabel.AutoSize = true;
            id_productoLabel.Location = new System.Drawing.Point(20, 96);
            id_productoLabel.Name = "id_productoLabel";
            id_productoLabel.Size = new System.Drawing.Size(53, 13);
            id_productoLabel.TabIndex = 64;
            id_productoLabel.Text = "Producto:";
            id_productoLabel.Click += new System.EventHandler(this.id_productoLabel_Click);
            // 
            // nombre_productoLabel
            // 
            nombre_productoLabel.AutoSize = true;
            nombre_productoLabel.Location = new System.Drawing.Point(659, 36);
            nombre_productoLabel.Name = "nombre_productoLabel";
            nombre_productoLabel.Size = new System.Drawing.Size(92, 13);
            nombre_productoLabel.TabIndex = 62;
            nombre_productoLabel.Text = "Nombre producto:";
            nombre_productoLabel.Visible = false;
            // 
            // categoria_productoLabel
            // 
            categoria_productoLabel.AutoSize = true;
            categoria_productoLabel.Location = new System.Drawing.Point(20, 73);
            categoria_productoLabel.Name = "categoria_productoLabel";
            categoria_productoLabel.Size = new System.Drawing.Size(55, 13);
            categoria_productoLabel.TabIndex = 60;
            categoria_productoLabel.Text = "Categoria:";
            categoria_productoLabel.Click += new System.EventHandler(this.categoria_productoLabel_Click);
            // 
            // cantidad_productoLabel
            // 
            cantidad_productoLabel.AutoSize = true;
            cantidad_productoLabel.Location = new System.Drawing.Point(286, 70);
            cantidad_productoLabel.Name = "cantidad_productoLabel";
            cantidad_productoLabel.Size = new System.Drawing.Size(52, 13);
            cantidad_productoLabel.TabIndex = 66;
            cantidad_productoLabel.Text = "Cantidad:";
            cantidad_productoLabel.Click += new System.EventHandler(this.cantidad_productoLabel_Click);
            // 
            // precio_venta_productoLabel
            // 
            precio_venta_productoLabel.AutoSize = true;
            precio_venta_productoLabel.Location = new System.Drawing.Point(552, 70);
            precio_venta_productoLabel.Name = "precio_venta_productoLabel";
            precio_venta_productoLabel.Size = new System.Drawing.Size(77, 13);
            precio_venta_productoLabel.TabIndex = 68;
            precio_venta_productoLabel.Text = "Precio unitario:";
            // 
            // total_linea_detalle_ventaLabel
            // 
            total_linea_detalle_ventaLabel.AutoSize = true;
            total_linea_detalle_ventaLabel.Location = new System.Drawing.Point(552, 96);
            total_linea_detalle_ventaLabel.Name = "total_linea_detalle_ventaLabel";
            total_linea_detalle_ventaLabel.Size = new System.Drawing.Size(59, 13);
            total_linea_detalle_ventaLabel.TabIndex = 70;
            total_linea_detalle_ventaLabel.Text = "Total linea:";
            // 
            // marca_productoLabel
            // 
            marca_productoLabel.AutoSize = true;
            marca_productoLabel.Location = new System.Drawing.Point(286, 97);
            marca_productoLabel.Name = "marca_productoLabel";
            marca_productoLabel.Size = new System.Drawing.Size(40, 13);
            marca_productoLabel.TabIndex = 73;
            marca_productoLabel.Text = "Marca:";
            // 
            // id_clienteLabel1
            // 
            id_clienteLabel1.AutoSize = true;
            id_clienteLabel1.Location = new System.Drawing.Point(18, 44);
            id_clienteLabel1.Name = "id_clienteLabel1";
            id_clienteLabel1.Size = new System.Drawing.Size(98, 13);
            id_clienteLabel1.TabIndex = 83;
            id_clienteLabel1.Text = "Nombre del cliente:";
            id_clienteLabel1.Click += new System.EventHandler(this.id_clienteLabel1_Click);
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(82, 179);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(34, 20);
            this.id_clienteTextBox.TabIndex = 4;
            this.id_clienteTextBox.Visible = false;
            this.id_clienteTextBox.TextChanged += new System.EventHandler(this.id_clienteTextBox_TextChanged);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_clienteTextBox
            // 
            this.nombre_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Nombre_cliente", true));
            this.nombre_clienteTextBox.Location = new System.Drawing.Point(569, 33);
            this.nombre_clienteTextBox.Name = "nombre_clienteTextBox";
            this.nombre_clienteTextBox.Size = new System.Drawing.Size(34, 20);
            this.nombre_clienteTextBox.TabIndex = 6;
            this.nombre_clienteTextBox.Visible = false;
            // 
            // apellido_clienteTextBox
            // 
            this.apellido_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Apellido_cliente", true));
            this.apellido_clienteTextBox.Location = new System.Drawing.Point(457, 33);
            this.apellido_clienteTextBox.Name = "apellido_clienteTextBox";
            this.apellido_clienteTextBox.Size = new System.Drawing.Size(32, 20);
            this.apellido_clienteTextBox.TabIndex = 8;
            this.apellido_clienteTextBox.Visible = false;
            // 
            // dni_clienteTextBox
            // 
            this.dni_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Dni_cliente", true));
            this.dni_clienteTextBox.Location = new System.Drawing.Point(154, 68);
            this.dni_clienteTextBox.Name = "dni_clienteTextBox";
            this.dni_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.dni_clienteTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dni_clienteTextBox, "Introduce el DNI del cliente");
            this.dni_clienteTextBox.TextChanged += new System.EventHandler(this.dni_clienteTextBox_TextChanged);
            this.dni_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dni_clienteTextBox_Validating);
            // 
            // fecha_ventaDateTimePicker
            // 
            this.fecha_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "Fecha_venta", true));
            this.fecha_ventaDateTimePicker.Location = new System.Drawing.Point(154, 94);
            this.fecha_ventaDateTimePicker.Name = "fecha_ventaDateTimePicker";
            this.fecha_ventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ventaDateTimePicker.TabIndex = 15;
            this.toolTip1.SetToolTip(this.fecha_ventaDateTimePicker, "Selecciona la fecha de venta");
            this.fecha_ventaDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_ventaDateTimePicker_ValueChanged);
            this.fecha_ventaDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.fecha_ventaDateTimePicker_Validating);
            // 
            // notas_ventaTextBox
            // 
            this.notas_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Notas_venta", true));
            this.notas_ventaTextBox.Location = new System.Drawing.Point(154, 120);
            this.notas_ventaTextBox.Multiline = true;
            this.notas_ventaTextBox.Name = "notas_ventaTextBox";
            this.notas_ventaTextBox.Size = new System.Drawing.Size(200, 60);
            this.notas_ventaTextBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.notas_ventaTextBox, "Opcional: Introduce notas de la venta");
            // 
            // descuento_ventaTextBox
            // 
            this.descuento_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Descuento_venta", true));
            this.descuento_ventaTextBox.Location = new System.Drawing.Point(578, 42);
            this.descuento_ventaTextBox.Name = "descuento_ventaTextBox";
            this.descuento_ventaTextBox.Size = new System.Drawing.Size(179, 20);
            this.descuento_ventaTextBox.TabIndex = 18;
            this.descuento_ventaTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.descuento_ventaTextBox, "Opcional: Introduce el descuento aplicado. Por defecto es cero.");
            this.descuento_ventaTextBox.TextChanged += new System.EventHandler(this.descuento_ventaTextBox_TextChanged);
            // 
            // impuestos_ventaTextBox
            // 
            this.impuestos_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Impuestos_venta", true));
            this.impuestos_ventaTextBox.Location = new System.Drawing.Point(578, 68);
            this.impuestos_ventaTextBox.Name = "impuestos_ventaTextBox";
            this.impuestos_ventaTextBox.Size = new System.Drawing.Size(179, 20);
            this.impuestos_ventaTextBox.TabIndex = 19;
            this.impuestos_ventaTextBox.Text = "21";
            this.toolTip1.SetToolTip(this.impuestos_ventaTextBox, "Selecciona el tipo de impuesto. Por defecto es 21%");
            this.impuestos_ventaTextBox.TextChanged += new System.EventHandler(this.impuestos_ventaTextBox_TextChanged);
            this.impuestos_ventaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.impuestos_ventaTextBox_Validating);
            // 
            // total_sin_impuestos_ventaTextBox
            // 
            this.total_sin_impuestos_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Total_sin_impuestos_venta", true));
            this.total_sin_impuestos_ventaTextBox.Location = new System.Drawing.Point(578, 94);
            this.total_sin_impuestos_ventaTextBox.Name = "total_sin_impuestos_ventaTextBox";
            this.total_sin_impuestos_ventaTextBox.ReadOnly = true;
            this.total_sin_impuestos_ventaTextBox.Size = new System.Drawing.Size(179, 20);
            this.total_sin_impuestos_ventaTextBox.TabIndex = 24;
            this.total_sin_impuestos_ventaTextBox.TextChanged += new System.EventHandler(this.total_sin_impuestos_ventaTextBox_TextChanged);
            // 
            // total_ventaTextBox
            // 
            this.total_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Total_venta", true));
            this.total_ventaTextBox.Location = new System.Drawing.Point(578, 120);
            this.total_ventaTextBox.Name = "total_ventaTextBox";
            this.total_ventaTextBox.ReadOnly = true;
            this.total_ventaTextBox.Size = new System.Drawing.Size(179, 20);
            this.total_ventaTextBox.TabIndex = 26;
            // 
            // labelVenta
            // 
            this.labelVenta.AutoSize = true;
            this.labelVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenta.ForeColor = System.Drawing.Color.White;
            this.labelVenta.Location = new System.Drawing.Point(3, 2);
            this.labelVenta.Name = "labelVenta";
            this.labelVenta.Size = new System.Drawing.Size(50, 18);
            this.labelVenta.TabIndex = 55;
            this.labelVenta.Text = "Venta";
            this.labelVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVenta.Click += new System.EventHandler(this.labelVenta_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 50);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxBuscar, "Introduce los datos a buscar, según el criterio de búsqueda seleccionado");
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Nº venta"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 22);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: Nº venta");
            // 
            // button_buscar
            // 
            this.button_buscar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_search;
            this.button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_buscar.FlatAppearance.BorderSize = 0;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar.Location = new System.Drawing.Point(133, 22);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(45, 45);
            this.button_buscar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar venta (Alt + F)");
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_print;
            this.button_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_imprimir.FlatAppearance.BorderSize = 0;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(548, 12);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(45, 45);
            this.button_imprimir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button_imprimir, "Imprimir informe (Alt + P)");
            this.button_imprimir.UseVisualStyleBackColor = true;
            this.button_imprimir.Click += new System.EventHandler(this.button_imprimir_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_save;
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_guardar.FlatAppearance.BorderSize = 0;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guardar.Location = new System.Drawing.Point(497, 12);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(45, 45);
            this.button_guardar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar datos en la base de datos (Alt + S)");
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_edit;
            this.button_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_editar.FlatAppearance.BorderSize = 0;
            this.button_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar.Location = new System.Drawing.Point(446, 12);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(45, 45);
            this.button_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_editar, "Editar venta actual (Alt + E)");
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Location = new System.Drawing.Point(395, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(45, 45);
            this.button_eliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar venta actual (Alt + D)");
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aniadir
            // 
            this.button_aniadir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir.FlatAppearance.BorderSize = 0;
            this.button_aniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir.Location = new System.Drawing.Point(344, 12);
            this.button_aniadir.Name = "button_aniadir";
            this.button_aniadir.Size = new System.Drawing.Size(45, 45);
            this.button_aniadir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir nueva venta (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(193, 12);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir a la última venta (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(142, 12);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir a la siguiente venta (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(91, 12);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir a la venta anterior (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Location = new System.Drawing.Point(40, 12);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir a la primera venta (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(733, 161);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button_cancelar, "Cancelar edición del formulario de venta (Alt + C)");
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_accept;
            this.button_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aceptar.FlatAppearance.BorderSize = 0;
            this.button_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar.Location = new System.Drawing.Point(663, 161);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button_aceptar, "Validar formulario de venta (Alt + Enter)");
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // comboBoxMetodoPago
            // 
            this.comboBoxMetodoPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Metodo_pago_venta", true));
            this.comboBoxMetodoPago.FormattingEnabled = true;
            this.comboBoxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.comboBoxMetodoPago.Location = new System.Drawing.Point(578, 15);
            this.comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            this.comboBoxMetodoPago.Size = new System.Drawing.Size(198, 21);
            this.comboBoxMetodoPago.TabIndex = 17;
            this.toolTip1.SetToolTip(this.comboBoxMetodoPago, "Selecciona el método de pago");
            this.comboBoxMetodoPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodoPago_SelectedIndexChanged);
            this.comboBoxMetodoPago.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMetodoPago_Validating);
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "Venta_DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.ventaBindingSource;
            this.detalleVentaBindingSource.CurrentChanged += new System.EventHandler(this.detalleVentaBindingSource_CurrentChanged);
            // 
            // id_ventaLabel2
            // 
            this.id_ventaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Id_venta", true));
            this.id_ventaLabel2.Location = new System.Drawing.Point(528, 36);
            this.id_ventaLabel2.Name = "id_ventaLabel2";
            this.id_ventaLabel2.Size = new System.Drawing.Size(121, 23);
            this.id_ventaLabel2.TabIndex = 59;
            this.id_ventaLabel2.Text = "label1";
            this.id_ventaLabel2.Visible = false;
            // 
            // id_productoComboBox
            // 
            this.id_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detalleVentaBindingSource, "id_producto", true));
            this.id_productoComboBox.DataSource = this.productoBindingSource;
            this.id_productoComboBox.DisplayMember = "Nombre_producto";
            this.id_productoComboBox.FormattingEnabled = true;
            this.id_productoComboBox.Location = new System.Drawing.Point(91, 93);
            this.id_productoComboBox.Name = "id_productoComboBox";
            this.id_productoComboBox.Size = new System.Drawing.Size(130, 21);
            this.id_productoComboBox.TabIndex = 29;
            this.toolTip1.SetToolTip(this.id_productoComboBox, "Selecciona el nombre del producto");
            this.id_productoComboBox.ValueMember = "Id_producto";
            this.id_productoComboBox.SelectedIndexChanged += new System.EventHandler(this.id_productoComboBox_SelectedIndexChanged);
            this.id_productoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_productoComboBox_Validating);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.database1DataSet;
            // 
            // nombre_productoTextBox
            // 
            this.nombre_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Nombre_producto", true));
            this.nombre_productoTextBox.Location = new System.Drawing.Point(594, 163);
            this.nombre_productoTextBox.Name = "nombre_productoTextBox";
            this.nombre_productoTextBox.Size = new System.Drawing.Size(94, 20);
            this.nombre_productoTextBox.TabIndex = 63;
            // 
            // categoria_productoComboBox
            // 
            this.categoria_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detalleVentaBindingSource, "Categoria_producto", true));
            this.categoria_productoComboBox.DataSource = this.categoriaBindingSource;
            this.categoria_productoComboBox.DisplayMember = "Nombre_categoria";
            this.categoria_productoComboBox.FormattingEnabled = true;
            this.categoria_productoComboBox.Location = new System.Drawing.Point(91, 67);
            this.categoria_productoComboBox.Name = "categoria_productoComboBox";
            this.categoria_productoComboBox.Size = new System.Drawing.Size(130, 21);
            this.categoria_productoComboBox.TabIndex = 28;
            this.toolTip1.SetToolTip(this.categoria_productoComboBox, "Selecciona la categoría del producto");
            this.categoria_productoComboBox.ValueMember = "Nombre_categoria";
            this.categoria_productoComboBox.SelectedIndexChanged += new System.EventHandler(this.categoria_productoComboBox_SelectedIndexChanged);
            this.categoria_productoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.categoria_productoComboBox_Validating);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.database1DataSet;
            // 
            // cantidad_productoTextBox
            // 
            this.cantidad_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Cantidad_producto", true));
            this.cantidad_productoTextBox.Location = new System.Drawing.Point(349, 67);
            this.cantidad_productoTextBox.Name = "cantidad_productoTextBox";
            this.cantidad_productoTextBox.Size = new System.Drawing.Size(130, 20);
            this.cantidad_productoTextBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cantidad_productoTextBox, "Introduce la cantidad del producto");
            this.cantidad_productoTextBox.TextChanged += new System.EventHandler(this.cantidad_productoTextBox_TextChanged);
            this.cantidad_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cantidad_productoTextBox_Validating);
            // 
            // precio_venta_productoTextBox
            // 
            this.precio_venta_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Precio_venta_producto", true));
            this.precio_venta_productoTextBox.Location = new System.Drawing.Point(635, 67);
            this.precio_venta_productoTextBox.Name = "precio_venta_productoTextBox";
            this.precio_venta_productoTextBox.Size = new System.Drawing.Size(109, 20);
            this.precio_venta_productoTextBox.TabIndex = 32;
            this.toolTip1.SetToolTip(this.precio_venta_productoTextBox, "Introduce el precio unitario del producto");
            this.precio_venta_productoTextBox.TextChanged += new System.EventHandler(this.precio_venta_productoTextBox_TextChanged);
            this.precio_venta_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precio_venta_productoTextBox_Validating);
            // 
            // total_linea_detalle_ventaTextBox
            // 
            this.total_linea_detalle_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Total_linea_detalle_venta", true));
            this.total_linea_detalle_ventaTextBox.Location = new System.Drawing.Point(635, 93);
            this.total_linea_detalle_ventaTextBox.Name = "total_linea_detalle_ventaTextBox";
            this.total_linea_detalle_ventaTextBox.ReadOnly = true;
            this.total_linea_detalle_ventaTextBox.Size = new System.Drawing.Size(109, 20);
            this.total_linea_detalle_ventaTextBox.TabIndex = 33;
            this.total_linea_detalle_ventaTextBox.TextChanged += new System.EventHandler(this.total_linea_detalle_ventaTextBox_TextChanged);
            this.total_linea_detalle_ventaTextBox.Validated += new System.EventHandler(this.total_linea_detalle_ventaTextBox_Validated);
            // 
            // button_cancelar_detalle
            // 
            this.button_cancelar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar_detalle.FlatAppearance.BorderSize = 0;
            this.button_cancelar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar_detalle.Location = new System.Drawing.Point(724, 258);
            this.button_cancelar_detalle.Name = "button_cancelar_detalle";
            this.button_cancelar_detalle.Size = new System.Drawing.Size(40, 40);
            this.button_cancelar_detalle.TabIndex = 35;
            this.toolTip1.SetToolTip(this.button_cancelar_detalle, "Cancelar edición del detalle de la venta (Alt + C)");
            this.button_cancelar_detalle.UseVisualStyleBackColor = true;
            this.button_cancelar_detalle.Click += new System.EventHandler(this.button_cancelar_detalle_Click);
            // 
            // button_aceptar_detalle
            // 
            this.button_aceptar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_accept;
            this.button_aceptar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aceptar_detalle.FlatAppearance.BorderSize = 0;
            this.button_aceptar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar_detalle.Location = new System.Drawing.Point(663, 258);
            this.button_aceptar_detalle.Name = "button_aceptar_detalle";
            this.button_aceptar_detalle.Size = new System.Drawing.Size(40, 40);
            this.button_aceptar_detalle.TabIndex = 34;
            this.toolTip1.SetToolTip(this.button_aceptar_detalle, "Validar detalle de la venta (Alt + Enter)");
            this.button_aceptar_detalle.UseVisualStyleBackColor = true;
            this.button_aceptar_detalle.Click += new System.EventHandler(this.button_aceptar_detalle_Click);
            // 
            // marca_productoTextBox
            // 
            this.marca_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Marca_producto", true));
            this.marca_productoTextBox.Location = new System.Drawing.Point(349, 93);
            this.marca_productoTextBox.Name = "marca_productoTextBox";
            this.marca_productoTextBox.Size = new System.Drawing.Size(130, 20);
            this.marca_productoTextBox.TabIndex = 31;
            this.toolTip1.SetToolTip(this.marca_productoTextBox, "Introduce la marca del producto");
            this.marca_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.marca_productoTextBox_Validating);
            // 
            // detalleVentaDataGridView
            // 
            this.detalleVentaDataGridView.AllowUserToAddRows = false;
            this.detalleVentaDataGridView.AllowUserToDeleteRows = false;
            this.detalleVentaDataGridView.AllowUserToResizeColumns = false;
            this.detalleVentaDataGridView.AllowUserToResizeRows = false;
            this.detalleVentaDataGridView.AutoGenerateColumns = false;
            this.detalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(21, 132);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.ReadOnly = true;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(743, 120);
            this.detalleVentaDataGridView.TabIndex = 74;
            this.detalleVentaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalleVentaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código  Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria_producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Marca_producto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cantidad_producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio_venta_producto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio venta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Total_linea_detalle_venta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total linea";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // button_eliminar_detalle
            // 
            this.button_eliminar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar_detalle.FlatAppearance.BorderSize = 0;
            this.button_eliminar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar_detalle.Location = new System.Drawing.Point(299, 14);
            this.button_eliminar_detalle.Name = "button_eliminar_detalle";
            this.button_eliminar_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_eliminar_detalle.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button_eliminar_detalle, "Eliminar línea de venta (Alt + D)");
            this.button_eliminar_detalle.UseVisualStyleBackColor = true;
            this.button_eliminar_detalle.Click += new System.EventHandler(this.button_eliminar_detalle_Click);
            // 
            // button_aniadir_detalle
            // 
            this.button_aniadir_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir_detalle.FlatAppearance.BorderSize = 0;
            this.button_aniadir_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir_detalle.Location = new System.Drawing.Point(258, 14);
            this.button_aniadir_detalle.Name = "button_aniadir_detalle";
            this.button_aniadir_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_aniadir_detalle.TabIndex = 25;
            this.toolTip1.SetToolTip(this.button_aniadir_detalle, "Añadir línea de venta (Alt + A)");
            this.button_aniadir_detalle.UseVisualStyleBackColor = true;
            this.button_aniadir_detalle.Click += new System.EventHandler(this.button_aniadir_detalle_Click);
            // 
            // button_ultimo_detalle
            // 
            this.button_ultimo_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo_detalle.FlatAppearance.BorderSize = 0;
            this.button_ultimo_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo_detalle.Location = new System.Drawing.Point(145, 14);
            this.button_ultimo_detalle.Name = "button_ultimo_detalle";
            this.button_ultimo_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_ultimo_detalle.TabIndex = 24;
            this.toolTip1.SetToolTip(this.button_ultimo_detalle, "Ir a la última línea de venta (Alt + M)");
            this.button_ultimo_detalle.UseVisualStyleBackColor = true;
            this.button_ultimo_detalle.Click += new System.EventHandler(this.button_ultimo_detalle_Click);
            // 
            // button_siguiente_detalle
            // 
            this.button_siguiente_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente_detalle.FlatAppearance.BorderSize = 0;
            this.button_siguiente_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente_detalle.Location = new System.Drawing.Point(104, 14);
            this.button_siguiente_detalle.Name = "button_siguiente_detalle";
            this.button_siguiente_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_siguiente_detalle.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button_siguiente_detalle, "Ir a la siguiente línea de venta (Alt + K)");
            this.button_siguiente_detalle.UseVisualStyleBackColor = true;
            this.button_siguiente_detalle.Click += new System.EventHandler(this.button_siguiente_detalle_Click);
            // 
            // button_anterior_detalle
            // 
            this.button_anterior_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior_detalle.FlatAppearance.BorderSize = 0;
            this.button_anterior_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior_detalle.Location = new System.Drawing.Point(63, 14);
            this.button_anterior_detalle.Name = "button_anterior_detalle";
            this.button_anterior_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_anterior_detalle.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button_anterior_detalle, "Ir a la anterior línea de venta (Alt + J)");
            this.button_anterior_detalle.UseVisualStyleBackColor = true;
            this.button_anterior_detalle.Click += new System.EventHandler(this.button_anterior_detalle_Click);
            // 
            // button_primero_detalle
            // 
            this.button_primero_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero_detalle.FlatAppearance.BorderSize = 0;
            this.button_primero_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero_detalle.Location = new System.Drawing.Point(21, 14);
            this.button_primero_detalle.Name = "button_primero_detalle";
            this.button_primero_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_primero_detalle.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button_primero_detalle, "Ir a la primera línea de venta (Alt + I)");
            this.button_primero_detalle.UseVisualStyleBackColor = true;
            this.button_primero_detalle.Click += new System.EventHandler(this.button_primero_detalle_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(38, 686);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 81;
            this.labelEstado.Text = "Estado";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idVentaLabel
            // 
            this.idVentaLabel.AutoSize = true;
            this.idVentaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_venta", true));
            this.idVentaLabel.Location = new System.Drawing.Point(151, 18);
            this.idVentaLabel.Name = "idVentaLabel";
            this.idVentaLabel.Size = new System.Drawing.Size(29, 13);
            this.idVentaLabel.TabIndex = 82;
            this.idVentaLabel.Text = "label";
            // 
            // button_terminar
            // 
            this.button_terminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.button_terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_terminar.ForeColor = System.Drawing.Color.White;
            this.button_terminar.Location = new System.Drawing.Point(357, 293);
            this.button_terminar.Name = "button_terminar";
            this.button_terminar.Size = new System.Drawing.Size(75, 35);
            this.button_terminar.TabIndex = 36;
            this.button_terminar.Text = "Terminar";
            this.toolTip1.SetToolTip(this.button_terminar, "Terminar venta (Alt + T)");
            this.button_terminar.UseVisualStyleBackColor = false;
            this.button_terminar.Click += new System.EventHandler(this.button_terminar_Click);
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DetalleCompraTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = this.detalleVentaTableAdapter;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventaBindingSource, "Id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clienteBindingSource;
            this.id_clienteComboBox.DisplayMember = "Nombre_completo_cliente";
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(154, 40);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_clienteComboBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.id_clienteComboBox, "Selecciona el nombre del cliente");
            this.id_clienteComboBox.ValueMember = "Id_cliente";
            this.id_clienteComboBox.SelectedIndexChanged += new System.EventHandler(this.id_clienteComboBox_SelectedIndexChanged);
            this.id_clienteComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_clienteComboBox_Validating);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.database1DataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // button_editar_detalle
            // 
            this.button_editar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_edit;
            this.button_editar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_editar_detalle.FlatAppearance.BorderSize = 0;
            this.button_editar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar_detalle.Location = new System.Drawing.Point(340, 14);
            this.button_editar_detalle.Name = "button_editar_detalle";
            this.button_editar_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_editar_detalle.TabIndex = 27;
            this.toolTip1.SetToolTip(this.button_editar_detalle, "Editar línea de venta (Alt + E)");
            this.button_editar_detalle.UseVisualStyleBackColor = true;
            this.button_editar_detalle.Click += new System.EventHandler(this.button_editar_detalle_Click);
            // 
            // labelEuros2
            // 
            this.labelEuros2.AutoSize = true;
            this.labelEuros2.Location = new System.Drawing.Point(763, 123);
            this.labelEuros2.Name = "labelEuros2";
            this.labelEuros2.Size = new System.Drawing.Size(13, 13);
            this.labelEuros2.TabIndex = 86;
            this.labelEuros2.Text = "€";
            // 
            // labelPorcentaje2
            // 
            this.labelPorcentaje2.AutoSize = true;
            this.labelPorcentaje2.Location = new System.Drawing.Point(763, 71);
            this.labelPorcentaje2.Name = "labelPorcentaje2";
            this.labelPorcentaje2.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentaje2.TabIndex = 87;
            this.labelPorcentaje2.Text = "%";
            // 
            // labelEuros1
            // 
            this.labelEuros1.AutoSize = true;
            this.labelEuros1.Location = new System.Drawing.Point(763, 98);
            this.labelEuros1.Name = "labelEuros1";
            this.labelEuros1.Size = new System.Drawing.Size(13, 13);
            this.labelEuros1.TabIndex = 88;
            this.labelEuros1.Text = "€";
            // 
            // labelPorcentaje1
            // 
            this.labelPorcentaje1.AutoSize = true;
            this.labelPorcentaje1.Location = new System.Drawing.Point(763, 45);
            this.labelPorcentaje1.Name = "labelPorcentaje1";
            this.labelPorcentaje1.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentaje1.TabIndex = 89;
            this.labelPorcentaje1.Text = "%";
            // 
            // labelEuros4
            // 
            this.labelEuros4.AutoSize = true;
            this.labelEuros4.Location = new System.Drawing.Point(750, 97);
            this.labelEuros4.Name = "labelEuros4";
            this.labelEuros4.Size = new System.Drawing.Size(13, 13);
            this.labelEuros4.TabIndex = 90;
            this.labelEuros4.Text = "€";
            // 
            // labelEuros3
            // 
            this.labelEuros3.AutoSize = true;
            this.labelEuros3.Location = new System.Drawing.Point(750, 70);
            this.labelEuros3.Name = "labelEuros3";
            this.labelEuros3.Size = new System.Drawing.Size(13, 13);
            this.labelEuros3.TabIndex = 91;
            this.labelEuros3.Text = "€";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelVenta);
            this.panel1.Location = new System.Drawing.Point(41, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 25);
            this.panel1.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.detalleVentaDataGridView);
            this.panel2.Controls.Add(this.button_terminar);
            this.panel2.Controls.Add(this.button_primero_detalle);
            this.panel2.Controls.Add(this.button_aceptar_detalle);
            this.panel2.Controls.Add(this.apellido_clienteTextBox);
            this.panel2.Controls.Add(id_ventaLabel1);
            this.panel2.Controls.Add(this.labelEuros3);
            this.panel2.Controls.Add(this.button_cancelar_detalle);
            this.panel2.Controls.Add(this.nombre_clienteTextBox);
            this.panel2.Controls.Add(this.id_ventaLabel2);
            this.panel2.Controls.Add(this.labelEuros4);
            this.panel2.Controls.Add(this.marca_productoTextBox);
            this.panel2.Controls.Add(this.total_linea_detalle_ventaTextBox);
            this.panel2.Controls.Add(id_productoLabel);
            this.panel2.Controls.Add(this.button_editar_detalle);
            this.panel2.Controls.Add(marca_productoLabel);
            this.panel2.Controls.Add(total_linea_detalle_ventaLabel);
            this.panel2.Controls.Add(this.id_productoComboBox);
            this.panel2.Controls.Add(nombre_productoLabel);
            this.panel2.Controls.Add(this.precio_venta_productoTextBox);
            this.panel2.Controls.Add(this.button_aniadir_detalle);
            this.panel2.Controls.Add(precio_venta_productoLabel);
            this.panel2.Controls.Add(this.nombre_productoTextBox);
            this.panel2.Controls.Add(this.button_ultimo_detalle);
            this.panel2.Controls.Add(this.button_eliminar_detalle);
            this.panel2.Controls.Add(this.cantidad_productoTextBox);
            this.panel2.Controls.Add(categoria_productoLabel);
            this.panel2.Controls.Add(this.button_siguiente_detalle);
            this.panel2.Controls.Add(this.categoria_productoComboBox);
            this.panel2.Controls.Add(cantidad_productoLabel);
            this.panel2.Controls.Add(this.button_anterior_detalle);
            this.panel2.Location = new System.Drawing.Point(40, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 336);
            this.panel2.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(664, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Detalle de venta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(id_ventaLabel);
            this.panel3.Controls.Add(this.total_ventaTextBox);
            this.panel3.Controls.Add(this.comboBoxMetodoPago);
            this.panel3.Controls.Add(total_ventaLabel);
            this.panel3.Controls.Add(this.button_cancelar);
            this.panel3.Controls.Add(this.total_sin_impuestos_ventaTextBox);
            this.panel3.Controls.Add(this.button_aceptar);
            this.panel3.Controls.Add(this.labelPorcentaje1);
            this.panel3.Controls.Add(id_clienteLabel);
            this.panel3.Controls.Add(total_sin_impuestos_ventaLabel);
            this.panel3.Controls.Add(this.id_clienteTextBox);
            this.panel3.Controls.Add(this.labelEuros1);
            this.panel3.Controls.Add(nombre_clienteLabel);
            this.panel3.Controls.Add(this.impuestos_ventaTextBox);
            this.panel3.Controls.Add(apellido_clienteLabel);
            this.panel3.Controls.Add(this.labelPorcentaje2);
            this.panel3.Controls.Add(dni_clienteLabel);
            this.panel3.Controls.Add(impuestos_ventaLabel);
            this.panel3.Controls.Add(this.dni_clienteTextBox);
            this.panel3.Controls.Add(this.labelEuros2);
            this.panel3.Controls.Add(fecha_ventaLabel);
            this.panel3.Controls.Add(this.descuento_ventaTextBox);
            this.panel3.Controls.Add(this.fecha_ventaDateTimePicker);
            this.panel3.Controls.Add(descuento_ventaLabel);
            this.panel3.Controls.Add(this.idVentaLabel);
            this.panel3.Controls.Add(id_clienteLabel1);
            this.panel3.Controls.Add(notas_ventaLabel);
            this.panel3.Controls.Add(metodo_pago_ventaLabel);
            this.panel3.Controls.Add(this.notas_ventaTextBox);
            this.panel3.Controls.Add(this.id_clienteComboBox);
            this.panel3.Location = new System.Drawing.Point(40, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 212);
            this.panel3.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Location = new System.Drawing.Point(643, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 81);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(871, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.button_imprimir);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_aniadir);
            this.Controls.Add(this.button_ultimo);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.button_anterior);
            this.Controls.Add(this.button_primero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "17");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormVenta";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private Database1DataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox nombre_clienteTextBox;
        private System.Windows.Forms.TextBox apellido_clienteTextBox;
        private System.Windows.Forms.TextBox dni_clienteTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ventaDateTimePicker;
        private System.Windows.Forms.TextBox notas_ventaTextBox;
        private System.Windows.Forms.TextBox descuento_ventaTextBox;
        private System.Windows.Forms.TextBox impuestos_ventaTextBox;
        private System.Windows.Forms.TextBox total_sin_impuestos_ventaTextBox;
        private System.Windows.Forms.TextBox total_ventaTextBox;
        private System.Windows.Forms.Label labelVenta;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_aniadir;
        private System.Windows.Forms.Button button_ultimo;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_anterior;
        private System.Windows.Forms.Button button_primero;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.ComboBox comboBoxMetodoPago;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private Database1DataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.Label id_ventaLabel2;
        private System.Windows.Forms.ComboBox id_productoComboBox;
        private System.Windows.Forms.TextBox nombre_productoTextBox;
        private System.Windows.Forms.ComboBox categoria_productoComboBox;
        private System.Windows.Forms.TextBox cantidad_productoTextBox;
        private System.Windows.Forms.TextBox precio_venta_productoTextBox;
        private System.Windows.Forms.TextBox total_linea_detalle_ventaTextBox;
        private System.Windows.Forms.Button button_cancelar_detalle;
        private System.Windows.Forms.Button button_aceptar_detalle;
        private System.Windows.Forms.TextBox marca_productoTextBox;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private System.Windows.Forms.Button button_eliminar_detalle;
        private System.Windows.Forms.Button button_aniadir_detalle;
        private System.Windows.Forms.Button button_ultimo_detalle;
        private System.Windows.Forms.Button button_siguiente_detalle;
        private System.Windows.Forms.Button button_anterior_detalle;
        private System.Windows.Forms.Button button_primero_detalle;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label idVentaLabel;
        private System.Windows.Forms.Button button_terminar;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Database1DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Database1DataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Button button_editar_detalle;
        private System.Windows.Forms.Label labelEuros3;
        private System.Windows.Forms.Label labelEuros4;
        private System.Windows.Forms.Label labelPorcentaje1;
        private System.Windows.Forms.Label labelEuros1;
        private System.Windows.Forms.Label labelPorcentaje2;
        private System.Windows.Forms.Label labelEuros2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
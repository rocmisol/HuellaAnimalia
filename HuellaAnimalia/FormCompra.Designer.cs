namespace HuellaAnimalia
{
    partial class FormCompra
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
            System.Windows.Forms.Label id_compraLabel;
            System.Windows.Forms.Label id_proveedorLabel;
            System.Windows.Forms.Label razon_socialLabel;
            System.Windows.Forms.Label fecha_compraLabel;
            System.Windows.Forms.Label notas_compraLabel;
            System.Windows.Forms.Label metodo_pago_compraLabel;
            System.Windows.Forms.Label descuento_compraLabel;
            System.Windows.Forms.Label impuestos_compraLabel;
            System.Windows.Forms.Label total_sin_impuestos_compraLabel;
            System.Windows.Forms.Label total_compraLabel;
            System.Windows.Forms.Label id_compraLabel2;
            System.Windows.Forms.Label id_productoLabel;
            System.Windows.Forms.Label nombre_productoLabel;
            System.Windows.Forms.Label cantidad_productoLabel;
            System.Windows.Forms.Label precio_compra_productoLabel;
            System.Windows.Forms.Label total_linea_detalle_ventaLabel;
            System.Windows.Forms.Label marca_productoLabel;
            System.Windows.Forms.Label cif_proveedorLabel;
            System.Windows.Forms.Label categoria_productoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.button_terminar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.button_cancelar_detalle = new System.Windows.Forms.Button();
            this.button_aceptar_detalle = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.labelCompra = new System.Windows.Forms.Label();
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
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CompraTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.detalleCompraTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.DetalleCompraTableAdapter();
            this.id_compraLabel1 = new System.Windows.Forms.Label();
            this.id_proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razon_socialTextBox = new System.Windows.Forms.TextBox();
            this.fecha_compraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notas_compraTextBox = new System.Windows.Forms.TextBox();
            this.metodo_pago_compraComboBox = new System.Windows.Forms.ComboBox();
            this.descuento_compraTextBox = new System.Windows.Forms.TextBox();
            this.impuestos_compraTextBox = new System.Windows.Forms.TextBox();
            this.total_sin_impuestos_compraTextBox = new System.Windows.Forms.TextBox();
            this.total_compraTextBox = new System.Windows.Forms.TextBox();
            this.button_ultimo_detalle = new System.Windows.Forms.Button();
            this.button_siguiente_detalle = new System.Windows.Forms.Button();
            this.button_anterior_detalle = new System.Windows.Forms.Button();
            this.button_primero_detalle = new System.Windows.Forms.Button();
            this.button_eliminar_detalle = new System.Windows.Forms.Button();
            this.button_aniadir_detalle = new System.Windows.Forms.Button();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_compraLabel3 = new System.Windows.Forms.Label();
            this.id_productoComboBox = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombre_productoTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_productoTextBox = new System.Windows.Forms.TextBox();
            this.precio_compra_productoTextBox = new System.Windows.Forms.TextBox();
            this.total_linea_detalle_compraTextBox = new System.Windows.Forms.TextBox();
            this.marca_productoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_editar_detalle = new System.Windows.Forms.Button();
            this.cif_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.detalleCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_productoComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.productoTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ProductoTableAdapter();
            this.proveedorTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ProveedorTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelPorcentaje1 = new System.Windows.Forms.Label();
            this.labelEuros1 = new System.Windows.Forms.Label();
            this.labelPorcentaje2 = new System.Windows.Forms.Label();
            this.labelEuros2 = new System.Windows.Forms.Label();
            this.labelEuros3 = new System.Windows.Forms.Label();
            this.labelEuros4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_compraLabel = new System.Windows.Forms.Label();
            id_proveedorLabel = new System.Windows.Forms.Label();
            razon_socialLabel = new System.Windows.Forms.Label();
            fecha_compraLabel = new System.Windows.Forms.Label();
            notas_compraLabel = new System.Windows.Forms.Label();
            metodo_pago_compraLabel = new System.Windows.Forms.Label();
            descuento_compraLabel = new System.Windows.Forms.Label();
            impuestos_compraLabel = new System.Windows.Forms.Label();
            total_sin_impuestos_compraLabel = new System.Windows.Forms.Label();
            total_compraLabel = new System.Windows.Forms.Label();
            id_compraLabel2 = new System.Windows.Forms.Label();
            id_productoLabel = new System.Windows.Forms.Label();
            nombre_productoLabel = new System.Windows.Forms.Label();
            cantidad_productoLabel = new System.Windows.Forms.Label();
            precio_compra_productoLabel = new System.Windows.Forms.Label();
            total_linea_detalle_ventaLabel = new System.Windows.Forms.Label();
            marca_productoLabel = new System.Windows.Forms.Label();
            cif_proveedorLabel = new System.Windows.Forms.Label();
            categoria_productoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_compraLabel
            // 
            id_compraLabel.AutoSize = true;
            id_compraLabel.Location = new System.Drawing.Point(18, 19);
            id_compraLabel.Name = "id_compraLabel";
            id_compraLabel.Size = new System.Drawing.Size(75, 13);
            id_compraLabel.TabIndex = 103;
            id_compraLabel.Text = "Nº de compra:";
            // 
            // id_proveedorLabel
            // 
            id_proveedorLabel.AutoSize = true;
            id_proveedorLabel.Location = new System.Drawing.Point(18, 48);
            id_proveedorLabel.Name = "id_proveedorLabel";
            id_proveedorLabel.Size = new System.Drawing.Size(115, 13);
            id_proveedorLabel.TabIndex = 105;
            id_proveedorLabel.Text = "Nombre del proveedor:";
            // 
            // razon_socialLabel
            // 
            razon_socialLabel.AutoSize = true;
            razon_socialLabel.Location = new System.Drawing.Point(20, 174);
            razon_socialLabel.Name = "razon_socialLabel";
            razon_socialLabel.Size = new System.Drawing.Size(71, 13);
            razon_socialLabel.TabIndex = 107;
            razon_socialLabel.Text = "Razon social:";
            razon_socialLabel.Visible = false;
            // 
            // fecha_compraLabel
            // 
            fecha_compraLabel.AutoSize = true;
            fecha_compraLabel.Location = new System.Drawing.Point(18, 102);
            fecha_compraLabel.Name = "fecha_compraLabel";
            fecha_compraLabel.Size = new System.Drawing.Size(93, 13);
            fecha_compraLabel.TabIndex = 111;
            fecha_compraLabel.Text = "Fecha de compra:";
            // 
            // notas_compraLabel
            // 
            notas_compraLabel.AutoSize = true;
            notas_compraLabel.Location = new System.Drawing.Point(18, 127);
            notas_compraLabel.Name = "notas_compraLabel";
            notas_compraLabel.Size = new System.Drawing.Size(38, 13);
            notas_compraLabel.TabIndex = 113;
            notas_compraLabel.Text = "Notas:";
            this.toolTip1.SetToolTip(notas_compraLabel, "Opcional: Introduce notas sobre la compra");
            // 
            // metodo_pago_compraLabel
            // 
            metodo_pago_compraLabel.AutoSize = true;
            metodo_pago_compraLabel.Location = new System.Drawing.Point(434, 22);
            metodo_pago_compraLabel.Name = "metodo_pago_compraLabel";
            metodo_pago_compraLabel.Size = new System.Drawing.Size(88, 13);
            metodo_pago_compraLabel.TabIndex = 115;
            metodo_pago_compraLabel.Text = "Método de pago:";
            // 
            // descuento_compraLabel
            // 
            descuento_compraLabel.AutoSize = true;
            descuento_compraLabel.Location = new System.Drawing.Point(434, 49);
            descuento_compraLabel.Name = "descuento_compraLabel";
            descuento_compraLabel.Size = new System.Drawing.Size(105, 13);
            descuento_compraLabel.TabIndex = 117;
            descuento_compraLabel.Text = "Descuento aplicado:";
            // 
            // impuestos_compraLabel
            // 
            impuestos_compraLabel.AutoSize = true;
            impuestos_compraLabel.Location = new System.Drawing.Point(434, 75);
            impuestos_compraLabel.Name = "impuestos_compraLabel";
            impuestos_compraLabel.Size = new System.Drawing.Size(106, 13);
            impuestos_compraLabel.TabIndex = 119;
            impuestos_compraLabel.Text = "Impuestos aplicados:";
            // 
            // total_sin_impuestos_compraLabel
            // 
            total_sin_impuestos_compraLabel.AutoSize = true;
            total_sin_impuestos_compraLabel.Location = new System.Drawing.Point(434, 101);
            total_sin_impuestos_compraLabel.Name = "total_sin_impuestos_compraLabel";
            total_sin_impuestos_compraLabel.Size = new System.Drawing.Size(100, 13);
            total_sin_impuestos_compraLabel.TabIndex = 121;
            total_sin_impuestos_compraLabel.Text = "Total sin impuestos:";
            // 
            // total_compraLabel
            // 
            total_compraLabel.AutoSize = true;
            total_compraLabel.Location = new System.Drawing.Point(434, 127);
            total_compraLabel.Name = "total_compraLabel";
            total_compraLabel.Size = new System.Drawing.Size(87, 13);
            total_compraLabel.TabIndex = 123;
            total_compraLabel.Text = "Total de compra:";
            // 
            // id_compraLabel2
            // 
            id_compraLabel2.AutoSize = true;
            id_compraLabel2.Location = new System.Drawing.Point(470, 46);
            id_compraLabel2.Name = "id_compraLabel2";
            id_compraLabel2.Size = new System.Drawing.Size(57, 13);
            id_compraLabel2.TabIndex = 130;
            id_compraLabel2.Text = "Id compra:";
            id_compraLabel2.Visible = false;
            // 
            // id_productoLabel
            // 
            id_productoLabel.AutoSize = true;
            id_productoLabel.Location = new System.Drawing.Point(18, 99);
            id_productoLabel.Name = "id_productoLabel";
            id_productoLabel.Size = new System.Drawing.Size(53, 13);
            id_productoLabel.TabIndex = 132;
            id_productoLabel.Text = "Producto:";
            // 
            // nombre_productoLabel
            // 
            nombre_productoLabel.AutoSize = true;
            nombre_productoLabel.Location = new System.Drawing.Point(620, 46);
            nombre_productoLabel.Name = "nombre_productoLabel";
            nombre_productoLabel.Size = new System.Drawing.Size(92, 13);
            nombre_productoLabel.TabIndex = 134;
            nombre_productoLabel.Text = "Nombre producto:";
            nombre_productoLabel.Visible = false;
            // 
            // cantidad_productoLabel
            // 
            cantidad_productoLabel.AutoSize = true;
            cantidad_productoLabel.Location = new System.Drawing.Point(288, 72);
            cantidad_productoLabel.Name = "cantidad_productoLabel";
            cantidad_productoLabel.Size = new System.Drawing.Size(52, 13);
            cantidad_productoLabel.TabIndex = 138;
            cantidad_productoLabel.Text = "Cantidad:";
            // 
            // precio_compra_productoLabel
            // 
            precio_compra_productoLabel.AutoSize = true;
            precio_compra_productoLabel.Location = new System.Drawing.Point(541, 72);
            precio_compra_productoLabel.Name = "precio_compra_productoLabel";
            precio_compra_productoLabel.Size = new System.Drawing.Size(77, 13);
            precio_compra_productoLabel.TabIndex = 140;
            precio_compra_productoLabel.Text = "Precio unitario:";
            // 
            // total_linea_detalle_ventaLabel
            // 
            total_linea_detalle_ventaLabel.AutoSize = true;
            total_linea_detalle_ventaLabel.Location = new System.Drawing.Point(541, 98);
            total_linea_detalle_ventaLabel.Name = "total_linea_detalle_ventaLabel";
            total_linea_detalle_ventaLabel.Size = new System.Drawing.Size(59, 13);
            total_linea_detalle_ventaLabel.TabIndex = 142;
            total_linea_detalle_ventaLabel.Text = "Total linea:";
            // 
            // marca_productoLabel
            // 
            marca_productoLabel.AutoSize = true;
            marca_productoLabel.Location = new System.Drawing.Point(288, 99);
            marca_productoLabel.Name = "marca_productoLabel";
            marca_productoLabel.Size = new System.Drawing.Size(40, 13);
            marca_productoLabel.TabIndex = 144;
            marca_productoLabel.Text = "Marca:";
            // 
            // cif_proveedorLabel
            // 
            cif_proveedorLabel.AutoSize = true;
            cif_proveedorLabel.Location = new System.Drawing.Point(18, 75);
            cif_proveedorLabel.Name = "cif_proveedorLabel";
            cif_proveedorLabel.Size = new System.Drawing.Size(94, 13);
            cif_proveedorLabel.TabIndex = 146;
            cif_proveedorLabel.Text = "CIF del proveedor:";
            // 
            // categoria_productoLabel1
            // 
            categoria_productoLabel1.AutoSize = true;
            categoria_productoLabel1.Location = new System.Drawing.Point(18, 72);
            categoria_productoLabel1.Name = "categoria_productoLabel1";
            categoria_productoLabel1.Size = new System.Drawing.Size(55, 13);
            categoria_productoLabel1.TabIndex = 147;
            categoria_productoLabel1.Text = "Categoria:";
            // 
            // button_terminar
            // 
            this.button_terminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.button_terminar.ForeColor = System.Drawing.Color.White;
            this.button_terminar.Location = new System.Drawing.Point(357, 293);
            this.button_terminar.Name = "button_terminar";
            this.button_terminar.Size = new System.Drawing.Size(75, 35);
            this.button_terminar.TabIndex = 37;
            this.button_terminar.Text = "Terminar";
            this.toolTip1.SetToolTip(this.button_terminar, "Terminar compra (Alt + T)");
            this.button_terminar.UseVisualStyleBackColor = false;
            this.button_terminar.Click += new System.EventHandler(this.button_terminar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(44, 692);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 101;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // button_cancelar_detalle
            // 
            this.button_cancelar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar_detalle.FlatAppearance.BorderSize = 0;
            this.button_cancelar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar_detalle.Location = new System.Drawing.Point(719, 255);
            this.button_cancelar_detalle.Name = "button_cancelar_detalle";
            this.button_cancelar_detalle.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar_detalle.TabIndex = 36;
            this.toolTip1.SetToolTip(this.button_cancelar_detalle, "Cancelar edición del detalle de la compra (Alt + C)");
            this.button_cancelar_detalle.UseVisualStyleBackColor = true;
            this.button_cancelar_detalle.Click += new System.EventHandler(this.button_cancelar_detalle_Click);
            // 
            // button_aceptar_detalle
            // 
            this.button_aceptar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_accept;
            this.button_aceptar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aceptar_detalle.FlatAppearance.BorderSize = 0;
            this.button_aceptar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar_detalle.Location = new System.Drawing.Point(649, 255);
            this.button_aceptar_detalle.Name = "button_aceptar_detalle";
            this.button_aceptar_detalle.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar_detalle.TabIndex = 35;
            this.toolTip1.SetToolTip(this.button_aceptar_detalle, "Validar detalle de la compra (Alt + Enter)");
            this.button_aceptar_detalle.UseVisualStyleBackColor = true;
            this.button_aceptar_detalle.Click += new System.EventHandler(this.button_aceptar_detalle_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(721, 158);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button_cancelar, "Cancelar edición del formulario de compra (Alt + C)");
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_accept;
            this.button_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aceptar.FlatAppearance.BorderSize = 0;
            this.button_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar.Location = new System.Drawing.Point(651, 158);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button_aceptar, "Validar formulario de compra (Alt + Enter)");
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompra.ForeColor = System.Drawing.Color.White;
            this.labelCompra.Location = new System.Drawing.Point(3, 2);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(77, 18);
            this.labelCompra.TabIndex = 96;
            this.labelCompra.Text = "Compras";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 46);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxBuscar, "Introduce los datos a buscar, según el criterio de búsqueda seleccionado");
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Nº compra"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: Nº compra");
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_search;
            this.button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_buscar.FlatAppearance.BorderSize = 0;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar.Location = new System.Drawing.Point(133, 19);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(45, 45);
            this.button_buscar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar compra (Alt + F)");
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
            this.toolTip1.SetToolTip(this.button_editar, "Editar compra (Alt + E)");
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
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar compra (Alt + D)");
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
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir compra (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(194, 12);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir a la última compra (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(143, 12);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir a la sigueitne compra (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(92, 12);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir a la compra anterior (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Location = new System.Drawing.Point(41, 12);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir a la primera compra (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.database1DataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = this.compraTableAdapter;
            this.tableAdapterManager.DetalleCompraTableAdapter = this.detalleCompraTableAdapter;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // detalleCompraTableAdapter
            // 
            this.detalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // id_compraLabel1
            // 
            this.id_compraLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Id_compra", true));
            this.id_compraLabel1.Location = new System.Drawing.Point(162, 19);
            this.id_compraLabel1.Name = "id_compraLabel1";
            this.id_compraLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_compraLabel1.TabIndex = 104;
            this.id_compraLabel1.Text = "label1";
            // 
            // id_proveedorComboBox
            // 
            this.id_proveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compraBindingSource, "Id_proveedor", true));
            this.id_proveedorComboBox.DataSource = this.proveedorBindingSource;
            this.id_proveedorComboBox.DisplayMember = "Razon_social";
            this.id_proveedorComboBox.FormattingEnabled = true;
            this.id_proveedorComboBox.Location = new System.Drawing.Point(162, 45);
            this.id_proveedorComboBox.Name = "id_proveedorComboBox";
            this.id_proveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_proveedorComboBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.id_proveedorComboBox, "Selecciona el nombre del proveedor");
            this.id_proveedorComboBox.ValueMember = "Id_proveedor";
            this.id_proveedorComboBox.SelectedIndexChanged += new System.EventHandler(this.id_proveedorComboBox_SelectedIndexChanged);
            this.id_proveedorComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_proveedorComboBox_Validating);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.database1DataSet;
            // 
            // razon_socialTextBox
            // 
            this.razon_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Razon_social", true));
            this.razon_socialTextBox.Location = new System.Drawing.Point(94, 174);
            this.razon_socialTextBox.Name = "razon_socialTextBox";
            this.razon_socialTextBox.Size = new System.Drawing.Size(34, 20);
            this.razon_socialTextBox.TabIndex = 108;
            // 
            // fecha_compraDateTimePicker
            // 
            this.fecha_compraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "Fecha_compra", true));
            this.fecha_compraDateTimePicker.Location = new System.Drawing.Point(162, 98);
            this.fecha_compraDateTimePicker.Name = "fecha_compraDateTimePicker";
            this.fecha_compraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_compraDateTimePicker.TabIndex = 15;
            this.toolTip1.SetToolTip(this.fecha_compraDateTimePicker, "Selecciona la fecha de compra");
            this.fecha_compraDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.fecha_compraDateTimePicker_Validating);
            // 
            // notas_compraTextBox
            // 
            this.notas_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Notas_compra", true));
            this.notas_compraTextBox.Location = new System.Drawing.Point(162, 124);
            this.notas_compraTextBox.Multiline = true;
            this.notas_compraTextBox.Name = "notas_compraTextBox";
            this.notas_compraTextBox.Size = new System.Drawing.Size(200, 60);
            this.notas_compraTextBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.notas_compraTextBox, "Opcional: Introduce notas sobre la venta");
            // 
            // metodo_pago_compraComboBox
            // 
            this.metodo_pago_compraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Metodo_pago_compra", true));
            this.metodo_pago_compraComboBox.FormattingEnabled = true;
            this.metodo_pago_compraComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.metodo_pago_compraComboBox.Location = new System.Drawing.Point(566, 19);
            this.metodo_pago_compraComboBox.Name = "metodo_pago_compraComboBox";
            this.metodo_pago_compraComboBox.Size = new System.Drawing.Size(200, 21);
            this.metodo_pago_compraComboBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.metodo_pago_compraComboBox, "Selecciona el método de pago");
            this.metodo_pago_compraComboBox.SelectedIndexChanged += new System.EventHandler(this.metodo_pago_compraComboBox_SelectedIndexChanged);
            this.metodo_pago_compraComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.metodo_pago_compraComboBox_Validating);
            // 
            // descuento_compraTextBox
            // 
            this.descuento_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Descuento_compra", true));
            this.descuento_compraTextBox.Location = new System.Drawing.Point(566, 46);
            this.descuento_compraTextBox.Name = "descuento_compraTextBox";
            this.descuento_compraTextBox.Size = new System.Drawing.Size(179, 20);
            this.descuento_compraTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.descuento_compraTextBox, "Opcional: Introduce el descuento aplicado. Por defecto es cero.");
            this.descuento_compraTextBox.TextChanged += new System.EventHandler(this.descuento_compraTextBox_TextChanged);
            this.descuento_compraTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descuento_compraTextBox_Validating);
            // 
            // impuestos_compraTextBox
            // 
            this.impuestos_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Impuestos_compra", true));
            this.impuestos_compraTextBox.Location = new System.Drawing.Point(566, 72);
            this.impuestos_compraTextBox.Name = "impuestos_compraTextBox";
            this.impuestos_compraTextBox.Size = new System.Drawing.Size(179, 20);
            this.impuestos_compraTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.impuestos_compraTextBox, "Selecciona el tipo de impuesto. Por defecto es 21%");
            this.impuestos_compraTextBox.TextChanged += new System.EventHandler(this.impuestos_compraTextBox_TextChanged);
            this.impuestos_compraTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.impuestos_compraTextBox_Validating);
            // 
            // total_sin_impuestos_compraTextBox
            // 
            this.total_sin_impuestos_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Total_sin_impuestos_compra", true));
            this.total_sin_impuestos_compraTextBox.Location = new System.Drawing.Point(566, 98);
            this.total_sin_impuestos_compraTextBox.Name = "total_sin_impuestos_compraTextBox";
            this.total_sin_impuestos_compraTextBox.ReadOnly = true;
            this.total_sin_impuestos_compraTextBox.Size = new System.Drawing.Size(179, 20);
            this.total_sin_impuestos_compraTextBox.TabIndex = 20;
            this.total_sin_impuestos_compraTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.total_sin_impuestos_compraTextBox_Validating);
            // 
            // total_compraTextBox
            // 
            this.total_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Total_compra", true));
            this.total_compraTextBox.Location = new System.Drawing.Point(566, 124);
            this.total_compraTextBox.Name = "total_compraTextBox";
            this.total_compraTextBox.ReadOnly = true;
            this.total_compraTextBox.Size = new System.Drawing.Size(179, 20);
            this.total_compraTextBox.TabIndex = 21;
            // 
            // button_ultimo_detalle
            // 
            this.button_ultimo_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo_detalle.FlatAppearance.BorderSize = 0;
            this.button_ultimo_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo_detalle.Location = new System.Drawing.Point(145, 16);
            this.button_ultimo_detalle.Name = "button_ultimo_detalle";
            this.button_ultimo_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_ultimo_detalle.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button_ultimo_detalle, "Ir a la última línea de compra (Alt + M)");
            this.button_ultimo_detalle.UseVisualStyleBackColor = true;
            this.button_ultimo_detalle.Click += new System.EventHandler(this.button_ultimo_detalle_Click);
            // 
            // button_siguiente_detalle
            // 
            this.button_siguiente_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente_detalle.FlatAppearance.BorderSize = 0;
            this.button_siguiente_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente_detalle.Location = new System.Drawing.Point(104, 16);
            this.button_siguiente_detalle.Name = "button_siguiente_detalle";
            this.button_siguiente_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_siguiente_detalle.TabIndex = 25;
            this.toolTip1.SetToolTip(this.button_siguiente_detalle, "Ir a la siguiente línea de compra (Alt + K)");
            this.button_siguiente_detalle.UseVisualStyleBackColor = true;
            this.button_siguiente_detalle.Click += new System.EventHandler(this.button_siguiente_detalle_Click);
            // 
            // button_anterior_detalle
            // 
            this.button_anterior_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior_detalle.FlatAppearance.BorderSize = 0;
            this.button_anterior_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior_detalle.Location = new System.Drawing.Point(63, 16);
            this.button_anterior_detalle.Name = "button_anterior_detalle";
            this.button_anterior_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_anterior_detalle.TabIndex = 24;
            this.toolTip1.SetToolTip(this.button_anterior_detalle, "Ir a la anterior línea de compra (Alt + J)");
            this.button_anterior_detalle.UseVisualStyleBackColor = true;
            this.button_anterior_detalle.Click += new System.EventHandler(this.button_anterior_detalle_Click);
            // 
            // button_primero_detalle
            // 
            this.button_primero_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero_detalle.FlatAppearance.BorderSize = 0;
            this.button_primero_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero_detalle.Location = new System.Drawing.Point(21, 16);
            this.button_primero_detalle.Name = "button_primero_detalle";
            this.button_primero_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_primero_detalle.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button_primero_detalle, "Ir a la primera línea de compra (Alt + I)");
            this.button_primero_detalle.UseVisualStyleBackColor = true;
            this.button_primero_detalle.Click += new System.EventHandler(this.button_primero_detalle_Click);
            // 
            // button_eliminar_detalle
            // 
            this.button_eliminar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar_detalle.FlatAppearance.BorderSize = 0;
            this.button_eliminar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar_detalle.Location = new System.Drawing.Point(304, 16);
            this.button_eliminar_detalle.Name = "button_eliminar_detalle";
            this.button_eliminar_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_eliminar_detalle.TabIndex = 28;
            this.toolTip1.SetToolTip(this.button_eliminar_detalle, "Eliminar línea de compra (Alt + D)");
            this.button_eliminar_detalle.UseVisualStyleBackColor = true;
            this.button_eliminar_detalle.Click += new System.EventHandler(this.button_eliminar_detalle_Click);
            // 
            // button_aniadir_detalle
            // 
            this.button_aniadir_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir_detalle.FlatAppearance.BorderSize = 0;
            this.button_aniadir_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir_detalle.Location = new System.Drawing.Point(263, 16);
            this.button_aniadir_detalle.Name = "button_aniadir_detalle";
            this.button_aniadir_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_aniadir_detalle.TabIndex = 27;
            this.toolTip1.SetToolTip(this.button_aniadir_detalle, "Añadir línea de compra (Alt + A)");
            this.button_aniadir_detalle.UseVisualStyleBackColor = true;
            this.button_aniadir_detalle.Click += new System.EventHandler(this.button_aniadir_detalle_Click);
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataMember = "Compra_DetalleCompra";
            this.detalleCompraBindingSource.DataSource = this.compraBindingSource;
            // 
            // id_compraLabel3
            // 
            this.id_compraLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Id_compra", true));
            this.id_compraLabel3.Location = new System.Drawing.Point(548, 46);
            this.id_compraLabel3.Name = "id_compraLabel3";
            this.id_compraLabel3.Size = new System.Drawing.Size(51, 15);
            this.id_compraLabel3.TabIndex = 131;
            this.id_compraLabel3.Text = "label1";
            this.id_compraLabel3.Visible = false;
            this.id_compraLabel3.Click += new System.EventHandler(this.id_compraLabel3_Click);
            // 
            // id_productoComboBox
            // 
            this.id_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detalleCompraBindingSource, "Id_producto", true));
            this.id_productoComboBox.DataSource = this.productoBindingSource;
            this.id_productoComboBox.DisplayMember = "Nombre_producto";
            this.id_productoComboBox.FormattingEnabled = true;
            this.id_productoComboBox.Location = new System.Drawing.Point(82, 95);
            this.id_productoComboBox.Name = "id_productoComboBox";
            this.id_productoComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_productoComboBox.TabIndex = 31;
            this.toolTip1.SetToolTip(this.id_productoComboBox, "Selecciona el producto");
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
            this.nombre_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Nombre_producto", true));
            this.nombre_productoTextBox.Location = new System.Drawing.Point(693, 159);
            this.nombre_productoTextBox.Name = "nombre_productoTextBox";
            this.nombre_productoTextBox.Size = new System.Drawing.Size(53, 20);
            this.nombre_productoTextBox.TabIndex = 135;
            // 
            // cantidad_productoTextBox
            // 
            this.cantidad_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Cantidad_producto", true));
            this.cantidad_productoTextBox.Location = new System.Drawing.Point(351, 69);
            this.cantidad_productoTextBox.Name = "cantidad_productoTextBox";
            this.cantidad_productoTextBox.Size = new System.Drawing.Size(121, 20);
            this.cantidad_productoTextBox.TabIndex = 32;
            this.toolTip1.SetToolTip(this.cantidad_productoTextBox, "Introduce la cantidad");
            this.cantidad_productoTextBox.TextChanged += new System.EventHandler(this.cantidad_productoTextBox_TextChanged);
            this.cantidad_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cantidad_productoTextBox_Validating);
            // 
            // precio_compra_productoTextBox
            // 
            this.precio_compra_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Precio_compra_producto", true));
            this.precio_compra_productoTextBox.Location = new System.Drawing.Point(624, 69);
            this.precio_compra_productoTextBox.Name = "precio_compra_productoTextBox";
            this.precio_compra_productoTextBox.Size = new System.Drawing.Size(121, 20);
            this.precio_compra_productoTextBox.TabIndex = 34;
            this.toolTip1.SetToolTip(this.precio_compra_productoTextBox, "Introduce el precio unitario");
            this.precio_compra_productoTextBox.TextChanged += new System.EventHandler(this.precio_compra_productoTextBox_TextChanged);
            this.precio_compra_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precio_compra_productoTextBox_Validating);
            // 
            // total_linea_detalle_compraTextBox
            // 
            this.total_linea_detalle_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Total_linea_detalle_venta", true));
            this.total_linea_detalle_compraTextBox.Location = new System.Drawing.Point(624, 95);
            this.total_linea_detalle_compraTextBox.Name = "total_linea_detalle_compraTextBox";
            this.total_linea_detalle_compraTextBox.ReadOnly = true;
            this.total_linea_detalle_compraTextBox.Size = new System.Drawing.Size(121, 20);
            this.total_linea_detalle_compraTextBox.TabIndex = 143;
            this.total_linea_detalle_compraTextBox.TextChanged += new System.EventHandler(this.total_linea_detalle_compraTextBox_TextChanged);
            this.total_linea_detalle_compraTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.total_linea_detalle_compraTextBox_Validating);
            // 
            // marca_productoTextBox
            // 
            this.marca_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Marca_producto", true));
            this.marca_productoTextBox.Location = new System.Drawing.Point(351, 95);
            this.marca_productoTextBox.Name = "marca_productoTextBox";
            this.marca_productoTextBox.Size = new System.Drawing.Size(121, 20);
            this.marca_productoTextBox.TabIndex = 33;
            this.toolTip1.SetToolTip(this.marca_productoTextBox, "Introduce la marca");
            this.marca_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.marca_productoTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_editar_detalle
            // 
            this.button_editar_detalle.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_edit;
            this.button_editar_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_editar_detalle.FlatAppearance.BorderSize = 0;
            this.button_editar_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar_detalle.Location = new System.Drawing.Point(345, 16);
            this.button_editar_detalle.Name = "button_editar_detalle";
            this.button_editar_detalle.Size = new System.Drawing.Size(35, 35);
            this.button_editar_detalle.TabIndex = 29;
            this.toolTip1.SetToolTip(this.button_editar_detalle, "Editar línea de compra (Alt + E)");
            this.button_editar_detalle.UseVisualStyleBackColor = true;
            this.button_editar_detalle.Click += new System.EventHandler(this.button_editar_detalle_Click);
            // 
            // cif_proveedorTextBox
            // 
            this.cif_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Cif_proveedor", true));
            this.cif_proveedorTextBox.Location = new System.Drawing.Point(162, 72);
            this.cif_proveedorTextBox.Name = "cif_proveedorTextBox";
            this.cif_proveedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.cif_proveedorTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cif_proveedorTextBox, "Introduce el CIF del proveedor");
            this.cif_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cif_proveedorTextBox_Validating);
            // 
            // detalleCompraDataGridView
            // 
            this.detalleCompraDataGridView.AllowUserToAddRows = false;
            this.detalleCompraDataGridView.AllowUserToDeleteRows = false;
            this.detalleCompraDataGridView.AllowUserToResizeColumns = false;
            this.detalleCompraDataGridView.AllowUserToResizeRows = false;
            this.detalleCompraDataGridView.AutoGenerateColumns = false;
            this.detalleCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.detalleCompraDataGridView.DataSource = this.detalleCompraBindingSource;
            this.detalleCompraDataGridView.Location = new System.Drawing.Point(21, 130);
            this.detalleCompraDataGridView.Name = "detalleCompraDataGridView";
            this.detalleCompraDataGridView.ReadOnly = true;
            this.detalleCompraDataGridView.Size = new System.Drawing.Size(743, 120);
            this.detalleCompraDataGridView.TabIndex = 147;
            this.detalleCompraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalleCompraDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_compra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria_producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio_compra_producto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio compra";
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
            // categoria_productoComboBox
            // 
            this.categoria_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Categoria_producto", true));
            this.categoria_productoComboBox.DataSource = this.categoriaBindingSource;
            this.categoria_productoComboBox.DisplayMember = "Nombre_categoria";
            this.categoria_productoComboBox.FormattingEnabled = true;
            this.categoria_productoComboBox.Location = new System.Drawing.Point(82, 68);
            this.categoria_productoComboBox.Name = "categoria_productoComboBox";
            this.categoria_productoComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoria_productoComboBox.TabIndex = 30;
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
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // labelPorcentaje1
            // 
            this.labelPorcentaje1.AutoSize = true;
            this.labelPorcentaje1.Location = new System.Drawing.Point(751, 49);
            this.labelPorcentaje1.Name = "labelPorcentaje1";
            this.labelPorcentaje1.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentaje1.TabIndex = 149;
            this.labelPorcentaje1.Text = "%";
            // 
            // labelEuros1
            // 
            this.labelEuros1.AutoSize = true;
            this.labelEuros1.Location = new System.Drawing.Point(751, 102);
            this.labelEuros1.Name = "labelEuros1";
            this.labelEuros1.Size = new System.Drawing.Size(13, 13);
            this.labelEuros1.TabIndex = 152;
            this.labelEuros1.Text = "€";
            // 
            // labelPorcentaje2
            // 
            this.labelPorcentaje2.AutoSize = true;
            this.labelPorcentaje2.Location = new System.Drawing.Point(751, 75);
            this.labelPorcentaje2.Name = "labelPorcentaje2";
            this.labelPorcentaje2.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentaje2.TabIndex = 151;
            this.labelPorcentaje2.Text = "%";
            // 
            // labelEuros2
            // 
            this.labelEuros2.AutoSize = true;
            this.labelEuros2.Location = new System.Drawing.Point(751, 127);
            this.labelEuros2.Name = "labelEuros2";
            this.labelEuros2.Size = new System.Drawing.Size(13, 13);
            this.labelEuros2.TabIndex = 150;
            this.labelEuros2.Text = "€";
            // 
            // labelEuros3
            // 
            this.labelEuros3.AutoSize = true;
            this.labelEuros3.Location = new System.Drawing.Point(751, 64);
            this.labelEuros3.Name = "labelEuros3";
            this.labelEuros3.Size = new System.Drawing.Size(13, 13);
            this.labelEuros3.TabIndex = 154;
            this.labelEuros3.Text = "€";
            // 
            // labelEuros4
            // 
            this.labelEuros4.AutoSize = true;
            this.labelEuros4.Location = new System.Drawing.Point(751, 91);
            this.labelEuros4.Name = "labelEuros4";
            this.labelEuros4.Size = new System.Drawing.Size(13, 13);
            this.labelEuros4.TabIndex = 153;
            this.labelEuros4.Text = "€";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(id_compraLabel);
            this.panel4.Controls.Add(this.button_aceptar);
            this.panel4.Controls.Add(this.button_cancelar);
            this.panel4.Controls.Add(this.labelEuros1);
            this.panel4.Controls.Add(this.total_compraTextBox);
            this.panel4.Controls.Add(this.labelPorcentaje2);
            this.panel4.Controls.Add(total_compraLabel);
            this.panel4.Controls.Add(this.labelEuros2);
            this.panel4.Controls.Add(this.total_sin_impuestos_compraTextBox);
            this.panel4.Controls.Add(this.labelPorcentaje1);
            this.panel4.Controls.Add(total_sin_impuestos_compraLabel);
            this.panel4.Controls.Add(this.impuestos_compraTextBox);
            this.panel4.Controls.Add(impuestos_compraLabel);
            this.panel4.Controls.Add(this.descuento_compraTextBox);
            this.panel4.Controls.Add(cif_proveedorLabel);
            this.panel4.Controls.Add(descuento_compraLabel);
            this.panel4.Controls.Add(this.cif_proveedorTextBox);
            this.panel4.Controls.Add(this.metodo_pago_compraComboBox);
            this.panel4.Controls.Add(metodo_pago_compraLabel);
            this.panel4.Controls.Add(this.notas_compraTextBox);
            this.panel4.Controls.Add(notas_compraLabel);
            this.panel4.Controls.Add(this.fecha_compraDateTimePicker);
            this.panel4.Controls.Add(fecha_compraLabel);
            this.panel4.Controls.Add(razon_socialLabel);
            this.panel4.Controls.Add(this.id_proveedorComboBox);
            this.panel4.Controls.Add(id_proveedorLabel);
            this.panel4.Controls.Add(this.id_compraLabel1);
            this.panel4.Location = new System.Drawing.Point(40, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 212);
            this.panel4.TabIndex = 155;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelCompra);
            this.panel1.Location = new System.Drawing.Point(41, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 25);
            this.panel1.TabIndex = 156;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.detalleCompraDataGridView);
            this.panel2.Controls.Add(categoria_productoLabel1);
            this.panel2.Controls.Add(this.button_aceptar_detalle);
            this.panel2.Controls.Add(this.button_cancelar_detalle);
            this.panel2.Controls.Add(this.labelEuros3);
            this.panel2.Controls.Add(this.button_terminar);
            this.panel2.Controls.Add(this.labelEuros4);
            this.panel2.Controls.Add(this.razon_socialTextBox);
            this.panel2.Controls.Add(this.button_aniadir_detalle);
            this.panel2.Controls.Add(this.categoria_productoComboBox);
            this.panel2.Controls.Add(this.button_eliminar_detalle);
            this.panel2.Controls.Add(this.button_primero_detalle);
            this.panel2.Controls.Add(this.button_editar_detalle);
            this.panel2.Controls.Add(this.button_anterior_detalle);
            this.panel2.Controls.Add(id_compraLabel2);
            this.panel2.Controls.Add(this.button_siguiente_detalle);
            this.panel2.Controls.Add(this.id_compraLabel3);
            this.panel2.Controls.Add(this.button_ultimo_detalle);
            this.panel2.Controls.Add(id_productoLabel);
            this.panel2.Controls.Add(this.marca_productoTextBox);
            this.panel2.Controls.Add(this.id_productoComboBox);
            this.panel2.Controls.Add(marca_productoLabel);
            this.panel2.Controls.Add(nombre_productoLabel);
            this.panel2.Controls.Add(this.total_linea_detalle_compraTextBox);
            this.panel2.Controls.Add(this.nombre_productoTextBox);
            this.panel2.Controls.Add(total_linea_detalle_ventaLabel);
            this.panel2.Controls.Add(cantidad_productoLabel);
            this.panel2.Controls.Add(this.precio_compra_productoTextBox);
            this.panel2.Controls.Add(this.cantidad_productoTextBox);
            this.panel2.Controls.Add(precio_compra_productoLabel);
            this.panel2.Location = new System.Drawing.Point(40, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 342);
            this.panel2.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(650, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 158;
            this.label1.Text = "Detalle de compra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Location = new System.Drawing.Point(641, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 78);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(871, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
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
            this.helpProvider1.SetHelpKeyword(this, "7");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCompra";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompra_FormClosing);
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_terminar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button button_cancelar_detalle;
        private System.Windows.Forms.Button button_aceptar_detalle;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label labelCompra;
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
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private Database1DataSetTableAdapters.CompraTableAdapter compraTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_compraLabel1;
        private System.Windows.Forms.ComboBox id_proveedorComboBox;
        private System.Windows.Forms.TextBox razon_socialTextBox;
        private System.Windows.Forms.DateTimePicker fecha_compraDateTimePicker;
        private System.Windows.Forms.TextBox notas_compraTextBox;
        private System.Windows.Forms.ComboBox metodo_pago_compraComboBox;
        private System.Windows.Forms.TextBox descuento_compraTextBox;
        private System.Windows.Forms.TextBox impuestos_compraTextBox;
        private System.Windows.Forms.TextBox total_sin_impuestos_compraTextBox;
        private System.Windows.Forms.TextBox total_compraTextBox;
        private System.Windows.Forms.Button button_ultimo_detalle;
        private System.Windows.Forms.Button button_siguiente_detalle;
        private System.Windows.Forms.Button button_anterior_detalle;
        private System.Windows.Forms.Button button_primero_detalle;
        private System.Windows.Forms.Button button_eliminar_detalle;
        private System.Windows.Forms.Button button_aniadir_detalle;
        private Database1DataSetTableAdapters.DetalleCompraTableAdapter detalleCompraTableAdapter;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private System.Windows.Forms.Label id_compraLabel3;
        private System.Windows.Forms.ComboBox id_productoComboBox;
        private System.Windows.Forms.TextBox nombre_productoTextBox;
        private System.Windows.Forms.TextBox cantidad_productoTextBox;
        private System.Windows.Forms.TextBox precio_compra_productoTextBox;
        private System.Windows.Forms.TextBox total_linea_detalle_compraTextBox;
        private System.Windows.Forms.TextBox marca_productoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_editar_detalle;
        private System.Windows.Forms.TextBox cif_proveedorTextBox;
        private System.Windows.Forms.DataGridView detalleCompraDataGridView;
        private System.Windows.Forms.ComboBox categoria_productoComboBox;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Database1DataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private Database1DataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelPorcentaje1;
        private System.Windows.Forms.Label labelEuros1;
        private System.Windows.Forms.Label labelPorcentaje2;
        private System.Windows.Forms.Label labelEuros2;
        private System.Windows.Forms.Label labelEuros3;
        private System.Windows.Forms.Label labelEuros4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
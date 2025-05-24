namespace HuellaAnimalia
{
    partial class FormProductos
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
            System.Windows.Forms.Label id_productoLabel;
            System.Windows.Forms.Label nombre_productoLabel;
            System.Windows.Forms.Label marca_productoLabel;
            System.Windows.Forms.Label categoria_productoLabel;
            System.Windows.Forms.Label descripcion_productoLabel;
            System.Windows.Forms.Label precio_compra_productoLabel;
            System.Windows.Forms.Label precio_venta_productoLabel;
            System.Windows.Forms.Label stock_productoLabel;
            System.Windows.Forms.Label imagen_productoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
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
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.id_productoLabel1 = new System.Windows.Forms.Label();
            this.nombre_productoTextBox = new System.Windows.Forms.TextBox();
            this.marca_productoTextBox = new System.Windows.Forms.TextBox();
            this.categoria_productoComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcion_productoTextBox = new System.Windows.Forms.TextBox();
            this.precio_compra_productoTextBox = new System.Windows.Forms.TextBox();
            this.precio_venta_productoTextBox = new System.Windows.Forms.TextBox();
            this.stock_productoTextBox = new System.Windows.Forms.TextBox();
            this.imagen_productoPictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_productoLabel = new System.Windows.Forms.Label();
            nombre_productoLabel = new System.Windows.Forms.Label();
            marca_productoLabel = new System.Windows.Forms.Label();
            categoria_productoLabel = new System.Windows.Forms.Label();
            descripcion_productoLabel = new System.Windows.Forms.Label();
            precio_compra_productoLabel = new System.Windows.Forms.Label();
            precio_venta_productoLabel = new System.Windows.Forms.Label();
            stock_productoLabel = new System.Windows.Forms.Label();
            imagen_productoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_productoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_productoLabel
            // 
            id_productoLabel.AutoSize = true;
            id_productoLabel.Location = new System.Drawing.Point(48, 123);
            id_productoLabel.Name = "id_productoLabel";
            id_productoLabel.Size = new System.Drawing.Size(82, 13);
            id_productoLabel.TabIndex = 105;
            id_productoLabel.Text = "Nº de producto:";
            // 
            // nombre_productoLabel
            // 
            nombre_productoLabel.AutoSize = true;
            nombre_productoLabel.Location = new System.Drawing.Point(48, 152);
            nombre_productoLabel.Name = "nombre_productoLabel";
            nombre_productoLabel.Size = new System.Drawing.Size(47, 13);
            nombre_productoLabel.TabIndex = 107;
            nombre_productoLabel.Text = "Nombre:";
            // 
            // marca_productoLabel
            // 
            marca_productoLabel.AutoSize = true;
            marca_productoLabel.Location = new System.Drawing.Point(48, 178);
            marca_productoLabel.Name = "marca_productoLabel";
            marca_productoLabel.Size = new System.Drawing.Size(40, 13);
            marca_productoLabel.TabIndex = 109;
            marca_productoLabel.Text = "Marca:";
            // 
            // categoria_productoLabel
            // 
            categoria_productoLabel.AutoSize = true;
            categoria_productoLabel.Location = new System.Drawing.Point(48, 204);
            categoria_productoLabel.Name = "categoria_productoLabel";
            categoria_productoLabel.Size = new System.Drawing.Size(57, 13);
            categoria_productoLabel.TabIndex = 111;
            categoria_productoLabel.Text = "Categoría:";
            // 
            // descripcion_productoLabel
            // 
            descripcion_productoLabel.AutoSize = true;
            descripcion_productoLabel.Location = new System.Drawing.Point(48, 317);
            descripcion_productoLabel.Name = "descripcion_productoLabel";
            descripcion_productoLabel.Size = new System.Drawing.Size(66, 13);
            descripcion_productoLabel.TabIndex = 113;
            descripcion_productoLabel.Text = "Descripcion:";
            // 
            // precio_compra_productoLabel
            // 
            precio_compra_productoLabel.AutoSize = true;
            precio_compra_productoLabel.Location = new System.Drawing.Point(48, 231);
            precio_compra_productoLabel.Name = "precio_compra_productoLabel";
            precio_compra_productoLabel.Size = new System.Drawing.Size(93, 13);
            precio_compra_productoLabel.TabIndex = 115;
            precio_compra_productoLabel.Text = "Precio de compra:";
            this.toolTip1.SetToolTip(precio_compra_productoLabel, "Introduce el precio de compra del producto");
            // 
            // precio_venta_productoLabel
            // 
            precio_venta_productoLabel.AutoSize = true;
            precio_venta_productoLabel.Location = new System.Drawing.Point(48, 257);
            precio_venta_productoLabel.Name = "precio_venta_productoLabel";
            precio_venta_productoLabel.Size = new System.Drawing.Size(85, 13);
            precio_venta_productoLabel.TabIndex = 117;
            precio_venta_productoLabel.Text = "Precio de venta:";
            this.toolTip1.SetToolTip(precio_venta_productoLabel, "Introduce el precio de venta del producto");
            // 
            // stock_productoLabel
            // 
            stock_productoLabel.AutoSize = true;
            stock_productoLabel.Location = new System.Drawing.Point(48, 283);
            stock_productoLabel.Name = "stock_productoLabel";
            stock_productoLabel.Size = new System.Drawing.Size(38, 13);
            stock_productoLabel.TabIndex = 119;
            stock_productoLabel.Text = "Stock:";
            // 
            // imagen_productoLabel
            // 
            imagen_productoLabel.AutoSize = true;
            imagen_productoLabel.Location = new System.Drawing.Point(517, 123);
            imagen_productoLabel.Name = "imagen_productoLabel";
            imagen_productoLabel.Size = new System.Drawing.Size(90, 13);
            imagen_productoLabel.TabIndex = 121;
            imagen_productoLabel.Text = "Imagen producto:";
            imagen_productoLabel.Click += new System.EventHandler(this.imagen_productoLabel_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(24, 538);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 104;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(3, 4);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(86, 18);
            this.labelProducto.TabIndex = 103;
            this.labelProducto.Text = "Productos";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 47);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxBuscar, "Introduce los datos a buscar, según el criterio de búsqueda seleccionado");
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Codigo producto",
            "Nombre"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: Código del producto o Nombre");
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(757, 506);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button_cancelar, "Cancelar edición (Alt + C)");
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_accept;
            this.button_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aceptar.FlatAppearance.BorderSize = 0;
            this.button_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar.Location = new System.Drawing.Point(687, 506);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button_aceptar, "Validar formulario (Alt + Enter)");
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
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
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar producto (Alt + F)");
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_print;
            this.button_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_imprimir.FlatAppearance.BorderSize = 0;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(562, 27);
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
            this.button_guardar.Location = new System.Drawing.Point(511, 27);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(45, 45);
            this.button_guardar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar (Alt + S)");
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_edit;
            this.button_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_editar.FlatAppearance.BorderSize = 0;
            this.button_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar.Location = new System.Drawing.Point(460, 27);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(45, 45);
            this.button_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_editar, "Editar producto (Alt + E)");
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Location = new System.Drawing.Point(409, 27);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(45, 45);
            this.button_eliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar producto (Alt + D)");
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aniadir
            // 
            this.button_aniadir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir.FlatAppearance.BorderSize = 0;
            this.button_aniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir.Location = new System.Drawing.Point(358, 27);
            this.button_aniadir.Name = "button_aniadir";
            this.button_aniadir.Size = new System.Drawing.Size(45, 45);
            this.button_aniadir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir producto (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(180, 27);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir al último producto (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(129, 27);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir al siguiente producto (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(75, 27);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir al producto anterior (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Location = new System.Drawing.Point(24, 27);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir al primer producto (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.database1DataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DetalleCompraTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // id_productoLabel1
            // 
            this.id_productoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id_producto", true));
            this.id_productoLabel1.Location = new System.Drawing.Point(177, 123);
            this.id_productoLabel1.Name = "id_productoLabel1";
            this.id_productoLabel1.Size = new System.Drawing.Size(121, 23);
            this.id_productoLabel1.TabIndex = 106;
            this.id_productoLabel1.Text = "label1";
            // 
            // nombre_productoTextBox
            // 
            this.nombre_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre_producto", true));
            this.nombre_productoTextBox.Location = new System.Drawing.Point(177, 149);
            this.nombre_productoTextBox.Name = "nombre_productoTextBox";
            this.nombre_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_productoTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nombre_productoTextBox, "Introduce el nombre del producto");
            this.nombre_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_productoTextBox_Validating);
            // 
            // marca_productoTextBox
            // 
            this.marca_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Marca_producto", true));
            this.marca_productoTextBox.Location = new System.Drawing.Point(177, 175);
            this.marca_productoTextBox.Name = "marca_productoTextBox";
            this.marca_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.marca_productoTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.marca_productoTextBox, "Introduce la marca del producto");
            this.marca_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.marca_productoTextBox_Validating);
            // 
            // categoria_productoComboBox
            // 
            this.categoria_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Categoria_producto", true));
            this.categoria_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "Nombre_categoria", true));
            this.categoria_productoComboBox.DataSource = this.categoriaBindingSource;
            this.categoria_productoComboBox.DisplayMember = "Nombre_categoria";
            this.categoria_productoComboBox.FormattingEnabled = true;
            this.categoria_productoComboBox.Location = new System.Drawing.Point(177, 201);
            this.categoria_productoComboBox.Name = "categoria_productoComboBox";
            this.categoria_productoComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoria_productoComboBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.categoria_productoComboBox, "Introduce la categoría del producto");
            this.categoria_productoComboBox.ValueMember = "Nombre_categoria";
            this.categoria_productoComboBox.SelectedIndexChanged += new System.EventHandler(this.categoria_productoComboBox_SelectedIndexChanged);
            this.categoria_productoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.categoria_productoComboBox_Validating);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.database1DataSet;
            // 
            // descripcion_productoTextBox
            // 
            this.descripcion_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion_producto", true));
            this.descripcion_productoTextBox.Location = new System.Drawing.Point(51, 333);
            this.descripcion_productoTextBox.Multiline = true;
            this.descripcion_productoTextBox.Name = "descripcion_productoTextBox";
            this.descripcion_productoTextBox.Size = new System.Drawing.Size(765, 152);
            this.descripcion_productoTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.descripcion_productoTextBox, "Introduce la descripción del producto");
            this.descripcion_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descripcion_productoTextBox_Validating);
            // 
            // precio_compra_productoTextBox
            // 
            this.precio_compra_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio_compra_producto", true));
            this.precio_compra_productoTextBox.Location = new System.Drawing.Point(177, 228);
            this.precio_compra_productoTextBox.Name = "precio_compra_productoTextBox";
            this.precio_compra_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.precio_compra_productoTextBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.precio_compra_productoTextBox, "Introduce el precio de compra (en númeross) del producto");
            this.precio_compra_productoTextBox.TextChanged += new System.EventHandler(this.precio_compra_productoTextBox_TextChanged);
            this.precio_compra_productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloDecimal_KeyPress);
            this.precio_compra_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precio_compra_productoTextBox_Validating);
            // 
            // precio_venta_productoTextBox
            // 
            this.precio_venta_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio_venta_producto", true));
            this.precio_venta_productoTextBox.Location = new System.Drawing.Point(177, 254);
            this.precio_venta_productoTextBox.Name = "precio_venta_productoTextBox";
            this.precio_venta_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.precio_venta_productoTextBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.precio_venta_productoTextBox, "Introduce el precio de venta (en númeross) del producto");
            this.precio_venta_productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloDecimal_KeyPress);
            this.precio_venta_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precio_venta_productoTextBox_Validating);
            // 
            // stock_productoTextBox
            // 
            this.stock_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Stock_producto", true));
            this.stock_productoTextBox.Location = new System.Drawing.Point(177, 280);
            this.stock_productoTextBox.Name = "stock_productoTextBox";
            this.stock_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.stock_productoTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.stock_productoTextBox, "Introduce el stock del producto");
            this.stock_productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloEntero_KeyPress);
            this.stock_productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stock_productoTextBox_Validating);
            // 
            // imagen_productoPictureBox
            // 
            this.imagen_productoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagen_productoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productoBindingSource, "Imagen_producto", true));
            this.imagen_productoPictureBox.Location = new System.Drawing.Point(636, 123);
            this.imagen_productoPictureBox.Name = "imagen_productoPictureBox";
            this.imagen_productoPictureBox.Size = new System.Drawing.Size(180, 180);
            this.imagen_productoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_productoPictureBox.TabIndex = 122;
            this.imagen_productoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagen_productoPictureBox, "Opcional: Carga la imagen del producto");
            this.imagen_productoPictureBox.Click += new System.EventHandler(this.imagen_productoPictureBox_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelProducto);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 25);
            this.panel1.TabIndex = 123;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Location = new System.Drawing.Point(630, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 76);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(869, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(id_productoLabel);
            this.Controls.Add(this.id_productoLabel1);
            this.Controls.Add(nombre_productoLabel);
            this.Controls.Add(this.nombre_productoTextBox);
            this.Controls.Add(marca_productoLabel);
            this.Controls.Add(this.marca_productoTextBox);
            this.Controls.Add(categoria_productoLabel);
            this.Controls.Add(this.categoria_productoComboBox);
            this.Controls.Add(descripcion_productoLabel);
            this.Controls.Add(this.descripcion_productoTextBox);
            this.Controls.Add(precio_compra_productoLabel);
            this.Controls.Add(this.precio_compra_productoTextBox);
            this.Controls.Add(precio_venta_productoLabel);
            this.Controls.Add(this.precio_venta_productoTextBox);
            this.Controls.Add(stock_productoLabel);
            this.Controls.Add(this.stock_productoTextBox);
            this.Controls.Add(imagen_productoLabel);
            this.Controls.Add(this.imagen_productoPictureBox);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
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
            this.helpProvider1.SetHelpKeyword(this, "15");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormProductos";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProductos_FormClosing);
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProductos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_productoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
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
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Database1DataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_productoLabel1;
        private System.Windows.Forms.TextBox nombre_productoTextBox;
        private System.Windows.Forms.TextBox marca_productoTextBox;
        private System.Windows.Forms.ComboBox categoria_productoComboBox;
        private System.Windows.Forms.TextBox descripcion_productoTextBox;
        private System.Windows.Forms.TextBox precio_compra_productoTextBox;
        private System.Windows.Forms.TextBox precio_venta_productoTextBox;
        private System.Windows.Forms.TextBox stock_productoTextBox;
        private System.Windows.Forms.PictureBox imagen_productoPictureBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
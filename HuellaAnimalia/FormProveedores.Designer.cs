namespace HuellaAnimalia
{
    partial class FormProveedores
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
            System.Windows.Forms.Label id_proveedorLabel;
            System.Windows.Forms.Label razon_socialLabel;
            System.Windows.Forms.Label cif_proveedorLabel;
            System.Windows.Forms.Label email_proveedorLabel;
            System.Windows.Forms.Label direccion_proveedorLabel;
            System.Windows.Forms.Label poblacion_proveedorLabel;
            System.Windows.Forms.Label provincia_proveedorLabel;
            System.Windows.Forms.Label codigo_postal_proveedorLabel;
            System.Windows.Forms.Label pais_proveedorLabel;
            System.Windows.Forms.Label imagen_proveedorLabel;
            System.Windows.Forms.Label comentarios_proveedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ProveedorTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.id_proveedorLabel1 = new System.Windows.Forms.Label();
            this.razon_socialTextBox = new System.Windows.Forms.TextBox();
            this.cif_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.email_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.direccion_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.poblacion_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.provincia_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.codigo_postal_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.pais_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.comentarios_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_buscar = new System.Windows.Forms.Button();
            this.imagen_proveedorPictureBox = new System.Windows.Forms.PictureBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_imprimir = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_aniadir = new System.Windows.Forms.Button();
            this.button_ultimo = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_anterior = new System.Windows.Forms.Button();
            this.button_primero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            id_proveedorLabel = new System.Windows.Forms.Label();
            razon_socialLabel = new System.Windows.Forms.Label();
            cif_proveedorLabel = new System.Windows.Forms.Label();
            email_proveedorLabel = new System.Windows.Forms.Label();
            direccion_proveedorLabel = new System.Windows.Forms.Label();
            poblacion_proveedorLabel = new System.Windows.Forms.Label();
            provincia_proveedorLabel = new System.Windows.Forms.Label();
            codigo_postal_proveedorLabel = new System.Windows.Forms.Label();
            pais_proveedorLabel = new System.Windows.Forms.Label();
            imagen_proveedorLabel = new System.Windows.Forms.Label();
            comentarios_proveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_proveedorPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_proveedorLabel
            // 
            id_proveedorLabel.AutoSize = true;
            id_proveedorLabel.Location = new System.Drawing.Point(6, 27);
            id_proveedorLabel.Name = "id_proveedorLabel";
            id_proveedorLabel.Size = new System.Drawing.Size(88, 13);
            id_proveedorLabel.TabIndex = 61;
            id_proveedorLabel.Text = "Nº de proveedor:";
            // 
            // razon_socialLabel
            // 
            razon_socialLabel.AutoSize = true;
            razon_socialLabel.Location = new System.Drawing.Point(6, 53);
            razon_socialLabel.Name = "razon_socialLabel";
            razon_socialLabel.Size = new System.Drawing.Size(71, 13);
            razon_socialLabel.TabIndex = 63;
            razon_socialLabel.Text = "Razón social:";
            // 
            // cif_proveedorLabel
            // 
            cif_proveedorLabel.AutoSize = true;
            cif_proveedorLabel.Location = new System.Drawing.Point(6, 79);
            cif_proveedorLabel.Name = "cif_proveedorLabel";
            cif_proveedorLabel.Size = new System.Drawing.Size(26, 13);
            cif_proveedorLabel.TabIndex = 65;
            cif_proveedorLabel.Text = "CIF:";
            // 
            // email_proveedorLabel
            // 
            email_proveedorLabel.AutoSize = true;
            email_proveedorLabel.Location = new System.Drawing.Point(6, 105);
            email_proveedorLabel.Name = "email_proveedorLabel";
            email_proveedorLabel.Size = new System.Drawing.Size(35, 13);
            email_proveedorLabel.TabIndex = 67;
            email_proveedorLabel.Text = "Email:";
            // 
            // direccion_proveedorLabel
            // 
            direccion_proveedorLabel.AutoSize = true;
            direccion_proveedorLabel.Location = new System.Drawing.Point(5, 34);
            direccion_proveedorLabel.Name = "direccion_proveedorLabel";
            direccion_proveedorLabel.Size = new System.Drawing.Size(55, 13);
            direccion_proveedorLabel.TabIndex = 69;
            direccion_proveedorLabel.Text = "Dirección:";
            // 
            // poblacion_proveedorLabel
            // 
            poblacion_proveedorLabel.AutoSize = true;
            poblacion_proveedorLabel.Location = new System.Drawing.Point(5, 60);
            poblacion_proveedorLabel.Name = "poblacion_proveedorLabel";
            poblacion_proveedorLabel.Size = new System.Drawing.Size(57, 13);
            poblacion_proveedorLabel.TabIndex = 71;
            poblacion_proveedorLabel.Text = "Población:";
            // 
            // provincia_proveedorLabel
            // 
            provincia_proveedorLabel.AutoSize = true;
            provincia_proveedorLabel.Location = new System.Drawing.Point(5, 86);
            provincia_proveedorLabel.Name = "provincia_proveedorLabel";
            provincia_proveedorLabel.Size = new System.Drawing.Size(54, 13);
            provincia_proveedorLabel.TabIndex = 73;
            provincia_proveedorLabel.Text = "Provincia:";
            // 
            // codigo_postal_proveedorLabel
            // 
            codigo_postal_proveedorLabel.AutoSize = true;
            codigo_postal_proveedorLabel.Location = new System.Drawing.Point(5, 112);
            codigo_postal_proveedorLabel.Name = "codigo_postal_proveedorLabel";
            codigo_postal_proveedorLabel.Size = new System.Drawing.Size(74, 13);
            codigo_postal_proveedorLabel.TabIndex = 75;
            codigo_postal_proveedorLabel.Text = "Código postal:";
            // 
            // pais_proveedorLabel
            // 
            pais_proveedorLabel.AutoSize = true;
            pais_proveedorLabel.Location = new System.Drawing.Point(5, 138);
            pais_proveedorLabel.Name = "pais_proveedorLabel";
            pais_proveedorLabel.Size = new System.Drawing.Size(32, 13);
            pais_proveedorLabel.TabIndex = 77;
            pais_proveedorLabel.Text = "País:";
            // 
            // imagen_proveedorLabel
            // 
            imagen_proveedorLabel.AutoSize = true;
            imagen_proveedorLabel.Location = new System.Drawing.Point(508, 123);
            imagen_proveedorLabel.Name = "imagen_proveedorLabel";
            imagen_proveedorLabel.Size = new System.Drawing.Size(113, 13);
            imagen_proveedorLabel.TabIndex = 79;
            imagen_proveedorLabel.Text = "Imagen del proveedor:";
            // 
            // comentarios_proveedorLabel
            // 
            comentarios_proveedorLabel.AutoSize = true;
            comentarios_proveedorLabel.Location = new System.Drawing.Point(508, 339);
            comentarios_proveedorLabel.Name = "comentarios_proveedorLabel";
            comentarios_proveedorLabel.Size = new System.Drawing.Size(68, 13);
            comentarios_proveedorLabel.TabIndex = 81;
            comentarios_proveedorLabel.Text = "Comentarios:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(24, 534);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 60;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(3, 4);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(104, 18);
            this.labelProveedor.TabIndex = 59;
            this.labelProveedor.Text = "Proveedores";
            this.labelProveedor.Click += new System.EventHandler(this.labelProveedor_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(5, 47);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxBuscar, "Introduce los datos a buscar, según el criterio de búsqueda seleccionado\r\n");
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Razón social",
            "CIF"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(5, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: Razón Social o CIF\r\n");
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.database1DataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // id_proveedorLabel1
            // 
            this.id_proveedorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Id_proveedor", true));
            this.id_proveedorLabel1.Location = new System.Drawing.Point(134, 27);
            this.id_proveedorLabel1.Name = "id_proveedorLabel1";
            this.id_proveedorLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_proveedorLabel1.TabIndex = 62;
            this.id_proveedorLabel1.Text = "label1";
            // 
            // razon_socialTextBox
            // 
            this.razon_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Razon_social", true));
            this.razon_socialTextBox.Location = new System.Drawing.Point(137, 50);
            this.razon_socialTextBox.Name = "razon_socialTextBox";
            this.razon_socialTextBox.Size = new System.Drawing.Size(201, 20);
            this.razon_socialTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.razon_socialTextBox, "Introduce la Razón Social de proveedor\r\n");
            this.razon_socialTextBox.TextChanged += new System.EventHandler(this.razon_socialTextBox_TextChanged);
            this.razon_socialTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.razon_socialTextBox_Validating);
            // 
            // cif_proveedorTextBox
            // 
            this.cif_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Cif_proveedor", true));
            this.cif_proveedorTextBox.Location = new System.Drawing.Point(137, 76);
            this.cif_proveedorTextBox.Name = "cif_proveedorTextBox";
            this.cif_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.cif_proveedorTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cif_proveedorTextBox, "Introduce el CIF del proveedor (9 cifras)");
            this.cif_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cif_proveedorTextBox_Validating);
            // 
            // email_proveedorTextBox
            // 
            this.email_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Email_proveedor", true));
            this.email_proveedorTextBox.Location = new System.Drawing.Point(137, 102);
            this.email_proveedorTextBox.Name = "email_proveedorTextBox";
            this.email_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.email_proveedorTextBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.email_proveedorTextBox, "Introduce el email del proveedor");
            this.email_proveedorTextBox.Enter += new System.EventHandler(this.email_proveedorTextBox_Enter);
            this.email_proveedorTextBox.Leave += new System.EventHandler(this.email_proveedorTextBox_Leave);
            this.email_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.email_proveedorTextBox_Validating);
            // 
            // direccion_proveedorTextBox
            // 
            this.direccion_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion_proveedor", true));
            this.direccion_proveedorTextBox.Location = new System.Drawing.Point(136, 31);
            this.direccion_proveedorTextBox.Name = "direccion_proveedorTextBox";
            this.direccion_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.direccion_proveedorTextBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.direccion_proveedorTextBox, "Introduce la dirección del proveedor");
            this.direccion_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccion_proveedorTextBox_Validating);
            // 
            // poblacion_proveedorTextBox
            // 
            this.poblacion_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Poblacion_proveedor", true));
            this.poblacion_proveedorTextBox.Location = new System.Drawing.Point(136, 57);
            this.poblacion_proveedorTextBox.Name = "poblacion_proveedorTextBox";
            this.poblacion_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.poblacion_proveedorTextBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.poblacion_proveedorTextBox, "Introduce la población del proveedor");
            this.poblacion_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.poblacion_proveedorTextBox_Validating);
            // 
            // provincia_proveedorTextBox
            // 
            this.provincia_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Provincia_proveedor", true));
            this.provincia_proveedorTextBox.Location = new System.Drawing.Point(136, 83);
            this.provincia_proveedorTextBox.Name = "provincia_proveedorTextBox";
            this.provincia_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.provincia_proveedorTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.provincia_proveedorTextBox, "Introduce la provincia del proveedor");
            this.provincia_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.provincia_proveedorTextBox_Validating);
            // 
            // codigo_postal_proveedorTextBox
            // 
            this.codigo_postal_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Codigo_postal_proveedor", true));
            this.codigo_postal_proveedorTextBox.Location = new System.Drawing.Point(136, 109);
            this.codigo_postal_proveedorTextBox.Name = "codigo_postal_proveedorTextBox";
            this.codigo_postal_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.codigo_postal_proveedorTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.codigo_postal_proveedorTextBox, "Introduce e código postal del proveedor");
            this.codigo_postal_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_postal_proveedorTextBox_Validating);
            // 
            // pais_proveedorTextBox
            // 
            this.pais_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Pais_proveedor", true));
            this.pais_proveedorTextBox.Location = new System.Drawing.Point(136, 135);
            this.pais_proveedorTextBox.Name = "pais_proveedorTextBox";
            this.pais_proveedorTextBox.Size = new System.Drawing.Size(201, 20);
            this.pais_proveedorTextBox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.pais_proveedorTextBox, "Introduce el país del del proveedor");
            this.pais_proveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pais_proveedorTextBox_Validating);
            // 
            // comentarios_proveedorTextBox
            // 
            this.comentarios_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Comentarios_proveedor", true));
            this.comentarios_proveedorTextBox.Location = new System.Drawing.Point(511, 370);
            this.comentarios_proveedorTextBox.Multiline = true;
            this.comentarios_proveedorTextBox.Name = "comentarios_proveedorTextBox";
            this.comentarios_proveedorTextBox.Size = new System.Drawing.Size(291, 72);
            this.comentarios_proveedorTextBox.TabIndex = 21;
            this.toolTip1.SetToolTip(this.comentarios_proveedorTextBox, "Opcional: Introduce comentarios sobre el proveedor");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // button_buscar
            // 
            this.button_buscar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_search;
            this.button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_buscar.FlatAppearance.BorderSize = 0;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar.Location = new System.Drawing.Point(132, 19);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(45, 45);
            this.button_buscar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar proveedor (Alt + F)");
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // imagen_proveedorPictureBox
            // 
            this.imagen_proveedorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagen_proveedorPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.proveedorBindingSource, "Imagen_proveedor", true));
            this.imagen_proveedorPictureBox.Location = new System.Drawing.Point(652, 123);
            this.imagen_proveedorPictureBox.Name = "imagen_proveedorPictureBox";
            this.imagen_proveedorPictureBox.Size = new System.Drawing.Size(150, 150);
            this.imagen_proveedorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_proveedorPictureBox.TabIndex = 80;
            this.imagen_proveedorPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagen_proveedorPictureBox, "Opcional: Carga la imagen del proveedor");
            this.imagen_proveedorPictureBox.Click += new System.EventHandler(this.imagen_proveedorPictureBox_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(772, 497);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 23;
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
            this.button_aceptar.Location = new System.Drawing.Point(687, 497);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button_aceptar, "Validar formulario (Alt + Enter)");
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_print;
            this.button_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_imprimir.FlatAppearance.BorderSize = 0;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(562, 19);
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
            this.button_guardar.Location = new System.Drawing.Point(511, 19);
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
            this.button_editar.Location = new System.Drawing.Point(460, 19);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(45, 45);
            this.button_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_editar, "Editar proveedor (Alt + E)");
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Location = new System.Drawing.Point(409, 19);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(45, 45);
            this.button_eliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar proveedor (Alt + D)");
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aniadir
            // 
            this.button_aniadir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir.FlatAppearance.BorderSize = 0;
            this.button_aniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir.Location = new System.Drawing.Point(358, 19);
            this.button_aniadir.Name = "button_aniadir";
            this.button_aniadir.Size = new System.Drawing.Size(45, 45);
            this.button_aniadir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir proveedor (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(177, 19);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir al último proveedor (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(126, 19);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir al siguiente proveedor (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(75, 19);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir al anterior proveedor (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Location = new System.Drawing.Point(24, 19);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir al primer proveedor (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_proveedorLabel);
            this.groupBox1.Controls.Add(this.email_proveedorTextBox);
            this.groupBox1.Controls.Add(this.id_proveedorLabel1);
            this.groupBox1.Controls.Add(email_proveedorLabel);
            this.groupBox1.Controls.Add(razon_socialLabel);
            this.groupBox1.Controls.Add(this.cif_proveedorTextBox);
            this.groupBox1.Controls.Add(this.razon_socialTextBox);
            this.groupBox1.Controls.Add(cif_proveedorLabel);
            this.groupBox1.Location = new System.Drawing.Point(75, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 139);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos informativos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(direccion_proveedorLabel);
            this.groupBox2.Controls.Add(this.pais_proveedorTextBox);
            this.groupBox2.Controls.Add(pais_proveedorLabel);
            this.groupBox2.Controls.Add(this.direccion_proveedorTextBox);
            this.groupBox2.Controls.Add(this.codigo_postal_proveedorTextBox);
            this.groupBox2.Controls.Add(poblacion_proveedorLabel);
            this.groupBox2.Controls.Add(codigo_postal_proveedorLabel);
            this.groupBox2.Controls.Add(this.poblacion_proveedorTextBox);
            this.groupBox2.Controls.Add(this.provincia_proveedorTextBox);
            this.groupBox2.Controls.Add(provincia_proveedorLabel);
            this.groupBox2.Location = new System.Drawing.Point(75, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 190);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelProveedor);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 25);
            this.panel1.TabIndex = 94;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxBuscar);
            this.groupBox3.Controls.Add(this.button_buscar);
            this.groupBox3.Controls.Add(this.textBoxBuscar);
            this.groupBox3.Location = new System.Drawing.Point(640, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 83);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(869, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(imagen_proveedorLabel);
            this.Controls.Add(this.imagen_proveedorPictureBox);
            this.Controls.Add(comentarios_proveedorLabel);
            this.Controls.Add(this.comentarios_proveedorTextBox);
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
            this.helpProvider1.SetHelpKeyword(this, "3");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormProveedores";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProveedores_FormClosing);
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProveedores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_proveedorPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelProveedor;
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
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private Database1DataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_proveedorLabel1;
        private System.Windows.Forms.TextBox razon_socialTextBox;
        private System.Windows.Forms.TextBox cif_proveedorTextBox;
        private System.Windows.Forms.TextBox email_proveedorTextBox;
        private System.Windows.Forms.TextBox direccion_proveedorTextBox;
        private System.Windows.Forms.TextBox poblacion_proveedorTextBox;
        private System.Windows.Forms.TextBox provincia_proveedorTextBox;
        private System.Windows.Forms.TextBox codigo_postal_proveedorTextBox;
        private System.Windows.Forms.TextBox pais_proveedorTextBox;
        private System.Windows.Forms.PictureBox imagen_proveedorPictureBox;
        private System.Windows.Forms.TextBox comentarios_proveedorTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
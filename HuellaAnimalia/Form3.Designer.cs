namespace HuellaAnimalia
{
    partial class Form3
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nombre_clienteLabel;
            System.Windows.Forms.Label apellidos_clienteLabel;
            System.Windows.Forms.Label telefono_clienteLabel;
            System.Windows.Forms.Label dni_clienteLabel;
            System.Windows.Forms.Label fecha_nac_clienteLabel;
            System.Windows.Forms.Label email_clienteLabel;
            System.Windows.Forms.Label direccion_clienteLabel;
            System.Windows.Forms.Label poblacion_clienteLabel;
            System.Windows.Forms.Label provincia_clienteLabel;
            System.Windows.Forms.Label codigo_postal_clienteLabel;
            System.Windows.Forms.Label pais_clienteLabel;
            System.Windows.Forms.Label comentarios_clienteLabel;
            System.Windows.Forms.Label imagen_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            this.nombre_clienteTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.apellidos_clienteTextBox = new System.Windows.Forms.TextBox();
            this.telefono_clienteTextBox = new System.Windows.Forms.TextBox();
            this.dni_clienteTextBox = new System.Windows.Forms.TextBox();
            this.email_clienteTextBox = new System.Windows.Forms.TextBox();
            this.direccion_clienteTextBox = new System.Windows.Forms.TextBox();
            this.poblacion_clienteTextBox = new System.Windows.Forms.TextBox();
            this.provincia_clienteTextBox = new System.Windows.Forms.TextBox();
            this.codigo_postal_clienteTextBox = new System.Windows.Forms.TextBox();
            this.pais_clienteTextBox = new System.Windows.Forms.TextBox();
            this.comentarios_clienteTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.imagen_clientePictureBox = new System.Windows.Forms.PictureBox();
            this.clienteTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_clienteLabel = new System.Windows.Forms.Label();
            nombre_clienteLabel = new System.Windows.Forms.Label();
            apellidos_clienteLabel = new System.Windows.Forms.Label();
            telefono_clienteLabel = new System.Windows.Forms.Label();
            dni_clienteLabel = new System.Windows.Forms.Label();
            fecha_nac_clienteLabel = new System.Windows.Forms.Label();
            email_clienteLabel = new System.Windows.Forms.Label();
            direccion_clienteLabel = new System.Windows.Forms.Label();
            poblacion_clienteLabel = new System.Windows.Forms.Label();
            provincia_clienteLabel = new System.Windows.Forms.Label();
            codigo_postal_clienteLabel = new System.Windows.Forms.Label();
            pais_clienteLabel = new System.Windows.Forms.Label();
            comentarios_clienteLabel = new System.Windows.Forms.Label();
            imagen_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_clientePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(6, 26);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(71, 13);
            id_clienteLabel.TabIndex = 13;
            id_clienteLabel.Text = "Nº de cliente:";
            // 
            // nombre_clienteLabel
            // 
            nombre_clienteLabel.AutoSize = true;
            nombre_clienteLabel.Location = new System.Drawing.Point(6, 52);
            nombre_clienteLabel.Name = "nombre_clienteLabel";
            nombre_clienteLabel.Size = new System.Drawing.Size(47, 13);
            nombre_clienteLabel.TabIndex = 15;
            nombre_clienteLabel.Text = "Nombre:";
            // 
            // apellidos_clienteLabel
            // 
            apellidos_clienteLabel.AutoSize = true;
            apellidos_clienteLabel.Location = new System.Drawing.Point(6, 78);
            apellidos_clienteLabel.Name = "apellidos_clienteLabel";
            apellidos_clienteLabel.Size = new System.Drawing.Size(52, 13);
            apellidos_clienteLabel.TabIndex = 17;
            apellidos_clienteLabel.Text = "Apellidos:";
            // 
            // telefono_clienteLabel
            // 
            telefono_clienteLabel.AutoSize = true;
            telefono_clienteLabel.Location = new System.Drawing.Point(6, 104);
            telefono_clienteLabel.Name = "telefono_clienteLabel";
            telefono_clienteLabel.Size = new System.Drawing.Size(52, 13);
            telefono_clienteLabel.TabIndex = 19;
            telefono_clienteLabel.Text = "Teléfono:";
            // 
            // dni_clienteLabel
            // 
            dni_clienteLabel.AutoSize = true;
            dni_clienteLabel.Location = new System.Drawing.Point(6, 130);
            dni_clienteLabel.Name = "dni_clienteLabel";
            dni_clienteLabel.Size = new System.Drawing.Size(29, 13);
            dni_clienteLabel.TabIndex = 21;
            dni_clienteLabel.Text = "DNI:";
            // 
            // fecha_nac_clienteLabel
            // 
            fecha_nac_clienteLabel.AutoSize = true;
            fecha_nac_clienteLabel.Location = new System.Drawing.Point(6, 156);
            fecha_nac_clienteLabel.Name = "fecha_nac_clienteLabel";
            fecha_nac_clienteLabel.Size = new System.Drawing.Size(109, 13);
            fecha_nac_clienteLabel.TabIndex = 23;
            fecha_nac_clienteLabel.Text = "Fecha de nacimiento:";
            // 
            // email_clienteLabel
            // 
            email_clienteLabel.AutoSize = true;
            email_clienteLabel.Location = new System.Drawing.Point(6, 182);
            email_clienteLabel.Name = "email_clienteLabel";
            email_clienteLabel.Size = new System.Drawing.Size(35, 13);
            email_clienteLabel.TabIndex = 25;
            email_clienteLabel.Text = "Email:";
            // 
            // direccion_clienteLabel
            // 
            direccion_clienteLabel.AutoSize = true;
            direccion_clienteLabel.Location = new System.Drawing.Point(6, 30);
            direccion_clienteLabel.Name = "direccion_clienteLabel";
            direccion_clienteLabel.Size = new System.Drawing.Size(55, 13);
            direccion_clienteLabel.TabIndex = 27;
            direccion_clienteLabel.Text = "Dirección:";
            // 
            // poblacion_clienteLabel
            // 
            poblacion_clienteLabel.AutoSize = true;
            poblacion_clienteLabel.Location = new System.Drawing.Point(6, 56);
            poblacion_clienteLabel.Name = "poblacion_clienteLabel";
            poblacion_clienteLabel.Size = new System.Drawing.Size(57, 13);
            poblacion_clienteLabel.TabIndex = 29;
            poblacion_clienteLabel.Text = "Población:";
            // 
            // provincia_clienteLabel
            // 
            provincia_clienteLabel.AutoSize = true;
            provincia_clienteLabel.Location = new System.Drawing.Point(6, 82);
            provincia_clienteLabel.Name = "provincia_clienteLabel";
            provincia_clienteLabel.Size = new System.Drawing.Size(54, 13);
            provincia_clienteLabel.TabIndex = 31;
            provincia_clienteLabel.Text = "Provincia:";
            // 
            // codigo_postal_clienteLabel
            // 
            codigo_postal_clienteLabel.AutoSize = true;
            codigo_postal_clienteLabel.Location = new System.Drawing.Point(6, 108);
            codigo_postal_clienteLabel.Name = "codigo_postal_clienteLabel";
            codigo_postal_clienteLabel.Size = new System.Drawing.Size(74, 13);
            codigo_postal_clienteLabel.TabIndex = 33;
            codigo_postal_clienteLabel.Text = "Código postal:";
            // 
            // pais_clienteLabel
            // 
            pais_clienteLabel.AutoSize = true;
            pais_clienteLabel.Location = new System.Drawing.Point(6, 134);
            pais_clienteLabel.Name = "pais_clienteLabel";
            pais_clienteLabel.Size = new System.Drawing.Size(32, 13);
            pais_clienteLabel.TabIndex = 35;
            pais_clienteLabel.Text = "País:";
            // 
            // comentarios_clienteLabel
            // 
            comentarios_clienteLabel.AutoSize = true;
            comentarios_clienteLabel.Location = new System.Drawing.Point(505, 334);
            comentarios_clienteLabel.Name = "comentarios_clienteLabel";
            comentarios_clienteLabel.Size = new System.Drawing.Size(68, 13);
            comentarios_clienteLabel.TabIndex = 37;
            comentarios_clienteLabel.Text = "Comentarios:";
            // 
            // imagen_clienteLabel
            // 
            imagen_clienteLabel.AutoSize = true;
            imagen_clienteLabel.Location = new System.Drawing.Point(505, 118);
            imagen_clienteLabel.Name = "imagen_clienteLabel";
            imagen_clienteLabel.Size = new System.Drawing.Size(96, 13);
            imagen_clienteLabel.TabIndex = 40;
            imagen_clienteLabel.Text = "Imagen del cliente:";
            imagen_clienteLabel.Click += new System.EventHandler(this.imagen_clienteLabel_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(778, 496);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 26;
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
            this.button_aceptar.Location = new System.Drawing.Point(705, 496);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.button_aceptar, "Validar formulario (Alt + enter)");
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
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar cliente (Alt + F)");
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_print;
            this.button_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_imprimir.FlatAppearance.BorderSize = 0;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(559, 12);
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
            this.button_guardar.Location = new System.Drawing.Point(508, 12);
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
            this.button_editar.Location = new System.Drawing.Point(457, 12);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(45, 45);
            this.button_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_editar, "Editar cliente (Alt + E)");
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Location = new System.Drawing.Point(406, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(45, 45);
            this.button_eliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar cliente (Alt + D)");
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aniadir
            // 
            this.button_aniadir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir.FlatAppearance.BorderSize = 0;
            this.button_aniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir.Location = new System.Drawing.Point(355, 12);
            this.button_aniadir.Name = "button_aniadir";
            this.button_aniadir.Size = new System.Drawing.Size(45, 45);
            this.button_aniadir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir cliente (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(177, 12);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir al último cliente (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(126, 12);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir al siguiente cliente (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(72, 12);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir al cliente anterior (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_primero.Location = new System.Drawing.Point(21, 12);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir al primer cliente (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // nombre_clienteTextBox
            // 
            this.nombre_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre_cliente", true));
            this.nombre_clienteTextBox.Location = new System.Drawing.Point(120, 49);
            this.nombre_clienteTextBox.Name = "nombre_clienteTextBox";
            this.nombre_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.nombre_clienteTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nombre_clienteTextBox, "Introduce el nombre del cliente");
            this.nombre_clienteTextBox.TextChanged += new System.EventHandler(this.nombre_clienteTextBox_TextChanged);
            this.nombre_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_clienteTextBox_Validating);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apellidos_clienteTextBox
            // 
            this.apellidos_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Apellidos_cliente", true));
            this.apellidos_clienteTextBox.Location = new System.Drawing.Point(120, 75);
            this.apellidos_clienteTextBox.Name = "apellidos_clienteTextBox";
            this.apellidos_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.apellidos_clienteTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.apellidos_clienteTextBox, "Introduce los apellidos del cliente");
            this.apellidos_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidos_clienteTextBox_Validating);
            // 
            // telefono_clienteTextBox
            // 
            this.telefono_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefono_cliente", true));
            this.telefono_clienteTextBox.Location = new System.Drawing.Point(120, 101);
            this.telefono_clienteTextBox.Name = "telefono_clienteTextBox";
            this.telefono_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.telefono_clienteTextBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.telefono_clienteTextBox, "Introduce el teléfono del cliente");
            this.telefono_clienteTextBox.TextChanged += new System.EventHandler(this.telefono_clienteTextBox_TextChanged);
            this.telefono_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefono_clienteTextBox_Validating);
            // 
            // dni_clienteTextBox
            // 
            this.dni_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Dni_cliente", true));
            this.dni_clienteTextBox.Location = new System.Drawing.Point(120, 127);
            this.dni_clienteTextBox.Name = "dni_clienteTextBox";
            this.dni_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.dni_clienteTextBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.dni_clienteTextBox, "Introduce el DNI del cliente");
            this.dni_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dni_clienteTextBox_Validating);
            // 
            // email_clienteTextBox
            // 
            this.email_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email_cliente", true));
            this.email_clienteTextBox.Location = new System.Drawing.Point(120, 179);
            this.email_clienteTextBox.Name = "email_clienteTextBox";
            this.email_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.email_clienteTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.email_clienteTextBox, "Introduce el email del cliente");
            this.email_clienteTextBox.TextChanged += new System.EventHandler(this.email_clienteTextBox_TextChanged);
            this.email_clienteTextBox.Enter += new System.EventHandler(this.email_clienteTextBox_Enter);
            this.email_clienteTextBox.Leave += new System.EventHandler(this.email_clienteTextBox_Leave);
            this.email_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.email_clienteTextBox_Validating);
            // 
            // direccion_clienteTextBox
            // 
            this.direccion_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Direccion_cliente", true));
            this.direccion_clienteTextBox.Location = new System.Drawing.Point(120, 27);
            this.direccion_clienteTextBox.Name = "direccion_clienteTextBox";
            this.direccion_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.direccion_clienteTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.direccion_clienteTextBox, "Introduce la dirección del cliente");
            this.direccion_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccion_clienteTextBox_Validating);
            // 
            // poblacion_clienteTextBox
            // 
            this.poblacion_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Poblacion_cliente", true));
            this.poblacion_clienteTextBox.Location = new System.Drawing.Point(120, 53);
            this.poblacion_clienteTextBox.Name = "poblacion_clienteTextBox";
            this.poblacion_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.poblacion_clienteTextBox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.poblacion_clienteTextBox, "Introduce la población del cliente");
            this.poblacion_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.poblacion_clienteTextBox_Validating);
            // 
            // provincia_clienteTextBox
            // 
            this.provincia_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Provincia_cliente", true));
            this.provincia_clienteTextBox.Location = new System.Drawing.Point(120, 79);
            this.provincia_clienteTextBox.Name = "provincia_clienteTextBox";
            this.provincia_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.provincia_clienteTextBox.TabIndex = 21;
            this.toolTip1.SetToolTip(this.provincia_clienteTextBox, "Introduce la provincia del cliente");
            this.provincia_clienteTextBox.Validated += new System.EventHandler(this.provincia_clienteTextBox_Validated);
            // 
            // codigo_postal_clienteTextBox
            // 
            this.codigo_postal_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Codigo_postal_cliente", true));
            this.codigo_postal_clienteTextBox.Location = new System.Drawing.Point(120, 105);
            this.codigo_postal_clienteTextBox.Name = "codigo_postal_clienteTextBox";
            this.codigo_postal_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.codigo_postal_clienteTextBox.TabIndex = 22;
            this.toolTip1.SetToolTip(this.codigo_postal_clienteTextBox, "Introduce el código postal del cliente");
            this.codigo_postal_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_postal_clienteTextBox_Validating);
            // 
            // pais_clienteTextBox
            // 
            this.pais_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Pais_cliente", true));
            this.pais_clienteTextBox.Location = new System.Drawing.Point(120, 131);
            this.pais_clienteTextBox.Name = "pais_clienteTextBox";
            this.pais_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.pais_clienteTextBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.pais_clienteTextBox, "Introduce el país del cliente");
            this.pais_clienteTextBox.TextChanged += new System.EventHandler(this.pais_clienteTextBox_TextChanged);
            this.pais_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pais_clienteTextBox_Validating);
            // 
            // comentarios_clienteTextBox
            // 
            this.comentarios_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Comentarios_cliente", true));
            this.comentarios_clienteTextBox.Location = new System.Drawing.Point(508, 370);
            this.comentarios_clienteTextBox.Multiline = true;
            this.comentarios_clienteTextBox.Name = "comentarios_clienteTextBox";
            this.comentarios_clienteTextBox.Size = new System.Drawing.Size(291, 72);
            this.comentarios_clienteTextBox.TabIndex = 24;
            this.toolTip1.SetToolTip(this.comentarios_clienteTextBox, "Opcional: Introduce comentarios sobre el cliente");
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "DNI",
            "Teléfono"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: DNI o Teléfono");
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 47);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxBuscar, "Introduce los datos a buscar, según el criterio de búsqueda seleccionado\r\n");
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // imagen_clientePictureBox
            // 
            this.imagen_clientePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagen_clientePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Imagen_cliente", true));
            this.imagen_clientePictureBox.Location = new System.Drawing.Point(649, 118);
            this.imagen_clientePictureBox.Name = "imagen_clientePictureBox";
            this.imagen_clientePictureBox.Size = new System.Drawing.Size(150, 150);
            this.imagen_clientePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_clientePictureBox.TabIndex = 41;
            this.imagen_clientePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.imagen_clientePictureBox, "Opcional: Carga una imagen del cliente");
            this.imagen_clientePictureBox.Click += new System.EventHandler(this.imagen_clientePictureBox_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DetalleCompraTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(3, 3);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(57, 18);
            this.labelCliente.TabIndex = 42;
            this.labelCliente.Text = "cliente";
            this.labelCliente.Click += new System.EventHandler(this.labelCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id_cliente", true));
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "label1";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(21, 527);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 44;
            this.labelEstado.Text = "Estado";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Fecha_nac_cliente", true));
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(120, 153);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.fechaNacDateTimePicker.TabIndex = 17;
            this.toolTip1.SetToolTip(this.fechaNacDateTimePicker, "Introduce la fecha de nacimiento del cliente");
            this.fechaNacDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.fechaNacDateTimePicker_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_clienteLabel);
            this.groupBox1.Controls.Add(this.fechaNacDateTimePicker);
            this.groupBox1.Controls.Add(this.email_clienteTextBox);
            this.groupBox1.Controls.Add(email_clienteLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(fecha_nac_clienteLabel);
            this.groupBox1.Controls.Add(this.dni_clienteTextBox);
            this.groupBox1.Controls.Add(dni_clienteLabel);
            this.groupBox1.Controls.Add(this.telefono_clienteTextBox);
            this.groupBox1.Controls.Add(telefono_clienteLabel);
            this.groupBox1.Controls.Add(this.apellidos_clienteTextBox);
            this.groupBox1.Controls.Add(apellidos_clienteLabel);
            this.groupBox1.Controls.Add(nombre_clienteLabel);
            this.groupBox1.Controls.Add(this.nombre_clienteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(72, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 211);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Informativos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(direccion_clienteLabel);
            this.groupBox2.Controls.Add(this.pais_clienteTextBox);
            this.groupBox2.Controls.Add(pais_clienteLabel);
            this.groupBox2.Controls.Add(this.codigo_postal_clienteTextBox);
            this.groupBox2.Controls.Add(codigo_postal_clienteLabel);
            this.groupBox2.Controls.Add(this.provincia_clienteTextBox);
            this.groupBox2.Controls.Add(provincia_clienteLabel);
            this.groupBox2.Controls.Add(this.poblacion_clienteTextBox);
            this.groupBox2.Controls.Add(poblacion_clienteLabel);
            this.groupBox2.Controls.Add(this.direccion_clienteTextBox);
            this.groupBox2.Location = new System.Drawing.Point(72, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 162);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Location = new System.Drawing.Point(21, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 25);
            this.panel1.TabIndex = 95;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxBuscar);
            this.groupBox3.Controls.Add(this.button_buscar);
            this.groupBox3.Controls.Add(this.textBoxBuscar);
            this.groupBox3.Location = new System.Drawing.Point(634, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 76);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(imagen_clienteLabel);
            this.Controls.Add(this.imagen_clientePictureBox);
            this.Controls.Add(comentarios_clienteLabel);
            this.Controls.Add(this.comentarios_clienteTextBox);
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
            this.helpProvider1.SetHelpKeyword(this, "9");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_clientePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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

        private System.Windows.Forms.Button button_primero;
        private System.Windows.Forms.Button button_anterior;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_ultimo;
        private System.Windows.Forms.Button button_aniadir;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Database1DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_clienteTextBox;
        private System.Windows.Forms.TextBox apellidos_clienteTextBox;
        private System.Windows.Forms.TextBox telefono_clienteTextBox;
        private System.Windows.Forms.TextBox dni_clienteTextBox;
        private System.Windows.Forms.TextBox email_clienteTextBox;
        private System.Windows.Forms.TextBox direccion_clienteTextBox;
        private System.Windows.Forms.TextBox poblacion_clienteTextBox;
        private System.Windows.Forms.TextBox provincia_clienteTextBox;
        private System.Windows.Forms.TextBox codigo_postal_clienteTextBox;
        private System.Windows.Forms.TextBox pais_clienteTextBox;
        private System.Windows.Forms.TextBox comentarios_clienteTextBox;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.PictureBox imagen_clientePictureBox;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker fechaNacDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
namespace HuellaAnimalia
{
    partial class FormCategorias
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
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label nombre_categoriaLabel;
            System.Windows.Forms.Label descripcion_categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.id_categoriaLabel1 = new System.Windows.Forms.Label();
            this.nombre_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_categoriaLabel = new System.Windows.Forms.Label();
            nombre_categoriaLabel = new System.Windows.Forms.Label();
            descripcion_categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(50, 116);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(66, 13);
            id_categoriaLabel.TabIndex = 120;
            id_categoriaLabel.Text = "Id categoria:";
            // 
            // nombre_categoriaLabel
            // 
            nombre_categoriaLabel.AutoSize = true;
            nombre_categoriaLabel.Location = new System.Drawing.Point(50, 145);
            nombre_categoriaLabel.Name = "nombre_categoriaLabel";
            nombre_categoriaLabel.Size = new System.Drawing.Size(122, 13);
            nombre_categoriaLabel.TabIndex = 122;
            nombre_categoriaLabel.Text = "Nombre de la categoría:";
            // 
            // descripcion_categoriaLabel
            // 
            descripcion_categoriaLabel.AutoSize = true;
            descripcion_categoriaLabel.Location = new System.Drawing.Point(51, 188);
            descripcion_categoriaLabel.Name = "descripcion_categoriaLabel";
            descripcion_categoriaLabel.Size = new System.Drawing.Size(113, 13);
            descripcion_categoriaLabel.TabIndex = 124;
            descripcion_categoriaLabel.Text = "Descripcion categoria:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(3, 3);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(90, 18);
            this.labelCategoria.TabIndex = 116;
            this.labelCategoria.Text = "Categorías";
            this.labelCategoria.Click += new System.EventHandler(this.labelCategoria_Click);
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
            "Código",
            "Nombre"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxBuscar, "Selecciona el criterio de búsqueda: Código o Nombre\r\n");
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.labelEstado.Location = new System.Drawing.Point(9, 428);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 16);
            this.labelEstado.TabIndex = 119;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DetalleCompraTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // id_categoriaLabel1
            // 
            this.id_categoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Id_categoria", true));
            this.id_categoriaLabel1.Location = new System.Drawing.Point(188, 116);
            this.id_categoriaLabel1.Name = "id_categoriaLabel1";
            this.id_categoriaLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_categoriaLabel1.TabIndex = 121;
            this.id_categoriaLabel1.Text = "label1";
            // 
            // nombre_categoriaTextBox
            // 
            this.nombre_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nombre_categoria", true));
            this.nombre_categoriaTextBox.Location = new System.Drawing.Point(188, 142);
            this.nombre_categoriaTextBox.Name = "nombre_categoriaTextBox";
            this.nombre_categoriaTextBox.Size = new System.Drawing.Size(117, 20);
            this.nombre_categoriaTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nombre_categoriaTextBox, "Introduce el nombre de la categoría");
            this.nombre_categoriaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_categoriaTextBox_Validating);
            // 
            // descripcion_categoriaTextBox
            // 
            this.descripcion_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descripcion_categoria", true));
            this.descripcion_categoriaTextBox.Location = new System.Drawing.Point(54, 213);
            this.descripcion_categoriaTextBox.Multiline = true;
            this.descripcion_categoriaTextBox.Name = "descripcion_categoriaTextBox";
            this.descripcion_categoriaTextBox.Size = new System.Drawing.Size(709, 129);
            this.descripcion_categoriaTextBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.descripcion_categoriaTextBox, "Introduce la descripción de la categoría");
            this.descripcion_categoriaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descripcion_categoriaTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_cancel;
            this.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancelar.FlatAppearance.BorderSize = 0;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(718, 365);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(45, 45);
            this.button_cancelar.TabIndex = 16;
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
            this.button_aceptar.Location = new System.Drawing.Point(648, 365);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(45, 45);
            this.button_aceptar.TabIndex = 15;
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
            this.toolTip1.SetToolTip(this.button_buscar, "Buscar categoría (Alt + F)");
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_print;
            this.button_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_imprimir.FlatAppearance.BorderSize = 0;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(501, 12);
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
            this.button_guardar.Location = new System.Drawing.Point(450, 12);
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
            this.button_editar.Location = new System.Drawing.Point(399, 12);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(45, 45);
            this.button_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_editar, "Editar categoría (Alt + E)");
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_delete;
            this.button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Location = new System.Drawing.Point(348, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(45, 45);
            this.button_eliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar categoría (Alt + D)");
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aniadir
            // 
            this.button_aniadir.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_new;
            this.button_aniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_aniadir.FlatAppearance.BorderSize = 0;
            this.button_aniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aniadir.Location = new System.Drawing.Point(297, 12);
            this.button_aniadir.Name = "button_aniadir";
            this.button_aniadir.Size = new System.Drawing.Size(45, 45);
            this.button_aniadir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_aniadir, "Añadir categoría (Alt + A)");
            this.button_aniadir.UseVisualStyleBackColor = true;
            this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_last;
            this.button_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ultimo.FlatAppearance.BorderSize = 0;
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(168, 12);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(45, 45);
            this.button_ultimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_ultimo, "Ir a la última categoría (Alt + M)");
            this.button_ultimo.UseVisualStyleBackColor = true;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_next;
            this.button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_siguiente.FlatAppearance.BorderSize = 0;
            this.button_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siguiente.Location = new System.Drawing.Point(117, 12);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(45, 45);
            this.button_siguiente.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_siguiente, "Ir a la siguiente categoría (Alt + K)");
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_previous;
            this.button_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anterior.FlatAppearance.BorderSize = 0;
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(63, 12);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(45, 45);
            this.button_anterior.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_anterior, "Ir a la anterior categoría (Alt + J)");
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.BackgroundImage = global::HuellaAnimalia.Properties.Resources.icon_first;
            this.button_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_primero.FlatAppearance.BorderSize = 0;
            this.button_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_primero.Location = new System.Drawing.Point(12, 12);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(45, 45);
            this.button_primero.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_primero, "Ir a la primera categoría (Alt + I)");
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 25);
            this.panel1.TabIndex = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Location = new System.Drawing.Point(580, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 75);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaLabel1);
            this.Controls.Add(nombre_categoriaLabel);
            this.Controls.Add(this.nombre_categoriaTextBox);
            this.Controls.Add(descripcion_categoriaLabel);
            this.Controls.Add(this.descripcion_categoriaTextBox);
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
            this.helpProvider1.SetHelpKeyword(this, "13");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCategorias";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCategorias_FormClosing);
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCategorias_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoria;
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
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_categoriaLabel1;
        private System.Windows.Forms.TextBox nombre_categoriaTextBox;
        private System.Windows.Forms.TextBox descripcion_categoriaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
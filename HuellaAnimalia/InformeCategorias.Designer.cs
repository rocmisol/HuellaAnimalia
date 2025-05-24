namespace HuellaAnimalia
{
    partial class InformeCategorias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeCategorias));
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new HuellaAnimalia.Database1DataSet();
            this.button_limpiar_filtro = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.comboBox_Filtro = new System.Windows.Forms.ComboBox();
            this.textBox_filtro = new System.Windows.Forms.TextBox();
            this.categoriaTableAdapter = new HuellaAnimalia.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new HuellaAnimalia.Database1DataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_limpiar_filtro
            // 
            this.button_limpiar_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.button_limpiar_filtro.ForeColor = System.Drawing.Color.White;
            this.button_limpiar_filtro.Location = new System.Drawing.Point(664, 12);
            this.button_limpiar_filtro.Name = "button_limpiar_filtro";
            this.button_limpiar_filtro.Size = new System.Drawing.Size(65, 30);
            this.button_limpiar_filtro.TabIndex = 4;
            this.button_limpiar_filtro.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.button_limpiar_filtro, "Reestablece el filtro y muestra todos los datos (Alt + L)");
            this.button_limpiar_filtro.UseVisualStyleBackColor = false;
            this.button_limpiar_filtro.Click += new System.EventHandler(this.button_limpiar_filtro_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.button_filtrar.ForeColor = System.Drawing.Color.White;
            this.button_filtrar.Location = new System.Drawing.Point(593, 12);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(65, 30);
            this.button_filtrar.TabIndex = 3;
            this.button_filtrar.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.button_filtrar, "Filtra los registro según el valor introducido en el campo anterior (Alt + F)");
            this.button_filtrar.UseVisualStyleBackColor = false;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // comboBox_Filtro
            // 
            this.comboBox_Filtro.FormattingEnabled = true;
            this.comboBox_Filtro.Items.AddRange(new object[] {
            "Nombre"});
            this.comboBox_Filtro.Location = new System.Drawing.Point(324, 17);
            this.comboBox_Filtro.Name = "comboBox_Filtro";
            this.comboBox_Filtro.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filtro.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBox_Filtro, "Selecciona el criterio de filtrado: Nombre\r\n");
            // 
            // textBox_filtro
            // 
            this.textBox_filtro.Location = new System.Drawing.Point(451, 18);
            this.textBox_filtro.Name = "textBox_filtro";
            this.textBox_filtro.Size = new System.Drawing.Size(121, 20);
            this.textBox_filtro.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_filtro, "Introduce los datos a filtrar, según el criterio de filtrado seleccionado");
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.categoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HuellaAnimalia.InformeCategorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(741, 448);
            this.reportViewer1.TabIndex = 5;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Manual de uso - Huella Animalia.chm";
            // 
            // InformeCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(741, 496);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_limpiar_filtro);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.comboBox_Filtro);
            this.Controls.Add(this.textBox_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "23");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformeCategorias";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Categorias";
            this.Load += new System.EventHandler(this.InformeCategorias_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InformeCategorias_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_limpiar_filtro;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.ComboBox comboBox_Filtro;
        private System.Windows.Forms.TextBox textBox_filtro;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaAnimalia
{
    public partial class InformeCompras : Form
    {
        public InformeCompras()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void InformeCompras_Load(object sender, EventArgs e)
        {
            // Establece la ruta de la base de datos
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Asignar la conexión dinámica a los TableAdapters
            this.compraTableAdapter.Connection.ConnectionString = connectionString;
            this.detalleCompraTableAdapter.Connection.ConnectionString = connectionString;

            // Cargar los datos
            this.detalleCompraTableAdapter.Fill(this.database1DataSet.DetalleCompra);
            this.compraTableAdapter.Fill(this.database1DataSet.Compra);

            this.compraBindingSource.Filter = "Id_compra=" + Properties.Settings.Default.numPedido;
            this.detalleCompraBindingSource.Filter = "Id_compra=" + Properties.Settings.Default.numPedido;

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class InformeVentas : Form
    {
        public InformeVentas()
        {
            InitializeComponent();
        }

        private void InformeVentas_Load(object sender, EventArgs e)
        {
            // Establecer la ruta dinámica a la base de datos
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Asignar nueva cadena de conexión a los TableAdapters
            this.ventaTableAdapter.Connection.ConnectionString = connectionString;
            this.detalleVentaTableAdapter.Connection.ConnectionString = connectionString;

            // Cargar los datos
            this.ventaTableAdapter.Fill(this.database1DataSet.Venta);
            this.detalleVentaTableAdapter.Fill(this.database1DataSet.DetalleVenta);

            this.ventaBindingSource.Filter = "Id_venta=" + Properties.Settings.Default.numPedido;
            this.detalleVentaBindingSource.Filter = "Id_venta=" + Properties.Settings.Default.numPedido;

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

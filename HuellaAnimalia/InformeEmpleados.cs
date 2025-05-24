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
    public partial class InformeEmpleados : Form
    {
        public InformeEmpleados()
        {
            InitializeComponent();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void InformeEmpleados_Load(object sender, EventArgs e)
        {
            // Se selecciona por defecto el primer filtro
            comboBox_Filtro.SelectedIndex = 0;

            // Establecer ruta de la base de datos
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Asignar la conexión dinámica al TableAdapter
            this.empleadoTableAdapter.Connection.ConnectionString = connectionString;

            // Cargar datos
            this.empleadoTableAdapter.Fill(this.database1DataSet.Empleado);


            this.reportViewer1.RefreshReport();
        }

        // Botón filtrar
        private void button_filtrar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = comboBox_Filtro.SelectedItem.ToString();
            string textoFiltro = textBox_filtro.Text.Trim();

            // Se construye el filtro según la opción seleccionada
            if (!string.IsNullOrEmpty(textoFiltro))
            {
                if (filtroSeleccionado == "Población")
                {
                    empleadoBindingSource.Filter = $"Poblacion_empleado LIKE '%{textoFiltro}%'";
                }
                else if (filtroSeleccionado == "Provincia")
                {
                    empleadoBindingSource.Filter = $"Provincia_empleado LIKE '%{textoFiltro}%'";
                }
                else if (filtroSeleccionado == "Rol")
                {
                    empleadoBindingSource.Filter = $"Rol_empleado LIKE '%{textoFiltro}%'";
                }

                // Se refresca el informe con los datos filtrados
                reportViewer1.RefreshReport();

            }
            else
            {
                MessageBox.Show("Introduce un valor para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_limpiar_filtro_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.Filter = string.Empty; // Se elimina el filtro
            textBox_filtro.Clear(); // Se limpia el texto del filtro
            comboBox_Filtro.SelectedIndex = 0; // Se restaura el filtro predeterminado
            reportViewer1.RefreshReport(); // Se refresca el informe
        }

        private void InformeEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F) // Filtrar
            {
                button_filtrar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.L) // Limpiar filtros
            {
                button_limpiar_filtro.PerformClick();
            }
        }
    }
}

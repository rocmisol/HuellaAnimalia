using HuellaAnimalia.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaAnimalia
{
    public partial class Form2 : Form
    {
        private bool saliendo = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Se muestra un mensaje de bienvenida al usuario
            label_bienvenido.Text = "¡Bienvenid@ " + Properties.Settings.Default.Nombre_empleado + "!";

            // Se verifica el rol del empleado
            string rolEmpleado = Properties.Settings.Default.Rol_empleado;

            // Se habilitan o deshabilitna las áreas en función del rol
            if (rolEmpleado == "Administrador")
            {
                habilitarTodasLasAreas(); // El administrador puede acceder a todas la áreas
                habilitarTodosElementosMenu();
            }
            else if (rolEmpleado == "Gestor de inventario")
            {
                habilitarAreasCompra(); // El personal de compra solo puede acceder a proveedores, compras, productos y categorías
                deshabilitarAreasVenta();
                deshabilitarAreaEmpleados();
                habilitarElementosMenuCompra();
            }
            else if (rolEmpleado ==  "Personal de venta")
            {
                habilitarAreasVenta(); // El personal de venta solo puede acceder a clientes y ventas
                deshabilitarAreasCompra();
                deshabilitarAreaEmpleados();
                habilitarElementosMenuVenta();
            }
            else
            {
                // Si el rol no es válid, se cierra el formulario mostrando un mensaje de error
                MessageBox.Show("Rol no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // Acceso a la ventana de proveedores
        private void button_Proveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Owner = this; // Asigna Form2 como propietario de FormProveedores
            formProveedores.Show();
            this.Hide();
        }

        // Acceso a la venta de compras
        private void button_compras_Click(object sender, EventArgs e)
        {
            FormCompra formCompras = new FormCompra();
            formCompras.Owner = this; // Asigna Form2 como propietario de FormCompra
            formCompras.Show();
            this.Hide();
        }

        // Acceso a la ventana de clientes
        private void button_clientes_Click(object sender, EventArgs e)
        {
            Form3 formClientes = new Form3();
            formClientes.Owner = this; // Asigna Form2 como propietario de Form3
            formClientes.Show();
            this.Hide();
        }


        // Botón para volver al formulario de login
        private void button_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();
            //this.Hide(); // Se oculta el formulario principal
            this.Dispose();
        }


        private void label_bienvenido_Click(object sender, EventArgs e)
        {

        }

        //Acceso a la ventana ventas
        private void button_ventas_Click(object sender, EventArgs e)
        {
            FormVenta formVentas = new FormVenta();
            formVentas.Owner = this; // Asigna Form2 como propietario de FormVentas
            formVentas.Show();
            this.Hide();
        }

        // Acceso a la ventana empleados
        private void button_empleados_Click(object sender, EventArgs e)
        {
            Empleados formEmpleados = new Empleados();
            formEmpleados.Owner = this; // Asigna Form2 como propietario de FormEmpleados
            formEmpleados.Show();
            this.Hide();
        }

        // Aceeso a la ventana productos
        private void button_productos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Owner = this; // Asigna Form2 como propietario de FormProductos
            formProductos.Show();
            this.Hide();
        }

        // Acceso a la ventana categorías
        private void button_categorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.Owner = this; // Asigna Form2 como propietario de FormCategorias
            formCategorias.Show();
            this.Hide();
        }

        // Cerrar formulario.
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saliendo)
            {
                // Se pregunta al usuario si desea cerrar la aplicación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la apliación?", "Confirmar cierre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

                else if (result == DialogResult.Yes)
                {
                    saliendo = true; // Para que no se muestre de nuevo el mensaje de salir

                    // Se cierra la aplicación
                    Application.Exit();
                }
            }
            
        }

        // Método para hablitar todas las áreas del formulario
        private void habilitarTodasLasAreas()
        {
            button_Proveedores.Enabled = true;
            button_compras.Enabled = true;
            button_clientes.Enabled = true;
            button_ventas.Enabled = true;
            button_empleados.Enabled = true;
            button_categorias.Enabled = true;
            button_productos.Enabled = true;
            button_empleados.BackgroundImage = Properties.Resources.Empleados1;
            button_Proveedores.BackgroundImage = Properties.Resources.Proveedores;
            button_compras.BackgroundImage = Properties.Resources.Compras;
            button_productos.BackgroundImage = Properties.Resources.fluent_mdl2_product_variant;
            button_clientes.BackgroundImage = Properties.Resources.Clientes2;
            button_ventas.BackgroundImage = Properties.Resources.Ventas;
            button_categorias.ForeColor = Color.FromArgb(219, 157, 170);
            label_Empleados.ForeColor = Color.FromArgb(219, 157, 170);
            label_Compras.ForeColor = Color.FromArgb(219, 157, 170);
            label_Productos.ForeColor = Color.FromArgb(219, 157, 170);
            label_Proveedores.ForeColor = Color.FromArgb(219, 157, 170);
            label_Compras.ForeColor = Color.FromArgb(219, 157, 170);
            label_Productos.ForeColor = Color.FromArgb(219, 157, 170);
            label_Proveedores.ForeColor = Color.FromArgb(219, 157, 170);
        }

        // Método para deshablitar el área de empleados
        private void deshabilitarAreaEmpleados()
        {
            button_empleados.Enabled = false;
            button_empleados.BackgroundImage = Properties.Resources.Empleados_grey;
            label_Empleados.ForeColor = Color.FromArgb(233, 221, 223);
        }



        // Método para habilitar las áreas de compra
        private void habilitarAreasCompra()
        {
            button_Proveedores.Enabled = true;
            button_compras.Enabled = true;
            button_categorias.Enabled = true;
            button_productos.Enabled = true;
            button_Proveedores.BackgroundImage = Properties.Resources.Proveedores;
            button_compras.BackgroundImage = Properties.Resources.Compras;
            button_productos.BackgroundImage = Properties.Resources.fluent_mdl2_product_variant;
            button_categorias.ForeColor = Color.FromArgb(219, 157, 170);
            label_Compras.ForeColor = Color.FromArgb(219, 157, 170);
            label_Productos.ForeColor = Color.FromArgb(219, 157, 170);
            label_Proveedores.ForeColor = Color.FromArgb(219, 157, 170);

        }

        // Método para deshabilitar las áreas de compra
        private void deshabilitarAreasCompra()
        {
            button_Proveedores.Enabled = false;
            button_compras.Enabled = false;
            button_categorias.Enabled = false;
            button_productos.Enabled = false;
            button_Proveedores.BackgroundImage = Properties.Resources.Proveedores_grey;
            button_compras.BackgroundImage = Properties.Resources.Compras_grey;
            button_productos.BackgroundImage = Properties.Resources.Productos_grey;
            button_categorias.ForeColor = Color.FromArgb(233, 221, 223);
            label_Compras.ForeColor = Color.FromArgb(233, 221, 223);
            label_Productos.ForeColor = Color.FromArgb(233, 221, 223);
            label_Proveedores.ForeColor = Color.FromArgb(233, 221, 223);
        }

        // Método para habilitar las áreas de venta
        private void habilitarAreasVenta()
        {
            button_clientes.Enabled = true;
            button_ventas.Enabled = true;
            button_clientes.BackgroundImage = Properties.Resources.Clientes2;
            button_ventas.BackgroundImage = Properties.Resources.Ventas;
            label_Clientes.ForeColor = Color.FromArgb(219, 157, 170);
            label_Ventas.ForeColor = Color.FromArgb(219, 157, 170);
        }

        // Método para deshabilitar las áreas de venta
        private void deshabilitarAreasVenta()
        {
            button_clientes.Enabled = false;
            button_ventas.Enabled = false;
            button_clientes.BackgroundImage = Properties.Resources.Clientes_grey;
            button_ventas.BackgroundImage = Properties.Resources.Ventas_grey;
            label_Clientes.ForeColor = Color.FromArgb(233, 221, 223);
            label_Ventas.ForeColor = Color.FromArgb(233, 221, 223);
        }

        //Método para habilitar todos los elementos del menú
        private void habilitarTodosElementosMenu()
        {
            comprasToolStripMenuItem.Enabled = true;
            proveedoresToolStripMenuItem.Enabled = true;
            clientesToolStripMenuItem.Enabled = true;
            ventasToolStripMenuItem.Enabled = true;
            empleadosToolStripMenuItem.Enabled = true;
            productosToolStripMenuItem.Enabled = true;
            categoriasToolStripMenuItem.Enabled = true;
        }


        //Método para habilitar todos los elementos del menú del área de compra
        private void habilitarElementosMenuCompra()
        {
            comprasToolStripMenuItem.Enabled = true;
            proveedoresToolStripMenuItem.Enabled = true;
            clientesToolStripMenuItem.Enabled = false;
            ventasToolStripMenuItem.Enabled = false;
            empleadosToolStripMenuItem.Enabled = false;
            productosToolStripMenuItem.Enabled = true;
            categoriasToolStripMenuItem.Enabled = true;
        }

        //Método para habilitar todos los elementos del menú del área de venta
        private void habilitarElementosMenuVenta()
        {
            comprasToolStripMenuItem.Enabled = false;
            proveedoresToolStripMenuItem.Enabled = false;
            clientesToolStripMenuItem.Enabled = true;
            ventasToolStripMenuItem.Enabled = true;
            empleadosToolStripMenuItem.Enabled = false;
            productosToolStripMenuItem.Enabled = false;
            categoriasToolStripMenuItem.Enabled = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_compras_Click(sender, e);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Proveedores_Click(sender, e);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_clientes_Click(sender, e);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_ventas_Click(sender, e);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_empleados_Click(sender, e);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_categorias_Click(sender, e);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_productos_Click(sender, e);
        }

        private void label_Proveedores_Click(object sender, EventArgs e)
        {

        }
    }
}

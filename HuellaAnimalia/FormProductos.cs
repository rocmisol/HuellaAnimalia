using HuellaAnimalia.Database1DataSetTableAdapters;
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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Se establece la conexión dinámica
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Se aplica la nueva conexión a los tableadapters
            this.categoriaTableAdapter.Connection.ConnectionString = connectionString;
            this.productoTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            this.productoTableAdapter.Fill(this.database1DataSet.Producto);

            //TextBox deshabilitados al iniciar la aplicación
            deshabilitarEditText();

            // Botón aceptar, cancelar y guardar deshabilitados al iniciar la aplicación
            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
            deshabilitarButtonGuardar();

            // Se vacía el labelEstado
            labelEstado.Text = "";

            // Se actualiza el label del contador de clientes
            actualizarProductoIndice();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveFirst();
            actualizarProductoIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            productoBindingSource.MovePrevious();
            actualizarProductoIndice();
            actualizarEstadoBotonesNavegacion();
        }

        //Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveNext();
            actualizarProductoIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveLast();
            actualizarProductoIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón añadir
        private void button_aniadir_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtons();
            deshabilitarButtonGuardar();

            //Se deshabilita el combobox y el textoBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            //Se habilitan todos los EditText y se pone el foco en el nombre.
            habilitarEditText();
            nombre_productoTextBox.Select();

            // Se agrega un nuevo registro vacío al BindingSource
            productoBindingSource.AddNew();

            // Se limpian los campos del formulario para poder introducir nuevos datos
            limpiarFormulario();

            //Se establece valor por defecto en la categoría
            categoria_productoComboBox.SelectedIndex = 0;
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene clientes para eliminar
            if (productoBindingSource.Current != null)
            {
                // Se solicita confirmación antes de eliminar el cliente
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        productoBindingSource.RemoveCurrent(); // Se elimina el cliente actual
                        productoBindingSource.EndEdit(); // Se confirman los cambios
                        habilitarButtonGuardar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar el producto");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún producto para eliminar");
            }
        }


        // Botón editar
        private void button_editar_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo el de aceptar y cancenlar.
            deshabilitarButtons();
            deshabilitarButtonGuardar();

            // Se deshabilita el combobox y el textBoxBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            //Se habilitan todos los EditText y se pone el foco en el nombre.
            habilitarEditText();
            nombre_productoTextBox.Select();
        }

        // Botón Guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edición de BindingSource y se guarda en la base de datos
                productoBindingSource.EndEdit();
                productoTableAdapter.Update(database1DataSet.Producto);
                database1DataSet.AcceptChanges();

                labelEstado.Text = "Datos guardados en la base de datos";
                temporizador();

                // Se deshabilita el botón Guardar
                deshabilitarButtonGuardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón imprimir
        private void button_imprimir_Click(object sender, EventArgs e)
        {
            InformeProductos informe = new InformeProductos();
            informe.ShowDialog();
        }

        // Botón buscar
        private void button_buscar_Click(object sender, EventArgs e)
        {
            // Se verifica si el ComboBox tiene un valor seleccionado
            if (comboBoxBuscar.SelectedItem == null)
            {
                labelEstado.Text = "Por favor, selecciona un criterio de búsqueda.";
                temporizador();
                return;
            }
            //Criterio de búsqueda seleccionado en el comboBox (DNI o Teléfono)
            string criterioBusqueda = comboBoxBuscar.SelectedItem.ToString();

            //Valor introducido en el textBoxBuscar
            string valorBusqueda = textBoxBuscar.Text;

            // Se comprueba si el comboBox y el textBox tienen valores válidos
            if (string.IsNullOrEmpty(criterioBusqueda) || string.IsNullOrEmpty(valorBusqueda))
            {
                labelEstado.Text = "Selecciona un criterio y proporciona un valor de búsqueda";
                temporizador();
                return;
            }
            bool encontrado = buscarProducto(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ningún producto con esos datos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelEstado.Text = "Producto encontrado con éxito";
                temporizador();
                return;
            }
        }

        // Botón aceptar
        private void button_aceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (validarFormulario())
            {
                try
                {
                    //Se termina la edición y se habilitan los botones salvo el de aceptar y cancelar
                    productoBindingSource.EndEdit();
                    habilitarButtons();
                    habilitarButtonGuardar();
                    button_aceptar.Enabled = false;
                    button_cancelar.Enabled = false;
                    comboBoxBuscar.Enabled = true;
                    textBoxBuscar.Enabled = true;
                    deshabilitarEditText();

                    // Se muestra un mensaje de éxito de la operación
                    labelEstado.Text = "Producto actualizado correctamente.";
                    temporizador();

                    // Se actualiza el contador de clientes
                    actualizarProductoIndice();

                    //Se pone el foco en el botón ir a último.
                    button_primero.Select();

                    actualizarEstadoBotonesNavegacion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Se muestra un mensaje de error general
                labelEstado.Text = "Se deben completar todos los campos del formulario";
                temporizador();
            }
        }


        // Botón cancelar
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la operación?", "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Se limpian los errorProvider que haya
                errorProvider1.Clear();

                // Se cancela la edición
                productoBindingSource.CancelEdit();

                //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                habilitarButtons();
                habilitarButtonGuardar();

                // Se habilita el combobox y el textBoxBuscar
                comboBoxBuscar.Enabled = true;
                textBoxBuscar.Enabled = true;

                //Se deshabilitan los editText
                deshabilitarEditText();

                //Se pone el foco en el botón ir a último.
                button_primero.Select();

                actualizarEstadoBotonesNavegacion();
            }
        }

        // Subir imagen
        private void imagen_productoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { imagen_productoPictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { imagen_productoPictureBox.Image = null; }
        }

        // Cerrar el formulario
        private void FormProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable cambios = database1DataSet.Producto.GetChanges();

            if (cambios != null && cambios.Rows.Count > 0)
            {
                // Se pregunta al usuario si desea guardar los cambios
                DialogResult result = MessageBox.Show("¿Deseas guardar los cambios antes de salir?", "Guardar cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamamos al método de guardar datos
                    try
                    {
                        // Se guardan los cambios
                        productoBindingSource.EndEdit();
                        productoTableAdapter.Update(database1DataSet.Producto);
                        database1DataSet.AcceptChanges();

                        // Muestra Form2
                        this.Owner.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Muestra Form2
                    this.Owner.Show();
                }
                else
                {
                    // Se cancela el evento de cierre
                    e.Cancel = true;
                }
            }
            else
            {
                // Muestra Form2
                this.Owner.Show();
            }
        }

        // Método para actualizar el conteo de clientes
        private void actualizarProductoIndice()
        {
            labelProducto.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int clienteActual = productoBindingSource.Position + 1;
            int totalClientes = productoBindingSource.Count;
            labelProducto.Text = $"Cliente {clienteActual} de {totalClientes}";
        }

        // Método para habilitar los Buttons salvo aceptar y cancelar que se deshabilitan
        private void habilitarButtons()
        {
            button_primero.Enabled = true;
            button_primero.BackgroundImage = Properties.Resources.icon_first;

            button_anterior.Enabled = true;
            button_anterior.BackgroundImage = Properties.Resources.icon_previous;

            button_siguiente.Enabled = true;
            button_siguiente.BackgroundImage = Properties.Resources.icon_next;

            button_ultimo.Enabled = true;
            button_ultimo.BackgroundImage = Properties.Resources.icon_last;

            button_aniadir.Enabled = true;
            button_aniadir.BackgroundImage = Properties.Resources.icon_new;

            button_eliminar.Enabled = true;
            button_eliminar.BackgroundImage = Properties.Resources.icon_delete;

            button_editar.Enabled = true;
            button_editar.BackgroundImage = Properties.Resources.icon_edit;

            button_guardar.Enabled = true;
            button_guardar.BackgroundImage = Properties.Resources.icon_save;

            button_imprimir.Enabled = true;
            button_imprimir.BackgroundImage = Properties.Resources.icon_print;

            button_buscar.Enabled = true;
            button_buscar.BackgroundImage = Properties.Resources.icon_search;

            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;

            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
        }

        // Método para deshabilitar los Buttons salvo aceptar y cancelar que se habilitan
        private void deshabilitarButtons()
        {
            button_primero.Enabled = false;
            button_primero.BackgroundImage = Properties.Resources.icon_first_grey;

            button_anterior.Enabled = false;
            button_anterior.BackgroundImage = Properties.Resources.icon_previous_grey;

            button_siguiente.Enabled = false;
            button_siguiente.BackgroundImage = Properties.Resources.icon_next_grey;

            button_ultimo.Enabled = false;
            button_ultimo.BackgroundImage = Properties.Resources.icon_last_grey;

            button_aniadir.Enabled = false;
            button_aniadir.BackgroundImage = Properties.Resources.icon_add_grey;

            button_eliminar.Enabled = false;
            button_eliminar.BackgroundImage = Properties.Resources.icon_delete_grey;

            button_editar.Enabled = false;
            button_editar.BackgroundImage = Properties.Resources.icon_edit_grey;

            button_guardar.Enabled = false;
            button_guardar.BackgroundImage = Properties.Resources.icon_save_grey;

            button_imprimir.Enabled = false;
            button_imprimir.BackgroundImage = Properties.Resources.icon_print_grey;

            button_buscar.Enabled = false;
            button_buscar.BackgroundImage = Properties.Resources.icon_search_grey;

            button_aceptar.Enabled = true;
            button_aceptar.BackgroundImage = Properties.Resources.icon_accept;

            button_cancelar.Enabled = true;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel;
        }

        //Método para habilitar el botón guardar
        public void habilitarButtonGuardar()
        {
            button_guardar.Enabled = true;
            button_guardar.BackgroundImage = Properties.Resources.icon_save;
        }

        //Método para deshabilitar el botón guardar
        public void deshabilitarButtonGuardar()
        {
            button_guardar.Enabled = false;
            button_guardar.BackgroundImage = Properties.Resources.icon_save_grey;
        }

        // Método para habilitar los editText
        private void habilitarEditText()
        {
            nombre_productoTextBox.Enabled = true;
            marca_productoTextBox.Enabled = true;
            categoria_productoComboBox.Enabled = true;
            precio_compra_productoTextBox.Enabled = true;
            precio_venta_productoTextBox.Enabled = true;
            stock_productoTextBox.Enabled = true;
            descripcion_productoTextBox.Enabled = true;
            imagen_productoPictureBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            nombre_productoTextBox.Enabled = false;
            marca_productoTextBox.Enabled = false;
            categoria_productoComboBox.Enabled = false;
            precio_compra_productoTextBox.Enabled = false;
            precio_venta_productoTextBox.Enabled = false;
            stock_productoTextBox.Enabled = false;
            descripcion_productoTextBox.Enabled = false;
            imagen_productoPictureBox.Enabled = false;
        }

        // Método para vaciar todos los editText
        private void limpiarFormulario()
        {
            nombre_productoTextBox.Clear();
            marca_productoTextBox.Clear();
            categoria_productoComboBox.SelectedItem = null;
            precio_compra_productoTextBox.Clear();
            precio_venta_productoTextBox.Clear();
            stock_productoTextBox.Clear();
            descripcion_productoTextBox.Clear();
            imagen_productoPictureBox.Image = null;
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (productoBindingSource.Position > 0)
            {
                button_primero.Enabled = true;
                button_primero.BackgroundImage = Properties.Resources.icon_first;

                button_anterior.Enabled = true;
                button_anterior.BackgroundImage = Properties.Resources.icon_previous;
            }
            else
            {
                button_primero.Enabled = false;
                button_primero.BackgroundImage = Properties.Resources.icon_first_grey;

                button_anterior.Enabled = false;
                button_anterior.BackgroundImage = Properties.Resources.icon_previous_grey;
            }
            if (productoBindingSource.Position < productoBindingSource.Count - 1)
            {
                button_siguiente.Enabled = true;
                button_siguiente.BackgroundImage = Properties.Resources.icon_next;

                button_ultimo.Enabled = true;
                button_ultimo.BackgroundImage = Properties.Resources.icon_last;
            }
            else
            {
                button_siguiente.Enabled = false;
                button_siguiente.BackgroundImage = Properties.Resources.icon_next_grey;

                button_ultimo.Enabled = false;
                button_ultimo.BackgroundImage = Properties.Resources.icon_last_grey;
            }
                
        }

        // Metodo temporizador
        private void temporizador()
        {
            var timer = new Timer();
            timer.Interval = 3000; // 3 segundos
            timer.Tick += (s, args) =>
            {
                labelEstado.Text = ""; // Limpia el mensaje
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        // Método para buscar un producto
        private bool buscarProducto(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in productoBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if ((criterioBusqueda == "Codigo producto" && row["Id_producto"].ToString() == valorBusqueda)
                    || (criterioBusqueda == "Nombre producto" && row["Nombre_producto"].ToString() == valorBusqueda))
                {
                    //Se mueve el BindingSource a la posición encontrada
                    productoBindingSource.Position = productoBindingSource.List.IndexOf(row);
                    return true;
                }
            }
            return false;
        }

        // Método para validar el formulario
        private bool validarFormulario()
        {
            bool valido = true;

            // Se valida el nombre
            if (String.IsNullOrWhiteSpace(nombre_productoTextBox.Text))
            {
                errorProvider1.SetError(nombre_productoTextBox, "Se debe introducir el nombre del producto");
                valido = false;
            }

            // Se valida la marca
            if (string.IsNullOrWhiteSpace(marca_productoTextBox.Text))
            {
                errorProvider1.SetError(marca_productoTextBox, "Se deben introducir la marca del producto");
                valido = false;
            }

            // Se valida la categoría
            if (categoria_productoComboBox.SelectedValue == null)
            {
                errorProvider1.SetError(categoria_productoComboBox, "Se debe seleccionar la categoría del producto");
                valido = false;
            }
            
            // Se valida el precio de compra
            if (string.IsNullOrWhiteSpace(precio_compra_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_compra_productoTextBox, "Se deben introducir el precio de compra del producto");
                valido = false;
            }

            // Se valida el precio de venta
            if (string.IsNullOrWhiteSpace(precio_venta_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_venta_productoTextBox, "Se deben introducir el precio de venta del producto");
                valido = false;
            }

            // Se valida el stock del producto
            if (string.IsNullOrWhiteSpace(stock_productoTextBox.Text))
            {
                errorProvider1.SetError(stock_productoTextBox, "Se debe introducir el stock del producto");
                valido = false;
            }

            // Se valida la descripción
            if (string.IsNullOrWhiteSpace(descripcion_productoTextBox.Text))
            {
                errorProvider1.SetError(descripcion_productoTextBox, "Se debe introducir la descripción del prodcuto");
                valido = false;
            }
            return valido;
        }

        private void nombre_productoTextBox_Validating(object sender, CancelEventArgs e)
        {

            // Se valida el nombre
            if (String.IsNullOrWhiteSpace(nombre_productoTextBox.Text))
            {
                errorProvider1.SetError(nombre_productoTextBox, "Se debe introducir el nombre del producto");
            }
            else
            {
                errorProvider1.SetError(nombre_productoTextBox, "");
            }
        }

        private void marca_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida la marca
            if (string.IsNullOrWhiteSpace(marca_productoTextBox.Text))
            {
                errorProvider1.SetError(marca_productoTextBox, "Se deben introducir la marca del producto");
            }
            else
            {
                errorProvider1.SetError(marca_productoTextBox, "");
            }
        }

        private void categoria_productoComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida la categoría
            if (categoria_productoComboBox.SelectedValue == null)
            {
                errorProvider1.SetError(categoria_productoComboBox, "Se debe seleccionar la categoría del producto");
            }
            else
            {
                errorProvider1.SetError(categoria_productoComboBox, "");
            }
        }

        private void precio_compra_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida que el precio de compra no esté vacío
            if (string.IsNullOrWhiteSpace(precio_compra_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_compra_productoTextBox, "Se deben introducir el precio de compra (número) del producto");
            }
            else
            {
                // Se intenta convertir el texto a un número decimal
                decimal precio;
                if (!decimal.TryParse(precio_compra_productoTextBox.Text, out precio))
                {
                    // Si no es un número válido, se muestra un error
                    errorProvider1.SetError(precio_compra_productoTextBox, "Se deben introducir el precio de compra (número) del producto");
                }
                else
                {
                    // Si es válido, se limpia el error
                    errorProvider1.SetError(precio_compra_productoTextBox, "");
                }
            }

        }

        private void precio_venta_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida el precio de venta
            if (string.IsNullOrWhiteSpace(precio_venta_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_venta_productoTextBox, "Se deben introducir el precio de venta del producto");
            }
            else
            {
                // Se intenta convertir el texto a un número decimal
                decimal precio;
                if (!decimal.TryParse(precio_venta_productoTextBox.Text, out precio))
                {
                    // Si no es un número válido, se muestra un error
                    errorProvider1.SetError(precio_venta_productoTextBox, "Se deben introducir el precio de venta (número) del producto");
                }
                else
                {
                    // Si es válido, se limpia el error
                    errorProvider1.SetError(precio_venta_productoTextBox, "");
                }
            }
        }

        private void stock_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida el stock del producto
            if (string.IsNullOrWhiteSpace(stock_productoTextBox.Text))
            {
                errorProvider1.SetError(stock_productoTextBox, "Se debe introducir el stock del producto (número entero)");
            }
            else
            {
                // Se intenta convertir el texto a un número entero
                int stock;
                if (!int.TryParse(stock_productoTextBox.Text, out stock))
                {
                    // Si no es un número válido, se muestra un error
                    errorProvider1.SetError(precio_compra_productoTextBox, "Se debe introducir el stock del producto (número entero)");
                }
                else
                {
                    // Si es válido, se limpia el error
                    errorProvider1.SetError(precio_venta_productoTextBox, "");
                }
            }
        }

        private void descripcion_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida la descripción
            if (string.IsNullOrWhiteSpace(descripcion_productoTextBox.Text))
            {
                errorProvider1.SetError(descripcion_productoTextBox, "Se debe introducir la descripción del prodcuto");
            }
            else
            {
                errorProvider1.SetError(descripcion_productoTextBox, "");
            }
        }

        private void categoria_productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void imagen_productoLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.I) // Ir a Primero
            {
                button_primero.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.J) // Ir a Anterior
            {
                button_anterior.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.K) // Ir a Siguiente
            {
                button_siguiente.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.M) // Ir a Último
            {
                button_ultimo.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.A) // Añadir
            {
                button_aniadir.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.D) // Eliminar
            {
                button_eliminar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.E) // Editar
            {
                button_editar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.S) // Guardar
            {
                button_guardar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.P) // Imprimir informe
            {
                button_imprimir.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.F) // Buscar
            {
                button_buscar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.C) // Cancelar
            {
                button_cancelar.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.Enter) // Aceptar
            {
                button_aceptar.PerformClick();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Evento que solo permite introducir números enteros (campo stock)
        private void soloEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier carácter que no sea número o control
            }
        }

        // Evento que solo permite introducir números decimales (campos de precio)
        private void soloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir solo un único separador decimal (, o .)
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !textBox.Text.Contains(",") && !textBox.Text.Contains("."))
            {
                e.KeyChar = ','; // Usamos coma como separador decimal estándar
                return;
            }

            e.Handled = true; // Bloquea cualquier otra tecla
        }

        private void precio_compra_productoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

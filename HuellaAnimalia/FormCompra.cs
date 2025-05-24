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
    public partial class FormCompra : Form
    {
        bool mensajeMostrado = false;
        bool esMaestro = true;

        public FormCompra()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            // Se establece la conexión dinámica
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Se aplica a todos los tableadapters
            this.proveedorTableAdapter.Connection.ConnectionString = connectionString;
            this.productoTableAdapter.Connection.ConnectionString = connectionString;
            this.categoriaTableAdapter.Connection.ConnectionString = connectionString;
            this.detalleCompraTableAdapter.Connection.ConnectionString = connectionString;
            this.compraTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos desde la ruta final
            this.proveedorTableAdapter.Fill(this.database1DataSet.Proveedor);
            this.productoTableAdapter.Fill(this.database1DataSet.Producto);
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            this.detalleCompraTableAdapter.Fill(this.database1DataSet.DetalleCompra);
            this.compraTableAdapter.Fill(this.database1DataSet.Compra);

            // Se deshabilitan los textBox de los totales de compra sin impuestos y compra.
            total_sin_impuestos_compraTextBox.Enabled = false;
            total_compraTextBox.Enabled = false;

            // TextBox,combobox y fecha deshabilitados al iniciar la aplicación
            deshabilitarEditText();
            fecha_compraDateTimePicker.Enabled = false;
            id_proveedorComboBox.Enabled = false;
            metodo_pago_compraComboBox.Enabled = false;

            // Botón aceptar, cancelar y guardar deshabilitados al iniciar la aplicación
            deshabilitarButtonAceptar();
            deshabilitarButtonCancelar();
            deshabilitarButton_Guardar();

            //Se comprueba si hay guardada alguna compra previamente
            existeCompra();


            // Detalle_compra deshabilitado al iniciar la aplicación
            deshabilitarButtonsDetalle();
            deshabilitarEditTextDetalle();
            total_linea_detalle_compraTextBox.Enabled = false;
            deshabilitarButtonAceptarDetalle();
            deshabilitarButtonCancelarDetalle();
            deshabilitarButtonTerminar();
            detalleCompraDataGridView.Enabled = false;
            actualizarCompra();

            labelEstado.Text = "";

            //Se pone el foco en el botón button_primero.
            button_primero.Select();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            compraBindingSource.MoveFirst();
            actualizarCompra();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            compraBindingSource.MovePrevious();
            actualizarCompra();
            actualizarEstadoBotonesNavegacion();
        }

        //Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            compraBindingSource.MoveNext();
            actualizarCompra();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            compraBindingSource.MoveLast();
            actualizarCompra();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón añadir
        private void button_aniadir_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtons();
            habilitarButtonAceptar();
            habilitarButtonCancelar();

            //Se deshabilita el combobox y el textoBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            // Se agrega un nuevo registro vacío al BindingSource
            compraBindingSource.AddNew();

            // Se habilitan todos los editText, los combobox y la fecha
            habilitarEditText();
            fecha_compraDateTimePicker.Enabled = true;
            id_proveedorComboBox.Enabled = true;
            metodo_pago_compraComboBox.Enabled = true;

            //Se pone el foco en el nombre del proveedor.
            id_proveedorComboBox.Select();

            // Se establecen valores por defecto para el nombre del proveedor y el CIF
            id_proveedorComboBox.SelectedIndex = 0;
            if (proveedorBindingSource.Count > 0)
            {
                // Se asigna el primer valor de la base de datos al al TextBox
                cif_proveedorTextBox.Text = ((DataRowView)proveedorBindingSource[0])["Cif_proveedor"].ToString();
            }

            // Se establecen valores por defecto para el método de pago, impuesto, descuento, total sin impuestos el total de la venta y la fecha

            metodo_pago_compraComboBox.SelectedIndex = 1;
            impuestos_compraTextBox.Text = "21";
            descuento_compraTextBox.Text = "0";
            total_sin_impuestos_compraTextBox.Text = "0";
            total_compraTextBox.Text = "0";
            fecha_compraDateTimePicker.Value = DateTime.Now;
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene compras para eliminar
            if (compraBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar la compra?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                    // Se obtiene la compra actual
                    var compraActual = (Database1DataSet.CompraRow)((DataRowView) compraBindingSource.Current).Row;

                    // Se comprueba si existen líneas de detalle asociadas a la compra
                    var filaDetalleCompra = compraActual.GetDetalleCompraRows();

                    if (filaDetalleCompra.Length > 0)
                    {
                        try
                        {
                            foreach (var linea in filaDetalleCompra)
                            {
                                linea.Delete();
                            }
                            compraBindingSource.RemoveCurrent();
                            compraBindingSource.EndEdit();

                            //Se comprueba si hay alguna compra para deshabilitar el botón de editar
                            existeCompra();

                            //Se actualizan los botones de navegación
                            actualizarEstadoBotonesNavegacion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar la compra");
                        }
                    }
                    else
                    {
                        try
                        {
                            compraBindingSource.RemoveCurrent();
                            compraBindingSource.EndEdit();

                            //Se comprueba si hay alguna compra para deshabilitar el botón de editar
                            existeCompra();

                            //Se actualizan los botones de navegación
                            actualizarEstadoBotonesNavegacion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar la compra");
                        }
                    }
                }
            }
        }

        // Botón editar
        private void button_editar_Click(object sender, EventArgs e)
        {
            // Se deshailitan todos los botones salvo el de aceptar, cancelar y guardar
            deshabilitarButtons();
            habilitarButtonAceptar();
            habilitarButtonCancelar();
            deshabilitarButton_Guardar();

            // Se deshabilita el combobox y el texto buscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            // Se habilitan los editText
            habilitarEditText();

            //Se pone el foco en el nombre del proveedor.
            id_proveedorComboBox.Select();
        }

        // Botón guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edicción del bindingsource y se guarda en la base de datos
                compraBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.database1DataSet);

                labelEstado.Text = "Datos guardados en la base de datos";
                temporizador();

                // Se deshabilita el botón guardar
                deshabilitarButton_Guardar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón imprimir
        private void button_imprimir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numPedido = id_compraLabel1.Text;
            InformeCompras informe = new InformeCompras();
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

            //Criterio de búsqueda seleccionado en el comboBox (Nº de compra)
            string criterioBusqueda = comboBoxBuscar.SelectedItem.ToString();

            //Valor introducido en el textBoxBuscar
            string valorBusqueda = textBoxBuscar.Text;

            // Se comprueba si el comboBox y el textBox tienen valores válidos
            if (string.IsNullOrEmpty(criterioBusqueda) || string.IsNullOrEmpty(valorBusqueda))
            {
                labelEstado.Text = "Selecciona Nº compra e introduce un valor de búsqueda";
                temporizador();
                return;
            }
            bool encontrado = buscarCompra(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ninguna compra con ese número", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //Se termina la edición de la compra
                    compraBindingSource.EndEdit();

                    // Se guarda la compra el la base de datos
                    //compraTableAdapter.Update(database1DataSet.Compra);
                    //database1DataSet.AcceptChanges();

                    // Se deshabilitan los botones y editText de la compra
                    deshabilitarButtons();
                    deshabilitarEditText();
                    deshabilitarButtonAceptar();
                    deshabilitarButtonCancelar();

                    // Se habilitan los bottones y los editText
                    habilitarButtonsDetalle();
                    habilitarButtonTerminar();

                    // Se obtiene el Id_compra Generado
                    int idCompraActual = (int)database1DataSet.Compra.Rows[compraBindingSource.Position]["Id_compra"];

                    //Se comprueba si existe una línea de detalle en la compra para habilitar el botón de editar
                    existeDetalleCompra();

                    ///Se pone el foco en el primer botón del detalle.
                    button_anterior_detalle.Select();

                    //Se actualizan los botones de navegación del detalle
                    actualizarEstadoBotonesNavegacionDetalle();

                    esMaestro = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al procesar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                compraBindingSource.CancelEdit();

                //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                habilitarButtons();
                deshabilitarButtonAceptar();
                deshabilitarButtonCancelar();

                //Se comprueba si existe alguna compra. Si no hay se deshabilita el botón editar
                existeCompra();

                // Se habilita el combobox y el textBoxBuscar
                comboBoxBuscar.Enabled = true;
                textBoxBuscar.Enabled = true;

                //Se deshabilitan los editText
                deshabilitarEditText();

                // Se deshabilita el detalle de compra
                deshabilitarButtonsDetalle();
                deshabilitarEditTextDetalle();
                deshabilitarButtonAceptarDetalle();
                deshabilitarButtonCancelarDetalle();

                //Se actualizan los botones de navegación
                actualizarEstadoBotonesNavegacion();
            }
        }

        // Botón ir a primero (detalle)
        private void button_primero_detalle_Click(object sender, EventArgs e)
        {
            detalleCompraBindingSource.MoveFirst();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        // Botón ir a anterior (detalle)
        private void button_anterior_detalle_Click(object sender, EventArgs e)
        {
            detalleCompraBindingSource.MovePrevious();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        // Botón ir a siguiente (detalle)
        private void button_siguiente_detalle_Click(object sender, EventArgs e)
        {
            detalleCompraBindingSource.MoveNext();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        // Botón ir a último (detalle)
        private void button_ultimo_detalle_Click(object sender, EventArgs e)
        {
            detalleCompraBindingSource.MoveLast();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        // Botón añadir (detalle)
        private void button_aniadir_detalle_Click(object sender, EventArgs e)
        {
            // Se dehabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtonsDetalle();

            // Se habilitan todos los editText
            habilitarEditTextDetalle();

            // Se agrega un nuevo registro vacío al BindingSource
            detalleCompraBindingSource.AddNew();

            //Se pone el foco en el combobox categoría.
            categoria_productoComboBox.Select();

            // Se establece valor por defecto para la categoría
            categoria_productoComboBox.SelectedIndex = 0;

            //Se deshabilita el botón terminar
            deshabilitarButtonTerminar();

            mensajeMostrado = true;
        }

        // Botón eliminar (detalle)
        private void button_eliminar_detalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Se comprueba que hay un registro seleccionado
                if (detalleCompraBindingSource.Current == null)
                {
                    MessageBox.Show("No hay ninguna línea de compra para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Se confirma la eliminación con el usuario
                DialogResult confirmacion = MessageBox.Show("¿Seguro que deseas eliminar la línea de compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    // Se elimina el registro del BindingSource
                    detalleCompraBindingSource.RemoveCurrent();

                    //Se comprueba si existe una línea de detalle en la compra para habilitar el botón de editar
                    existeDetalleCompra();

                    // Se recalcula el precio después de eliminar
                    calcularTotalSinImpuestos();
                    calcularTotal();

                    // Se muestra un mensaje de confirmación en el label
                    labelEstado.Text = "Línea de compra eliminada.";
                    temporizador();

                    actualizarEstadoBotonesNavegacionDetalle();

                    mensajeMostrado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar la línea de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón editar (detalle)
        private void button_editar_detalle_Click(object sender, EventArgs e)
        {
            // Se deshailitan todos los botones salvo el de aceptar y cancelar
            deshabilitarButtonsDetalle();

            // Se habilitan los editText
            habilitarEditTextDetalle();

            //Se deshabilita el botón terminar
            deshabilitarButtonTerminar();

            //Se pone el foco en el combobox categoría.
            categoria_productoComboBox.Select();
        }

        // Botón aceptar (detalle)
        private void button_aceptar_detalle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (validarDetalle())
            {
                try
                {
                    // Se comprueba si el producto ya está en el detalle
                    if (id_productoComboBox.SelectedValue != null)
                    {
                        int idProductoSeleccionado = (int)id_productoComboBox.SelectedValue;

                        foreach (DataRowView row in detalleCompraBindingSource)
                        {
                            // Si el producto ya está en el detalle se muestra un mensaje
                            if (row != detalleCompraBindingSource.Current &&
                                (int)row["Id_producto"] == idProductoSeleccionado)
                            {
                                MessageBox.Show("El producto seleccionado ya está en el detalle. No se puede añadir de nuevo, modifícalo si lo deseas",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    // Se habilitan los botones del formulario salvo aceptar y cancelar que se deshabilitan
                    habilitarButtonsDetalle();
                    deshabilitarButtonAceptarDetalle();
                    deshabilitarButtonCancelarDetalle();

                    // Se habilita el botón terminar
                    habilitarButtonTerminar();

                    // Se termina la edición del BindingSource
                    detalleCompraBindingSource.EndEdit();

                    // Se actualiza la línea del DataGrid
                    detalleCompraDataGridView.Refresh();

                    // Se deshabilitan los editText
                    deshabilitarEditTextDetalle();

                    //Se comprueba si existe una línea de detalle en la compra para habilitar el botón de editar
                    existeDetalleCompra();

                    //Se pone el foco en el botón ir a primero del detalle.
                    button_primero_detalle.Select();

                    // Se recalcula la compra
                    calcularTotalSinImpuestos();
                    calcularTotal();

                    labelEstado.Text = "Línea de compra añadida";
                    temporizador();

                    actualizarEstadoBotonesNavegacionDetalle();

                    mensajeMostrado = false;
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error al procesar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelEstado.Text = "Se deben completar todos los campos del formulario";
                temporizador();
            }
        }

        // Botón cancelar (detalle)
        private void button_cancelar_detalle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la operación?", "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Se limpian los errorProvider que haya
                errorProvider1.Clear();

                id_productoComboBox.SelectedIndexChanged -= id_productoComboBox_SelectedIndexChanged;

                try
                {
                    // Se cancela la edición
                    detalleCompraBindingSource.CancelEdit();

                    //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                    habilitarButtonsDetalle();

                    //Se deshabilitan los editText
                    deshabilitarEditTextDetalle();

                    // Se habilita el botón terminar
                    habilitarButtonTerminar();

                    //Se comprueba si existe una línea de detalle en la compra para habilitar el botón de editar
                    existeDetalleCompra();

                    //Se pone el foco en el botón ir a primero del detalle.
                    button_primero_detalle.Select();

                    actualizarEstadoBotonesNavegacionDetalle();
                }
                finally
                {
                    id_productoComboBox.SelectedIndexChanged += id_productoComboBox_SelectedIndexChanged;
                }
            }
        }

        private void button_terminar_Click(object sender, EventArgs e)
        {
            // Comprobar si el valor en el TextBox es "0.00"
            if (total_linea_detalle_compraTextBox.Text == "0.00")
            {
                compraBindingSource.EndEdit();
                total_sin_impuestos_compraTextBox.Text = "0.00";
                total_compraTextBox.Text = "0.00";
            }
            else
            {
                compraBindingSource.EndEdit();
                calcularTotalSinImpuestos();
                calcularTotal();
            }

            habilitarButtons();
            deshabilitarButtonAceptar();
            deshabilitarButtonCancelar();
            deshabilitarButtonsDetalle();
            existeCompra();
            comboBoxBuscar.Enabled = true;
            textBoxBuscar.Enabled = true;
            deshabilitarButtonAceptarDetalle();
            deshabilitarButtonCancelarDetalle();
            deshabilitarButtonTerminar();

            actualizarCompra();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

            esMaestro = true;
        }

        // Cerrar formulario
        private void FormCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            compraBindingSource.EndEdit();

            DataTable cambios = database1DataSet.Compra.GetChanges();

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
                        compraBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(this.database1DataSet);
                        MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    // Se cierra sin guardar
                    MessageBox.Show("Los cambios no se guardaron.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Método para actualizar el conteo de compras
        private void actualizarCompra()
        {
            labelCompra.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int compraActual = compraBindingSource.Position + 1;
            int totalCompras = compraBindingSource.Count;
            labelCompra.Text = $"Compra {compraActual} de {totalCompras}";
        }

        // Método para habilitar los Buttons salvo aceptar y cancelar
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
        }

        // Método para deshabilitar los Buttons salvo aceptar y cancelar
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
        }

        //Método para deshabilitar el botón Aceptar
        private void deshabilitarButtonAceptar()
        {
            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
        }


        //Método para habilitar el botón Aceptar
        private void habilitarButtonAceptar()
        {
            button_aceptar.Enabled = true;
            button_aceptar.BackgroundImage = Properties.Resources.icon_accept;
        }

        //Método para deshabilitar el botón Cancelar
        private void deshabilitarButtonCancelar()
        {
            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
        }

        //Método para habilitar el botón Cancelar
        private void habilitarButtonCancelar()
        {
            button_cancelar.Enabled = true;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel;
        }

        //Método para deshabilitar el botón guardar
        private void deshabilitarButton_Guardar()
        {
            button_guardar.Enabled = false;
            button_guardar.BackgroundImage = Properties.Resources.icon_save_grey;
        }

        //Método para habilitar el botón guardar
        private void habilitarButton_Guardar()
        {
            button_guardar.Enabled = true;
            button_guardar.BackgroundImage = Properties.Resources.icon_save;
        }

        // Método para habilitar los editText
        private void habilitarEditText()
        {
            id_proveedorComboBox.Enabled = true;
            razon_socialTextBox.Enabled = true;
            cif_proveedorTextBox.Enabled = true;
            notas_compraTextBox.Enabled = true;
            fecha_compraDateTimePicker.Enabled = true;
            metodo_pago_compraComboBox.Enabled = true;
            descuento_compraTextBox.Enabled = true;
            impuestos_compraTextBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            id_proveedorComboBox.Enabled = false;
            razon_socialTextBox.Enabled = false;
            cif_proveedorTextBox.Enabled= false;
            notas_compraTextBox.Enabled = false;
            fecha_compraDateTimePicker.Enabled = false;
            metodo_pago_compraComboBox.Enabled = false;
            descuento_compraTextBox.Enabled = false;
            impuestos_compraTextBox.Enabled = false;
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (compraBindingSource.Position > 0)
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
            if (compraBindingSource.Position < compraBindingSource.Count - 1)
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

        // Método para actualizar el estado de los botones de navegación del detalle
        private void actualizarEstadoBotonesNavegacionDetalle()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (detalleCompraBindingSource.Position > 0)
            {
                button_primero_detalle.Enabled = true;
                button_primero_detalle.BackgroundImage = Properties.Resources.icon_first;

                button_anterior_detalle.Enabled = true;
                button_anterior_detalle.BackgroundImage = Properties.Resources.icon_previous;
            }
            else
            {
                button_primero_detalle.Enabled = false;
                button_primero_detalle.BackgroundImage = Properties.Resources.icon_first_grey;

                button_anterior_detalle.Enabled = false;
                button_anterior_detalle.BackgroundImage = Properties.Resources.icon_previous_grey;
            }
            if (detalleCompraBindingSource.Position < detalleCompraBindingSource.Count - 1)
            {
                button_siguiente_detalle.Enabled = true;
                button_siguiente_detalle.BackgroundImage = Properties.Resources.icon_next;

                button_ultimo_detalle.Enabled = true;
                button_ultimo_detalle.BackgroundImage = Properties.Resources.icon_last;
            }
            else
            {
                button_siguiente_detalle.Enabled = false;
                button_siguiente_detalle.BackgroundImage = Properties.Resources.icon_next_grey;

                button_ultimo_detalle.Enabled = false;
                button_ultimo_detalle.BackgroundImage = Properties.Resources.icon_last_grey;
            }

        }

        // Método temporizador
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

        //Método para comprobar si hay compras
        private void existeCompra()
        {
            if (compraBindingSource == null || compraBindingSource.Count == 0) 
            {
                button_editar.Enabled = false;
                button_editar.BackgroundImage = Properties.Resources.icon_edit_grey;
            }
            else
            {
                button_editar.Enabled = true;
                button_editar.BackgroundImage = Properties.Resources.icon_edit;
            }
        }

        // Método para buscar una compra
        private bool buscarCompra(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in compraBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if (criterioBusqueda == "Nº compra" && row["Id_compra"].ToString() == valorBusqueda)
                {
                    //Se mueve el BindingSource a la posición encontrada
                    compraBindingSource.Position = compraBindingSource.List.IndexOf(row);
                    return true;
                }
            }
            return false;
        }


       

        private void habilitarButtonsDetalle()
        {
            button_primero_detalle.Enabled = true;
            button_primero_detalle.BackgroundImage = Properties.Resources.icon_first;

            button_anterior_detalle.Enabled = true;
            button_anterior_detalle.BackgroundImage = Properties.Resources.icon_previous;

            button_siguiente_detalle.Enabled = true;
            button_siguiente_detalle.BackgroundImage = Properties.Resources.icon_next;

            button_ultimo_detalle.Enabled = true;
            button_ultimo_detalle.BackgroundImage = Properties.Resources.icon_last;

            button_aniadir_detalle.Enabled = true;
            button_aniadir_detalle.BackgroundImage = Properties.Resources.icon_new;

            button_editar_detalle.Enabled = true;
            button_editar_detalle.BackgroundImage = Properties.Resources.icon_edit;

            button_eliminar_detalle.Enabled = true;
            button_eliminar_detalle.BackgroundImage = Properties.Resources.icon_delete;

            button_aceptar_detalle.Enabled = false;
            button_aceptar_detalle.BackgroundImage = Properties.Resources.icon_acept_grey;

            button_cancelar_detalle.Enabled = false;
            button_cancelar_detalle.BackgroundImage = Properties.Resources.icon_cancel_grey;
        }

        //Métdo para deshabilitar los Buttons del detalle
        private void deshabilitarButtonsDetalle()
        {
            button_primero_detalle.Enabled = false;
            button_primero_detalle.BackgroundImage = Properties.Resources.icon_first_grey;

            button_anterior_detalle.Enabled = false;
            button_anterior_detalle.BackgroundImage = Properties.Resources.icon_previous_grey;

            button_siguiente_detalle.Enabled = false;
            button_siguiente_detalle.BackgroundImage = Properties.Resources.icon_next_grey;

            button_ultimo_detalle.Enabled = false;
            button_ultimo_detalle.BackgroundImage = Properties.Resources.icon_last_grey;

            button_aniadir_detalle.Enabled = false;
            button_aniadir_detalle.BackgroundImage = Properties.Resources.icon_add_grey;

            button_editar_detalle.Enabled = false;
            button_editar_detalle.BackgroundImage = Properties.Resources.icon_edit_grey;

            button_eliminar_detalle.Enabled = false;
            button_eliminar_detalle.BackgroundImage = Properties.Resources.icon_delete_grey;

            button_aceptar_detalle.Enabled = true;
            button_aceptar_detalle.BackgroundImage = Properties.Resources.icon_accept;

            button_cancelar_detalle.Enabled = true;
            button_cancelar_detalle.BackgroundImage = Properties.Resources.icon_cancel;
        }

        //Método para habilitar el botón aceptar del detalle
        private void habilitarButtonAceptarDetalle()
        {
            button_aceptar_detalle.Enabled = true;
            button_aceptar_detalle.BackgroundImage = Properties.Resources.icon_accept;
        }

        //Método para deshabilitar el botón aceptar del detalle
        private void deshabilitarButtonAceptarDetalle()
        {
            button_aceptar_detalle.Enabled = false;
            button_aceptar_detalle.BackgroundImage = Properties.Resources.icon_acept_grey;
        }

        //Método para habilitar el botón cancelar del detalle
        private void habilitarButtonCancelarDetalle()
        {
            button_cancelar_detalle.Enabled = true;
            button_cancelar_detalle.BackgroundImage = Properties.Resources.icon_cancel;
        }

        //Método para deshabilitar el botón cancelar del detalle
        private void deshabilitarButtonCancelarDetalle()
        {
            button_cancelar_detalle.Enabled = false;
            button_cancelar_detalle.BackgroundImage = Properties.Resources.icon_cancel_grey;
        }


        //Método para deshabilitar el botón terminar
        private void deshabilitarButtonTerminar()
        {
            button_terminar.Enabled = false;
            button_terminar.BackColor = ColorTranslator.FromHtml("#E9DDDF");
            button_terminar.ForeColor = Color.White;
        }

        //Método para habilitar el botón terminar
        private void habilitarButtonTerminar()
        {
            button_terminar.Enabled = true;
            button_terminar.BackColor = ColorTranslator.FromHtml("#DB9DAA");
            button_terminar.ForeColor = Color.White;
        }

        //Método para comprobar si hay líneas de detalle en la compra
        private void existeDetalleCompra()
        {
            if (detalleCompraBindingSource == null || detalleCompraBindingSource.Count == 0)
            {
                button_editar_detalle.Enabled = false;
                button_editar_detalle.BackgroundImage = Properties.Resources.icon_edit_grey;
            }
            else
            {
                button_editar_detalle.Enabled = true;
                button_editar_detalle.BackgroundImage = Properties.Resources.icon_edit;
            }
        }

        // Método para validar el formulario
        private bool validarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Se valida el combobox proveedor
            if (id_proveedorComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(id_proveedorComboBox, "Se debe seleccionar un proveedor");
                valido = false;
            }

            // Se valida el CIF
            if (string.IsNullOrWhiteSpace(cif_proveedorTextBox.Text))
            {
                errorProvider1.SetError(cif_proveedorTextBox, "Se debe introducir el CIF del proveedor");
                valido = false;
            }

            // Se valida la fecha
            if (fecha_compraDateTimePicker.Value == null)
            {
                errorProvider1.SetError(fecha_compraDateTimePicker, "Se debe seleccionar una fecha de compra ");
                valido = false;
            }

            // Se valida el método de pago
            if (metodo_pago_compraComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(metodo_pago_compraComboBox, "Se debe seleccionar un método de pago");
                valido = false;
            }

            // Se valida el impuesto de compra
            if (string.IsNullOrWhiteSpace(impuestos_compraTextBox.Text))
            {
                errorProvider1.SetError(impuestos_compraTextBox, "Se debe introducir el impuesto de compra aplicado");
                valido = false;
            }
            return valido;
        }

        // Método para deshabilitar los editText y el comboBox (Detalle)
        private void deshabilitarEditTextDetalle()
        {
            id_productoComboBox.Enabled = false;
            categoria_productoComboBox.Enabled = false;
            cantidad_productoTextBox.Enabled = false;
            marca_productoTextBox.Enabled = false;
            precio_compra_productoTextBox.Enabled = false;
            
        }

        // Método para habilitar los editText y el comboBox (Detalle)
        private void habilitarEditTextDetalle()
        {
            id_productoComboBox.Enabled = true;
            categoria_productoComboBox.Enabled = true;
            cantidad_productoTextBox.Enabled = true;
            marca_productoTextBox.Enabled = true;
            precio_compra_productoTextBox.Enabled = true;
        }

        // Método para limpiar el formulario detalle
        public void limpiarFormularioDetalle()
        {
            id_productoComboBox.SelectedItem = null;
            categoria_productoComboBox.SelectedItem = null;
            cantidad_productoTextBox.Clear();
            marca_productoTextBox.Clear();
            precio_compra_productoTextBox.Clear();
            total_linea_detalle_compraTextBox.Clear();

        }

        // Método para calcular el total de la línea
        private void calcularTotalLinea()
        {
            if (decimal.TryParse(cantidad_productoTextBox.Text, out decimal cantidad) &&
                    decimal.TryParse(precio_compra_productoTextBox.Text, out decimal precio))
            {
                decimal totalLinea = cantidad * precio;
                total_linea_detalle_compraTextBox.Text = totalLinea.ToString("0.00");
            }
            else
            {
                total_linea_detalle_compraTextBox.Text = "0.00";
            }
        }

        // Método para validar el Detalle de la compra
        private bool validarDetalle()
        {
            bool valido = true;
            if (id_productoComboBox.SelectedIndex == null)
            {
                errorProvider1.SetError(id_productoComboBox, "Se debe seleccionar un prodcuto");
                valido = false;
            }        
            if (categoria_productoComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(categoria_productoComboBox, "Se debe seleccionar la categoría del producto");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(cantidad_productoTextBox.Text))
            {
                errorProvider1.SetError(cantidad_productoTextBox, "Se debe introducir la cantidad del producto");
                valido = false;
            }
            if (!decimal.TryParse(cantidad_productoTextBox.Text, out decimal canditad))
            {
                errorProvider1.SetError(cantidad_productoTextBox, "La cantidad debe ser un número mayor que cero");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(marca_productoTextBox.Text))
            {
                errorProvider1.SetError(marca_productoTextBox, "Se debe introducir la marca del producto");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(precio_compra_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_compra_productoTextBox, "Se debe introducir el precio de compra del producto");
                valido = false;
            }
            return valido;
        }

        // Método para calcular el total de la compra sin impuestos y sin descuento
        private void calcularTotalCompraSinImpuestosSinDescuento()
        {
            decimal totalCompra = 0;
            foreach (DataRow row in database1DataSet.DetalleCompra.Rows)
            {
                if (row.RowState != DataRowState.Deleted && decimal.TryParse(row["Total_sin_impuestos_compra"].ToString(), out decimal totalLinea))
                {
                    totalCompra += totalLinea;
                }
            }
            total_sin_impuestos_compraTextBox.Text = totalCompra.ToString("0.00");

        }

        // Método para calcular el total de la compra con sin impuestos y sin descuento
        private void calcularTotalSinImpuestos()
        {
            // Comprobar si el valor en el TextBox es "0.00"
            if (total_linea_detalle_compraTextBox.Text == "0.00")
            {
                total_sin_impuestos_compraTextBox.Text = "0.00";
            }
            else
            {
                decimal totalSinImpuestos = 0;
                try
                {
                    if (database1DataSet.DetalleCompra.Count == 0)
                    {
                        // Si no hay detalles, se asigna cero
                        total_sin_impuestos_compraTextBox.Text = totalSinImpuestos.ToString("F2");
                        return;
                    }

                    int numero_compra = 0;
                    // Se suma el valor de total_linea al total sin impuestos
                    foreach (var detalle in database1DataSet.DetalleCompra)
                    {
                        if (detalle.RowState != DataRowState.Deleted)
                        {
                            if (detalle.Id_compra == numero_compra)
                            {
                                totalSinImpuestos += detalle.Total_linea_detalle_venta;// Está mal el nombre en la BBDD
                            }
                            else
                            {
                                totalSinImpuestos = 0;
                                numero_compra = detalle.Id_compra;
                                totalSinImpuestos += detalle.Total_linea_detalle_venta; // Está mal el nombre en la BBDD
                            }
                        }
                    }
                }
                catch
                {
                    // Si ocurre un error, se asigna cero
                    totalSinImpuestos = 0;
                }
                // Muestra el total sin impuestos en el textBox
                total_sin_impuestos_compraTextBox.Text = totalSinImpuestos.ToString("F2");
            }
        }


        // Método para calcular el total de la compra con con impuestos y con descuento
        private void calcularTotal()
        {
            // Se obtiene el subtotal sin impuestos
            decimal totalSinImpuesos = 0;
            if (!decimal.TryParse(total_sin_impuestos_compraTextBox.Text, out totalSinImpuesos) || totalSinImpuesos < 0)
            {
                totalSinImpuesos = 0;
            }
            // Se obtiene el porcentaje de impuestos
            decimal impuestos = 21; // Valor predeterminado
            if (!decimal.TryParse(impuestos_compraTextBox.Text, out impuestos) || impuestos < 0)
            {
                impuestos = 21;
            }

            // Se calcula el total con impuestos
            decimal totalConImpuestos = totalSinImpuesos + (totalSinImpuesos * impuestos / 100);

            // Se obtiene el descuento (si lo hay)
            decimal descuento = 0;
            if (!decimal.TryParse(descuento_compraTextBox.Text, out descuento) || descuento < 0)
            {
                descuento = 0;
            }

            // Se aplica el descuento al total con impuestos
            decimal totalFinal = totalConImpuestos - (totalConImpuestos * descuento /100);


            // Se asegura que el total no sea negativo
            if (totalFinal < 0)
            {
                totalFinal = 0;
            }

            // Se acutaliza el valor del textBox
            total_compraTextBox.Text = totalFinal.ToString("F2");

        }

        private void impuestos_compraTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalSinImpuestos();
            calcularTotal();
        }

        private void descuento_compraTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalSinImpuestos();
            calcularTotal();
        }


        private void id_compraLabel3_Click(object sender, EventArgs e)
        {

        }

        


        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se compruena si se ha seleccionado una categoría previamente
            if (categoria_productoComboBox.SelectedValue == null & id_productoComboBox.SelectedIndex != -1)
            {
                if (mensajeMostrado)
                {
                    MessageBox.Show("Se debe seleccionar primero la categoría del producto", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mensajeMostrado = true;
                }

                //id_productoComboBox.SelectedIndex = -1;
                return;
            }

            if (id_productoComboBox.SelectedValue != null)
            {
                // Si no hay cantidad previamente definida, se pone a 1
                if (string.IsNullOrEmpty(cantidad_productoTextBox.Text))
                {
                    cantidad_productoTextBox.Text = "1";
                }

                // Se obtiene el id del producto seleccionado
                int idProductoSeleccionado = (int)id_productoComboBox.SelectedValue;

                // Se busca el producto seleccionado en la tabla Producto
                var productoSeleccionado = database1DataSet.Producto.FindById_producto(idProductoSeleccionado);

                // Se actualiza la marca y el precio
                marca_productoTextBox.Text = productoSeleccionado.Marca_producto;
                precio_compra_productoTextBox.Text = productoSeleccionado.Precio_compra_producto.ToString("F2");
                nombre_productoTextBox.Text = productoSeleccionado.Nombre_producto;
            }
        }

        private void total_linea_detalle_compraTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }

        

        

        private void id_proveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se verifica que hay un cliente seleccionado en el combobox
            if (id_proveedorComboBox.SelectedValue != null)
            {
                var proveedorRow = database1DataSet.Proveedor.FindById_proveedor((int)id_proveedorComboBox.SelectedValue);
                cif_proveedorTextBox.Text = proveedorRow.Cif_proveedor.ToString();
                razon_socialTextBox.Text = proveedorRow.Razon_social.ToString();
                fecha_compraDateTimePicker.Value = DateTime.Now.Date;
            }
            else
            {
                cif_proveedorTextBox.Clear();
            }
        }

        private void detalleCompraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoria_productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoria_productoComboBox.SelectedValue != null)
            {
                // Se obtiene el nombre de la categoría seleccionada
                string categoriaSeleccionada = categoria_productoComboBox.SelectedValue.ToString();

                // Se filtran los productos según la categoría seleccionada
                productoBindingSource.Filter = $"Categoria_producto = '{categoriaSeleccionada}'";
            }
        }

        private void cantidad_productoTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }

        private void precio_compra_productoTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }

        private void metodo_pago_compraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Validating proveedor
        private void id_proveedorComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_proveedorComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(id_proveedorComboBox, "Se debe seleccionar un proveedor");
            }
            else
            {
                errorProvider1.SetError(id_proveedorComboBox, "");
            }
        }

        // Validating CIF
        private void cif_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cif_proveedorTextBox.Text))
            {
                errorProvider1.SetError(cif_proveedorTextBox, "Se debe introducir el CIF del proveedor");
            }
            else
            {
                errorProvider1.SetError(cif_proveedorTextBox, "");
            }
        }

        // Validating fecha de compra
        private void fecha_compraDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (fecha_compraDateTimePicker.Value == null)
            {
                errorProvider1.SetError(fecha_compraDateTimePicker, "Se debe seleccionar una fecha de compra ");
            }
            else
            {
                errorProvider1.SetError(fecha_compraDateTimePicker, "");
            }
        }

        // Validating método de pago
        private void metodo_pago_compraComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (metodo_pago_compraComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(metodo_pago_compraComboBox, "Se debe seleccionar un método de pago");
            }
            else
            {
                errorProvider1.SetError(metodo_pago_compraComboBox, "");
            }
        }

        private void descuento_compraTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        // Validating impuesto compra
        private void impuestos_compraTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(impuestos_compraTextBox.Text))
            {
                errorProvider1.SetError(impuestos_compraTextBox, "Se debe introducir el impuesto de compra aplicado");
            }
            else
            {
                errorProvider1.SetError(impuestos_compraTextBox, "");
            }
        }

        private void total_sin_impuestos_compraTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        // Validating categoria
        private void categoria_productoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (categoria_productoComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(categoria_productoComboBox, "Se debe seleccionar la categoría del producto");
            }
            else
            {
                errorProvider1.SetError(categoria_productoComboBox, "");
            }
        }

        // Validating producto
        private void id_productoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_productoComboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(id_productoComboBox.Text))
            {
                errorProvider1.SetError(id_productoComboBox, "Se debe seleccionar un producto");
            }
            else
            {
                errorProvider1.SetError(id_productoComboBox, "");
            }
        }

        // Validating cantidad
        private void cantidad_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(cantidad_productoTextBox.Text, out decimal canditad))
            {
                errorProvider1.SetError(cantidad_productoTextBox, "La cantidad debe ser un número mayor que cero");
            }
            else
            {
                errorProvider1.SetError(cantidad_productoTextBox, "");
            }
        }

        // Validating marca
        private void marca_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(marca_productoTextBox.Text))
            {
                errorProvider1.SetError(marca_productoTextBox, "Se debe introducir la marca del producto");
            }
            else
            {
                errorProvider1.SetError(marca_productoTextBox, "");
            }
        }

        // Validating precio venta
        private void precio_compra_productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(precio_compra_productoTextBox.Text, out decimal canditad))
            {
                errorProvider1.SetError(precio_compra_productoTextBox, "La cantidad debe ser un número mayor que cero");
            }
            else
            {
                errorProvider1.SetError(precio_compra_productoTextBox, "");
            }
        }

        private void total_linea_detalle_compraTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void FormCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.I) // Ir a Primero
            {
                if (esMaestro)
                {
                    button_primero.PerformClick();
                }
                else
                {
                    button_primero_detalle.PerformClick();
                }

            }
            else if (e.Alt && e.KeyCode == Keys.J) // Ir a Anterior
            {
                if (esMaestro)
                {
                    button_anterior.PerformClick();
                }
                else
                {
                    button_anterior_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.K) // Ir a Siguiente
            {
                if (esMaestro)
                {
                    button_siguiente.PerformClick();
                }
                else
                {
                    button_siguiente_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.M) // Ir a Último
            {
                if (esMaestro)
                {
                    button_ultimo.PerformClick();
                }
                else
                {
                    button_ultimo_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.A) // Añadir
            {
                if (esMaestro)
                {
                    button_aniadir.PerformClick();
                }
                else
                {
                    button_aniadir_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.D) // Eliminar
            {
                if (esMaestro)
                {
                    button_eliminar.PerformClick();
                }
                else
                {
                    button_eliminar_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.E) // Editar
            {
                if (esMaestro)
                {
                    button_editar.PerformClick();
                }
                else
                {
                    button_editar_detalle.PerformClick();
                }
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
                if (esMaestro)
                {
                    button_cancelar.PerformClick();
                }
                else
                {
                    button_cancelar_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.Enter) // Aceptar
            {
                if (esMaestro)
                {
                    button_aceptar.PerformClick();
                }
                else
                {
                    button_aceptar_detalle.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.T) // Terminar
            {
                button_terminar.PerformClick();
            }
        }

        

        
    }
    
}

using HuellaAnimalia.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaAnimalia
{
    public partial class FormVenta : Form
    {
        bool mensajeMostrado = false;
        bool esMaestro = true;

        public FormVenta()
        {
            InitializeComponent();

        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            // Se establece la conexión dinámica
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Se aplica la nueva coneción
            this.categoriaTableAdapter.Connection.ConnectionString = connectionString;
            this.productoTableAdapter.Connection.ConnectionString = connectionString;
            this.clienteTableAdapter.Connection.ConnectionString = connectionString;
            this.detalleVentaTableAdapter.Connection.ConnectionString = connectionString;
            this.ventaTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            this.productoTableAdapter.Fill(this.database1DataSet.Producto);
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);
            this.detalleVentaTableAdapter.Fill(this.database1DataSet.DetalleVenta);
            this.ventaTableAdapter.Fill(this.database1DataSet.Venta);

            detalleVentaDataGridView.DataError += detalleVentaDataGridView_DataError;

            // Se deshabilitan los textBox de los totales de línea, venta sin impuestos y venta.
            total_linea_detalle_ventaTextBox.Enabled = false;
            total_sin_impuestos_ventaTextBox.Enabled = false;
            total_ventaTextBox.Enabled = false;


            // TextBox, combobox,  deshabilitados al iniciar la aplicación, los combobox y la fecha
            deshabilitarEditText();
            fecha_ventaDateTimePicker.Enabled = false;
            id_clienteComboBox.Enabled = false;
            comboBoxMetodoPago.Enabled = false;

            // Botón aceptar, cancelar y guardar deshabilitados al iniciar la aplicación
            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
            button_guardar.Enabled = false;

            //Se comprueba si hay guardada alguna compra previamente
            existeVenta();

            // Detalle_venta deshabilitado al iniciar la aplicación
            deshabilitarButtonsDetalle();
            deshabilitarEditTextDetalle();
            deshabilitarButtonAceptarDetalle();
            deshabilitarButtonCancelarDetalle();
            deshabilitarButtonTerminar();
            actualizarVenta();
            detalleVentaDataGridView.Enabled = false;

            labelEstado.Text = "";

            //Se pone el foco en el botón button_primero.
            button_primero.Select();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveFirst();
            actualizarVenta();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MovePrevious();
            actualizarVenta();
            actualizarEstadoBotonesNavegacion();
        }

        //Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveNext();
            actualizarVenta();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveLast();
            actualizarVenta();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón añadir
        private void button_aniadir_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtons();

            //Se deshabilita el combobox y el textoBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            // Se habilitan todos los editText, los combobox y la fecha
            habilitarEditText();
            fecha_ventaDateTimePicker.Enabled = true;
            id_clienteComboBox.Enabled = true;
            comboBoxMetodoPago.Enabled = true;

            //Se pone el foco en el nombre.
            id_clienteComboBox.Select();

            // Se agrega un nuevo registro vacío al BindingSource
            ventaBindingSource.AddNew();

            // Se establecen valores por defecto para el nombre del cliente y el DNI
            id_clienteComboBox.SelectedIndex = 0;
            if (clienteBindingSource.Count > 0)
            {
                // Se asigna el primer valor de la base de datos al al TextBox
                dni_clienteTextBox.Text = ((DataRowView)clienteBindingSource[0])["Dni_cliente"].ToString();
            }

            // Se establecen valores por defecto para el método de pago, impuesto y el descuento
            comboBoxMetodoPago.SelectedIndex = 1;
            impuestos_ventaTextBox.Text = "21";
            descuento_ventaTextBox.Text = "0";
            
            fecha_ventaDateTimePicker.Value = DateTime.Now;

            // Se establecen a cero el total sin impuestos y el total de la venta
            total_sin_impuestos_ventaTextBox.Text = "0";
            total_ventaTextBox.Text = "0";
        }

        
        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene ventas para eliminar
            if (ventaBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar la venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Se obtiene la venta actual
                    var ventaActual = (Database1DataSet.VentaRow)((DataRowView) ventaBindingSource.Current).Row;

                    // Se comprueba si existen líneas de detalle asociadas a la venta
                    var filaDetalleVenta = ventaActual.GetDetalleVentaRows();

                    if (filaDetalleVenta.Length > 0)
                    {
                        try
                        {
                            foreach (var linea in filaDetalleVenta)
                            {
                                linea.Delete();
                            }
                            ventaBindingSource.RemoveCurrent();
                            ventaBindingSource.EndEdit();

                            //Se comprueba si hay alguna venta para deshabilitar el botón de editar
                            existeVenta();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar la venta");
                        }
                    }
                    else
                    {
                        try
                        {
                            ventaBindingSource.RemoveCurrent();
                            ventaBindingSource.EndEdit();

                            //Se comprueba si hay alguna venta para deshabilitar el botón de editar
                            existeVenta();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar la venta");
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
            button_guardar.Enabled = false;

            // Se deshabilita el combobox y el texto buscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            // Se habilitan los editText y el combobox
            habilitarEditText();

            //Se pone el foco en el nombre.
            id_clienteComboBox.Select();

            // Se deshabilitar el gridview
            //detalleVentaDataGridView.Enabled = false;
        }

        // Botón guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edicción del bindingsource y se guarda en la base de datos
                ventaBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.database1DataSet);

                labelEstado.Text = "Datos guardados en la base de datos";
                temporizador();

                // Se deshabilita el botón guardar
                button_guardar.Enabled = false;
            }
            
            catch (Exception ex) 
            {
                MessageBox.Show("Ha ocurrido un error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        // Botón imprimir
        private void button_imprimir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numPedido = idVentaLabel.Text;
            InformeVentas informe = new InformeVentas();
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
            //Criterio de búsqueda seleccionado en el comboBox (Nº de venta)
            string criterioBusqueda = comboBoxBuscar.SelectedItem.ToString();

            //Valor introducido en el textBoxBuscar
            string valorBusqueda = textBoxBuscar.Text;

            // Se comprueba si el comboBox y el textBox tienen valores válidos
            if (string.IsNullOrEmpty(criterioBusqueda) || string.IsNullOrEmpty(valorBusqueda))
            {
                labelEstado.Text = "Selecciona Nº venta e introduce un valor de búsqueda";
                temporizador();
                return;
            }
            bool encontrado = buscarVenta(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ninguna venta con ese número", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //Se termina la edición de la venta
                    ventaBindingSource.EndEdit();

                    // Se guarda la venta el la base de datos
                    //ventaTableAdapter.Update(database1DataSet.Venta);
                    //database1DataSet.AcceptChanges();

                    // Se deshabilitan los botones y editText de la venta
                    deshabilitarButtons();
                    deshabilitarEditText();
                    button_aceptar.Enabled = false;
                    button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
                    button_cancelar.Enabled = false;
                    button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;


                    // Se habilitan los bottones, los editText, el botón terminar
                    habilitarButtonsDetalle();
                    habilitarButtonTerminar();

                    // Se obtiene el Id_venta Generado
                    int idVentaActual = (int)database1DataSet.Venta.Rows[ventaBindingSource.Position]["Id_venta"];

                    //Se comprueba si existe una línea de detalle en la venta para habilitar el botón de editar
                    existeDetalleVenta();

                    //Se pone el foco en el botón button_primero_detalle
                    button_primero_detalle.Select();

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
                ventaBindingSource.CancelEdit();

                //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                habilitarButtons();

                //Se comprueba si existe alguna venta. Si no hay se deshabilita el botón editar
                existeVenta();

                // Se habilita el combobox y el textBoxBuscar
                comboBoxBuscar.Enabled = true;
                textBoxBuscar.Enabled = true;

                //Se deshabilitan los editText
                deshabilitarEditText();

                // Se deshabilita el detalle de venta
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
            detalleVentaBindingSource.MoveFirst();
            actualizarEstadoBotonesNavegacionDetalle();

        }

        // Botón ir a anterior  (detalle)
        private void button_anterior_detalle_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MovePrevious();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        //Botón ir a siguiente (detalle)
        private void button_siguiente_detalle_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MoveNext();
            actualizarEstadoBotonesNavegacionDetalle();
        }

        // Botón ir a último (detalle)
        private void button_ultimo_detalle_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MoveLast();
            actualizarEstadoBotonesNavegacionDetalle();
        }


        // Botón añadir (detalle)
        private void button_aniadir_detalle_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtonsDetalle();

            // Se habilitan todos los editText
            habilitarEditTextDetalle();

            // Se agrega un nuevo registro vacío al BindingSource
            detalleVentaBindingSource.AddNew();

            //Se pone el foco en el combobox categoría
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
                if (detalleVentaBindingSource.Current == null)
                {
                    MessageBox.Show("No hay ninguna línea de venta para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Se confirma la eliminación con el usuario
                DialogResult confirmacion = MessageBox.Show("¿Seguro que deseas eliminar la línea de venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    // Se elimina el registro del BindingSource
                    detalleVentaBindingSource.RemoveCurrent();

                    //Se comprueba si existe una línea de detalle en la compra para habilitar el botón de editar
                    existeDetalleVenta();

                    // Se recalcula el precio después de eliminar
                    calcularTotalSinImpuestos();
                    calcularTotal();

                    // Se muestra un mensaje de confirmación en el label
                    labelEstado.Text = "Línea de venta eliminada.";
                    temporizador();

                    actualizarEstadoBotonesNavegacionDetalle();

                    mensajeMostrado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurriió un error al intentar eliminar la línea de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Se pone el foco en el combobox categoría
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

                        foreach (DataRowView row in detalleVentaBindingSource)
                        {
                            // Si el producto ya está en el detalle se muestra un mensaje
                            if (row != detalleVentaBindingSource.Current && 
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
                    button_aceptar_detalle.Enabled = false;
                    button_cancelar_detalle.Enabled = false;

                    // Se habilita el botón terminar
                    habilitarButtonTerminar();

                    // Se termina la edición del BindingSource
                    detalleVentaBindingSource.EndEdit();

                    //detalleVentaDataGridView.Enabled = true;

                    // Se actualiza la línea del DataGrid
                    detalleVentaDataGridView.Refresh();

                    // Se deshabilitan los editText
                    deshabilitarEditTextDetalle();

                    //Se comprueba si existe una línea de detalle en la venta para habilitar el botón de editar
                    existeDetalleVenta();

                    //Se pone el foco en el botón ir a primero del detalle.
                    button_primero_detalle.Select();

                    // Se recalcula la venta
                    calcularTotalSinImpuestos();
                    calcularTotal();

                    labelEstado.Text = "Línea de venta añadida";
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
                    detalleVentaBindingSource.CancelEdit();

                    //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                    habilitarButtonsDetalle();

                    //Se deshabilitan los editText
                    deshabilitarEditTextDetalle();

                    // Se habilita el botón terminar
                    habilitarButtonTerminar();

                    //Se comprueba si existe una línea de detalle en la venta para habilitar el botón de editar
                    existeDetalleVenta();

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

        // Botón terminar
        private void button_terminar_Click(object sender, EventArgs e)
        {
            // Comprobar si el valor en el TextBox es "0.00"
            if (total_linea_detalle_ventaTextBox.Text == "0.00")
            {
                ventaBindingSource.EndEdit();
                total_sin_impuestos_ventaTextBox.Text = "0.00";
                total_ventaTextBox.Text = "0.00";
            }
            else
            {
                ventaBindingSource.EndEdit();
                calcularTotalSinImpuestos();
                calcularTotal();
            }
            
            habilitarButtons();
            existeVenta();
            deshabilitarButtonsDetalle();
            comboBoxBuscar.Enabled = true;
            textBoxBuscar.Enabled = true;
            deshabilitarButtonAceptarDetalle();
            deshabilitarButtonCancelarDetalle();
            deshabilitarButtonTerminar();

            actualizarVenta();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

            esMaestro = true;
    }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventaBindingSource.EndEdit();

            DataTable cambios = database1DataSet.Venta.GetChanges();

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
                        ventaBindingSource.EndEdit();
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

        //Método para comprobar si hay ventas
        private void existeVenta()
        {
            if (ventaBindingSource == null || ventaBindingSource.Count == 0)
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

        // Método para habilitar los editText
        private void habilitarEditText()
        {
            id_clienteComboBox.Enabled = true;
            dni_clienteTextBox.Enabled = true;
            notas_ventaTextBox.Enabled = true;
            fecha_ventaDateTimePicker.Enabled = true;
            comboBoxMetodoPago.Enabled = true;
            descuento_ventaTextBox.Enabled = true;
            impuestos_ventaTextBox .Enabled = true;
            
        }

        // Método para dehabilitar los editText
        private void deshabilitarEditText()
        {
            id_clienteComboBox.Enabled = false;
            dni_clienteTextBox.Enabled = false;
            notas_ventaTextBox.Enabled = false;
            fecha_ventaDateTimePicker.Enabled = false;
            comboBoxMetodoPago.Enabled = false;
            descuento_ventaTextBox.Enabled = false;
            impuestos_ventaTextBox.Enabled = false;
            
        }

        // Método para limpiar los campos del formulario
        public void limpiarFormulario()
        {
            id_clienteComboBox.SelectedItem = null;
            nombre_clienteTextBox.Clear();
            apellido_clienteTextBox.Clear();
            dni_clienteTextBox.Clear();
            notas_ventaTextBox.Clear();
            fecha_ventaDateTimePicker.Value = DateTime.Now;
            descuento_ventaTextBox.Clear();
            impuestos_ventaTextBox.Clear();
            total_sin_impuestos_ventaTextBox.Clear();
            total_ventaTextBox.Clear();
        }
        

        // Método para actualizar el conteo de ventas
        private void actualizarVenta()
        {
            labelVenta.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int ventaActual = ventaBindingSource.Position + 1;
            int totalVentas = ventaBindingSource.Count;
            labelVenta.Text = $"Venta {ventaActual} de {totalVentas}";
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (ventaBindingSource.Position > 0)
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
            if (ventaBindingSource.Position < ventaBindingSource.Count - 1)
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
            if (detalleVentaBindingSource.Position > 0)
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
            if (detalleVentaBindingSource.Position < detalleVentaBindingSource.Count - 1)
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

        // Método para buscar una venta
        private bool buscarVenta(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource de la venta
            foreach (DataRowView row in ventaBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if (criterioBusqueda == "Nº venta" && row["Id_venta"].ToString() == valorBusqueda)
                {
                    //Se mueve el BindingSource a la posición encontrada
                    ventaBindingSource.Position = ventaBindingSource.List.IndexOf(row);
                    return true;
                }
            }
            return false;
        }

        // Método para validar el formulario
        private bool validarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Se valida el combobox cliente
            if (id_clienteComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(id_clienteComboBox, "Se debe seleccionar un cliente");
                valido = false;
            }

            // Se valida el dni
            if (!dniValido(dni_clienteTextBox.Text))
            {
                errorProvider1.SetError(dni_clienteTextBox, "Se debe introducir un DNI con formato 00000000X");
                valido = false;
            }

            // Se valida la fecha
            if (fecha_ventaDateTimePicker.Value == null)
            {
                errorProvider1.SetError(fecha_ventaDateTimePicker, "Se debe seleccionar una fecha de venta ");
                valido = false;
            }

            // Se valida el método de pago
            if (comboBoxMetodoPago.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxMetodoPago, "Se debe seleccionar un método de pago");
                valido = false;
            }

            // Se valida el impuesto de venta
            if (string.IsNullOrWhiteSpace(impuestos_ventaTextBox.Text))
            {
                errorProvider1.SetError(impuestos_ventaTextBox, "Se debe introducir el impuesto de venta aplicado");
                valido = false;
            }
            return valido;
        }

        // Método para verificar el formato del DNI
        private bool dniValido(string dni)
        {
            //Se verifica que el DNI tenga 9 caracteres
            if (dni.Length != 9) return false;

            // Se verifica que los 8 primeros caracteres son números
            string numeros = dni.Substring(0, 8);
            if (!numeros.All(char.IsDigit)) return false;

            // Se verifica que el último carácter es una letra
            char letraDni = dni[8];
            if (!char.IsLetter(letraDni)) return false;

            // Si todas las verificaciones on correctas, el DNI cumple el formato establecido
            return true;
        }

        private void detalleVentaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void detalleVentaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void detalleVentaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void categoria_productoLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoria_productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoria_productoComboBox.SelectedValue != null)
            {
                // Se obtiene el nombre de la categoría seleccionada
                string categoriaSeleccionada = categoria_productoComboBox.SelectedValue.ToString();


                // Se filtran los productos según la categoría seleccionada
                //productoBindingSource = (BindingSource)id_productoComboBox.DataSource;

                //if (productoBindingSource != null)
                //{
                    productoBindingSource.Filter = $"Categoria_producto = '{categoriaSeleccionada}'";
                //}
                //var productosFiltrados = from producto in database1DataSet.Producto
                //                         where producto.Categoria_producto == categoriaSeleccionada
                //                         select producto;

                //id_productoComboBox.DataSource = productosFiltrados.ToList();
                
            }
        }

        private void cantidad_productoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cantidad_productoTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }

        

        private void labelVenta_Click(object sender, EventArgs e)
        {
            
        }

        

        private void total_linea_detalle_ventaTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }

        // Método para habilitar los Buttons del detalle
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

        //Método para deshabilitar los Buttons del detalle
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

        //Método para comprobar si hay líneas de detalle en la venta
        private void existeDetalleVenta()
        {
            if (detalleVentaBindingSource == null || detalleVentaBindingSource.Count == 0)
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


        // Método para deshabilitar los editText y el comboBox
        private void deshabilitarEditTextDetalle()
        {
            id_productoComboBox.Enabled = false;
            categoria_productoComboBox.Enabled = false;
            cantidad_productoTextBox.Enabled = false;
            marca_productoTextBox.Enabled = false;
            precio_venta_productoTextBox.Enabled = false;
            
        }

        // Método para habilitar los editText y comboBox del detalle
        private void habilitarEditTextDetalle()
        {
            id_productoComboBox.Enabled = true;
            categoria_productoComboBox.Enabled = true;
            cantidad_productoTextBox.Enabled = true;
            marca_productoTextBox.Enabled = true;
            precio_venta_productoTextBox.Enabled = true;
            
        }


        // Método para limpiar el formulario
        public void limpiarFormularioDetalle()
        {
            id_productoComboBox.SelectedItem = null;
            categoria_productoComboBox.SelectedItem = null;
            cantidad_productoTextBox.Clear();
            marca_productoTextBox.Clear();
            precio_venta_productoTextBox.Clear();
            total_linea_detalle_ventaTextBox.Clear();

        }

        // Método para calcular el total de la línea
        private void calcularTotalLinea()
        {
            if (decimal.TryParse(cantidad_productoTextBox.Text, out decimal cantidad) &&
                    decimal.TryParse(precio_venta_productoTextBox.Text, out decimal precio))
            {
                decimal totalLinea = cantidad * precio;
                total_linea_detalle_ventaTextBox.Text = totalLinea.ToString("0.00");
            }
            else
            {
                total_linea_detalle_ventaTextBox.Text = "0.00";
            }
        }

        // Método para validar el Detalle de la venta
        private bool validarDetalle()
        {
            bool valido = true;
            if (id_productoComboBox.SelectedIndex == null)
            {
                errorProvider1.SetError(id_productoComboBox, "Se debe seleccionar un prodcuto");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(id_productoComboBox, "");
            }
            if (categoria_productoComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(categoria_productoComboBox, "Se debe seleccionar la categoría del producto");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(categoria_productoComboBox, "");
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
            if (string.IsNullOrWhiteSpace(precio_venta_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_venta_productoTextBox, "Se debe introducir el precio de venta del producto");
                valido = false;
            }
            return valido;
        }

        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clienteLabel1_Click(object sender, EventArgs e)
        {

        }

        private void total_sin_impuestos_ventaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para calcular el total de la venta sin impuestos y sin descuento
        private void calcularTotalVentaSinImpuestosSinDescuento()
        {
            decimal totalVenta = 0;
            foreach (DataRow row in database1DataSet.DetalleVenta.Rows)
            {
                if (row.RowState != DataRowState.Deleted && decimal.TryParse(row["Total_sin_impuestos_venta"].ToString(), out decimal totalLinea))
                {
                    totalVenta += totalLinea;
                }
            }
            total_sin_impuestos_ventaTextBox.Text = totalVenta.ToString("0.00");

        }

        private void dni_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_clienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se verifica que hay un cliente seleccionado en el combobox
            if (id_clienteComboBox.SelectedValue != null)
            {
                var clienteRow = database1DataSet.Cliente.FindById_cliente((int)id_clienteComboBox.SelectedValue);
                dni_clienteTextBox.Text = clienteRow.Dni_cliente.ToString();
                nombre_clienteTextBox.Text = clienteRow.Nombre_cliente.ToString();
                apellido_clienteTextBox.Text = clienteRow.Apellidos_cliente.ToString();
                
            }
            else
            {
                dni_clienteTextBox.Clear();
            }
        }

        // Método para calcular el total de la venta con sin impuestos y sin descuento
        private void calcularTotalSinImpuestos()
        {
            // Comprobar si el valor en el TextBox es "0.00"
            if (total_linea_detalle_ventaTextBox.Text == "0.00")
            {
                total_sin_impuestos_ventaTextBox.Text = "0.00";
            }
            else
            {
                decimal totalSinImpuestos = 0;
                try
                {
                    int numero_venta = 0;
                    // Se suma el valor de total_linea al total sin impuestos
                    foreach (var detalle in database1DataSet.DetalleVenta)
                    {
                        if (detalle.RowState != DataRowState.Deleted)
                        {
                            if (detalle.Id_venta == numero_venta)
                            {
                                totalSinImpuestos += detalle.Total_linea_detalle_venta;
                            }
                            else
                            {
                                totalSinImpuestos = 0;
                                numero_venta = detalle.Id_venta;
                                totalSinImpuestos += detalle.Total_linea_detalle_venta;
                            }
                        }
                    }
                }
                catch
                {
                    // Si ocurre un error
                    totalSinImpuestos = 0;
                }
                // Muestra el total sin impuestos en el textBox
                total_sin_impuestos_ventaTextBox.Text = totalSinImpuestos.ToString("F2");
            }
                
        }

        // Método para calcular el total de la venta con con impuestos y con descuento
        private void calcularTotal()
        {
            // Se obtiene el subtotal sin impuestos
            decimal totalSinImpuesos = 0;
            if (!decimal.TryParse(total_sin_impuestos_ventaTextBox.Text, out totalSinImpuesos) || totalSinImpuesos < 0)
            {
                totalSinImpuesos = 0;
            }
            // Se obtiene el porcentaje de impuestos
            decimal impuestos = 21; // Valor predeterminado
            if (!decimal.TryParse(impuestos_ventaTextBox.Text, out impuestos) || impuestos < 0)
            {
                impuestos = 21;
            }

            // Se calcula el total con impuestos
            decimal totalConImpuestos = totalSinImpuesos + (totalSinImpuesos * impuestos / 100);

            // Se obtiene el descuento (si lo hay)
            decimal descuento = 0;
            if (!decimal.TryParse(descuento_ventaTextBox.Text, out descuento) || descuento < 0)
            {
                descuento = 0;
            }

            // Se aplica el descuento al total con impuestos
            decimal totalFinal = totalConImpuestos - (totalConImpuestos * descuento / 100);


            // Se asegura que el total no sea negativo
            if (totalFinal < 0)
            {
                totalFinal = 0;
            }

            // Se acutaliza el valor del textBox
            total_ventaTextBox.Text = totalFinal.ToString("F2");
            
        }

        private void impuestos_ventaTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalSinImpuestos();
            calcularTotal();
        }

        private void descuento_ventaTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalSinImpuestos();
            calcularTotal();
        }

        

        private void id_productoLabel_Click(object sender, EventArgs e)
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
                precio_venta_productoTextBox.Text = productoSeleccionado.Precio_venta_producto.ToString("F2");
                nombre_productoTextBox.Text = productoSeleccionado.Nombre_producto;
            }
            
        }

        private void precio_venta_productoTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularTotalLinea();
        }



        // Validating cliente
        private void id_clienteComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_clienteComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(id_clienteComboBox, "Se debe seleccionar un cliente");
            }
            else
            {
                errorProvider1.SetError(id_clienteComboBox, "");
            }
        }

        // Validating dni
        private void dni_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!dniValido(dni_clienteTextBox.Text))
            {
                errorProvider1.SetError(dni_clienteTextBox, "Se debe introducir un DNI con formato 00000000X");
            }
            else
            {
                errorProvider1.SetError(dni_clienteTextBox, "");
            }
        }

        // Validating fecha de venta
        private void fecha_ventaDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (fecha_ventaDateTimePicker.Value == null)
            {
                errorProvider1.SetError(fecha_ventaDateTimePicker, "Se debe seleccionar una fecha de venta ");
            }
            else
            {
                errorProvider1.SetError(fecha_ventaDateTimePicker, "");
            }
        }

        // Validating método de pago
        private void comboBoxMetodoPago_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxMetodoPago.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxMetodoPago, "Se debe seleccionar un método de pago");
            }
            else
            {
                errorProvider1.SetError(comboBoxMetodoPago, "");
            }
        }

        // Validating impuesto venta
        private void impuestos_ventaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(impuestos_ventaTextBox.Text))
            {
                errorProvider1.SetError(impuestos_ventaTextBox, "Se debe introducir el impuesto de venta aplicado");
            }
            else
            {
                errorProvider1.SetError(impuestos_ventaTextBox, "");
            }
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
            if (string.IsNullOrWhiteSpace(cantidad_productoTextBox.Text))
            {
                errorProvider1.SetError(cantidad_productoTextBox, "Se debe introducir la cantidad del producto");
            }
            else
            {
                errorProvider1.SetError(cantidad_productoTextBox, "");
            }
        }

        // Validating marca
        private void marca_productoTextBox_Validating(object sender, CancelEventArgs e)
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

        // Validating precio venta
        private void precio_venta_productoTextBox_Validating(object sender, CancelEventArgs e)
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

        // Validating total linea de venta
        private void total_linea_detalle_ventaTextBox_Validated(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(precio_venta_productoTextBox.Text))
            {
                errorProvider1.SetError(precio_venta_productoTextBox, "Se debe introducir el precio de venta del producto");
            }
            else
            {
                errorProvider1.SetError(precio_venta_productoTextBox, "");
            }
        }

        private void comboBoxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fecha_ventaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metodo_pago_ventaLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormVenta_KeyDown(object sender, KeyEventArgs e)
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

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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            // Se configura la conexión del tableadapter
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";
            this.categoriaTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos de la tabla
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);

            //TextBox deshabilitados al iniciar la aplicación
            deshabilitarEditText();

            // Botón aceptar, cancelar y guardar deshabilitados al iniciar la aplicación
            deshabilitarButtonAceptar();
            deshabilitarButtonCancelar();
            deshabilitarButtonGuardar();

            // Se vacía el labelEstado
            labelEstado.Text = "";

            // Se actualiza el label del contador de clientes
            actualizarCategoriaIndice();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.MoveFirst();
            actualizarCategoriaIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.MovePrevious();
            actualizarCategoriaIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.MoveNext();
            actualizarCategoriaIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.MoveLast();
            actualizarCategoriaIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón añadir
        private void button_aniadir_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo aceptar y cancelar.
            deshabilitarButtons();
            habilitarButtonAceptar();
            habilitarButtonCancelar();
            deshabilitarButtonGuardar();

            //Se deshabilita el combobox y el textoBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            //Se habilitan todos los EditText y se pone el foco en el nombre.
            habilitarEditText();
            nombre_categoriaTextBox.Select();

            // Se agrega un nuevo registro vacío al BindingSource
            categoriaBindingSource.AddNew();

            // Se limpian los campos del formulario para poder introducir nuevos datos
            limpiarFormulario();
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene categorías para eliminar
            if (categoriaBindingSource.Current != null)
            {
                // Se solicita confirmación antes de eliminar la categoría
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        categoriaBindingSource.RemoveCurrent(); // Se elimina la categoria actual
                        categoriaBindingSource.EndEdit(); // Se confirman los cambios
                        habilitarButtonGuardar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar la categoría");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna categoría para eliminar");
            }
        }

        // Botón editar
        private void button_editar_Click(object sender, EventArgs e)
        {
            // Se deshabilitan todos los botones salvo el de aceptar y cancenlar.
            deshabilitarButtons();
            habilitarButtonAceptar();
            habilitarButtonCancelar();
            deshabilitarButtonGuardar();

            // Se deshabilita el combobox y el textBoxBuscar
            comboBoxBuscar.Enabled = false;
            textBoxBuscar.Enabled = false;

            //Se habilitan todos los EditText y se pone el foco en el nombre.
            habilitarEditText();
            nombre_categoriaTextBox.Select();
        }

        // Botón guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edición de BindingSource y se guarda en la base de datos
                categoriaBindingSource.EndEdit();
                categoriaTableAdapter.Update(database1DataSet.Categoria);
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
            InformeCategorias informe = new InformeCategorias();
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
            //Criterio de búsqueda seleccionado en el comboBox (Código o Nombre)
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
            bool encontrado = buscarCategoria(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ninguna categoría con esos datos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelEstado.Text = "Categoría encontrada con éxito";
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
                    categoriaBindingSource.EndEdit();
                    habilitarButtons();
                    habilitarButtonGuardar();
                    deshabilitarButtonAceptar();
                    deshabilitarButtonCancelar();
                    comboBoxBuscar.Enabled = true;
                    textBoxBuscar.Enabled = true;
                    deshabilitarEditText();

                    // Se muestra un mensaje de éxito de la operación
                    labelEstado.Text = "Categoría actualizada correctamente.";
                    temporizador();

                    // Se actualiza el contador de clientes
                    actualizarCategoriaIndice();

                    //Se pone el foco en el botón ir a primero.

                    button_primero.Select();

                    //Se actualizan los botones de navegación
                    actualizarEstadoBotonesNavegacion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al validar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"Ha ocurrido un error al validar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                categoriaBindingSource.CancelEdit();

                //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                habilitarButtons();
                deshabilitarButtonAceptar();
                deshabilitarButtonCancelar();
                habilitarButtonGuardar();

                // Se habilita el combobox y el textBoxBuscar
                comboBoxBuscar.Enabled = true;
                textBoxBuscar.Enabled = true;

                //Se deshabilitan los editText
                deshabilitarEditText();

                //Se actualizan los botones de navegación
                actualizarEstadoBotonesNavegacion();
            }
        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        // Método para actualizar el conteo de clientes
        private void actualizarCategoriaIndice()
        {
            labelCategoria.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int categoriaActual = categoriaBindingSource.Position + 1;
            int totalCategorias = categoriaBindingSource.Count;
            labelCategoria.Text = $"Categoría {categoriaActual} de {totalCategorias}";
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

        //Método para habilitar el botón aceptar
        private void habilitarButtonAceptar()
        {
            button_aceptar.Enabled = true;
            button_aceptar.BackgroundImage = Properties.Resources.icon_accept;
        }

        //Método para deshabilitar el botón aceptar
        private void deshabilitarButtonAceptar()
        {
            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
        }

        //Método para habilitar el botón cancelar
        private void habilitarButtonCancelar()
        {
            button_cancelar.Enabled = true;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel;
        }

        //Método para deshabilitar el botón cancelar
        private void deshabilitarButtonCancelar()
        {
            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
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
            nombre_categoriaTextBox.Enabled = true;
            descripcion_categoriaTextBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            nombre_categoriaTextBox.Enabled = false;
            descripcion_categoriaTextBox.Enabled = false;
        }

        // Método para vaciar todos los editText
        private void limpiarFormulario()
        {
            nombre_categoriaTextBox.Clear();
            descripcion_categoriaTextBox.Clear();
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (categoriaBindingSource.Position > 0)
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
            if (categoriaBindingSource.Position < categoriaBindingSource.Count - 1)
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

        // Método para buscar una categoria
        private bool buscarCategoria(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in categoriaBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if ((criterioBusqueda == "Código" && row["Id_categoria"].ToString() == valorBusqueda)
                    || (criterioBusqueda == "Nombre" && row["Nombre_categoria"].ToString() == valorBusqueda))
                {
                    //Se mueve el BindingSource a la posición encontrada
                    categoriaBindingSource.Position = categoriaBindingSource.List.IndexOf(row);
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
            if (String.IsNullOrWhiteSpace(nombre_categoriaTextBox.Text))
            {
                errorProvider1.SetError(nombre_categoriaTextBox, "Se debe introducir el nombre de la categoría");
                valido = false;
            }

            // Se valida la descripción
            if (string.IsNullOrWhiteSpace(descripcion_categoriaTextBox.Text))
            {
                errorProvider1.SetError(descripcion_categoriaTextBox, "Se debe introducir la descripción de la categoría");
                valido = false;
            }
            return valido;
        }



        private void nombre_categoriaTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida el nombre
            if (String.IsNullOrWhiteSpace(nombre_categoriaTextBox.Text))
            {
                errorProvider1.SetError(nombre_categoriaTextBox, "Se debe introducir el nombre de la categoría");
            }
            else
            {
                errorProvider1.SetError(nombre_categoriaTextBox, "");
            }
        }

        private void descripcion_categoriaTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Se valida la descripción
            if (string.IsNullOrWhiteSpace(descripcion_categoriaTextBox.Text))
            {
                errorProvider1.SetError(descripcion_categoriaTextBox, "Se debe introducir la descripción de la categoría");
            }
            else
            {
                errorProvider1.SetError(descripcion_categoriaTextBox, "");
            }
        }


        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            categoriaBindingSource.EndEdit();

            DataTable cambios = database1DataSet.Categoria.GetChanges();

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
                        categoriaBindingSource.EndEdit();
                        categoriaTableAdapter.Update(database1DataSet.Categoria);
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

        private void FormCategorias_KeyDown(object sender, KeyEventArgs e)
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
    }
}

using HuellaAnimalia.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellaAnimalia
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            // Se establece la conexión dinámica
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Se aplica la nueva conexión
            this.proveedorTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos
            this.proveedorTableAdapter.Fill(this.database1DataSet.Proveedor);

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

            // Se actualiza el label del contador de proveedores
            actualizarProveedoresIndice();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveFirst();
            actualizarProveedoresIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MovePrevious();
            actualizarProveedoresIndice();
            actualizarEstadoBotonesNavegacion();
        }

        //Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveNext();
            actualizarProveedoresIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveLast();
            actualizarProveedoresIndice();
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
            razon_socialTextBox.Select();


            // Se agrega un nuevo registro vacío al BindingSource
            proveedorBindingSource.AddNew();

            // Se limpian los campos del formulario para poder introducir nuevos datos
            limpiarFormulario();

            // Se establece valor por defecto en el país
            pais_proveedorTextBox.Text = "España";

            //Se carga el textro preestablecido en el email
            email_proveedorTextBox.Text = "usuario@dominio.ext";
            email_proveedorTextBox.ForeColor = Color.Gray;
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene proveedores para eliminar
            if (proveedorBindingSource.Current != null)
            {
                // Se solicita confirmación antes de eliminar el cliente
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        proveedorBindingSource.RemoveCurrent(); // Se elimina el cliente actual
                        proveedorBindingSource.EndEdit(); // Se confirman los cambios
                        habilitarButtonGuardar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar el proveedor");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún proveedor para eliminar");
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
            razon_socialTextBox.Select();
        }

        // Botón guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edición de BindingSource y se guarda en la base de datos
                proveedorBindingSource.EndEdit();
                proveedorTableAdapter.Update(database1DataSet.Proveedor);
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
            InformeProveedores informe = new InformeProveedores();
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
            bool encontrado = buscarProveedor(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ningún proveedor con esos datos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelEstado.Text = "Proveedor encontrado con éxito";
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
                    proveedorBindingSource.EndEdit();
                    habilitarButtons();
                    habilitarButtonGuardar();
                    button_aceptar.Enabled = false;
                    button_cancelar.Enabled = false;
                    comboBoxBuscar.Enabled = true;
                    textBoxBuscar.Enabled = true;
                    deshabilitarEditText();

                    // Se muestra un mensaje de éxito de la operación
                    labelEstado.Text = "Proveedor creado o editado correctamente.";
                    temporizador();

                    // Se actualiza el contador de clientes
                    actualizarProveedoresIndice();

                    //Se pone el foco en el botón ir a último.
                    button_primero.Select();

                    //Se actualizan los botones de navegación
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

        // Botón Cancelar
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la operación?", "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Se limpian los errorProvider que haya
                errorProvider1.Clear();

                // Se cancela la edición
                proveedorBindingSource.CancelEdit();

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

                //Se actualizan los botones de navegación
                actualizarEstadoBotonesNavegacion();
            }
        }

        // Cerrar formulario
        private void FormProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable cambios = database1DataSet.Proveedor.GetChanges();

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
                        proveedorBindingSource.EndEdit();
                        proveedorTableAdapter.Update(database1DataSet.Proveedor);
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

        // Método para cargar imagen del proveedor
        private void imagen_proveedorPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { imagen_proveedorPictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { imagen_proveedorPictureBox.Image = null; }
        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        // Método para actualizar el conteo de clientes
        private void actualizarProveedoresIndice()
        {
            labelProveedor.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int proveedorActual = proveedorBindingSource.Position + 1;
            int totalProveedor = proveedorBindingSource.Count;
            labelProveedor.Text = $"Proveedor {proveedorActual} de {totalProveedor}";
        }

        // Método para habilitar los Buttons salvo guardar aceptar y cancelar
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

            button_imprimir.Enabled = true;
            button_imprimir.BackgroundImage = Properties.Resources.icon_print;

            button_buscar.Enabled = true;
            button_buscar.BackgroundImage = Properties.Resources.icon_search;

            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;

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

            button_imprimir.Enabled = false;
            button_imprimir.BackgroundImage = Properties.Resources.icon_print_grey;

            button_buscar.Enabled = false;
            button_buscar.BackgroundImage = Properties.Resources.icon_search_grey;

            button_aceptar.Enabled = true;
            button_aceptar.BackgroundImage = Properties.Resources.icon_accept;

            button_cancelar.Enabled = true;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel;
        }

        // Método para habilitar los editText
        private void habilitarEditText()
        {
            razon_socialTextBox.Enabled = true;
            cif_proveedorTextBox.Enabled = true;
            email_proveedorTextBox.Enabled = true;
            direccion_proveedorTextBox.Enabled = true;
            poblacion_proveedorTextBox.Enabled = true;
            provincia_proveedorTextBox.Enabled = true;
            codigo_postal_proveedorTextBox.Enabled = true;
            pais_proveedorTextBox.Enabled = true;
            imagen_proveedorPictureBox.Enabled = true;
            comentarios_proveedorTextBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            razon_socialTextBox.Enabled = false;
            cif_proveedorTextBox.Enabled = false;
            email_proveedorTextBox.Enabled = false;
            direccion_proveedorTextBox.Enabled = false;
            poblacion_proveedorTextBox.Enabled = false;
            provincia_proveedorTextBox.Enabled = false;
            codigo_postal_proveedorTextBox.Enabled = false;
            pais_proveedorTextBox.Enabled = false;
            imagen_proveedorPictureBox.Enabled = false;
            comentarios_proveedorTextBox.Enabled = false;
        }

        // Método para vaciar todos los editText
        private void limpiarFormulario()
        {
            razon_socialTextBox.Clear();
            cif_proveedorTextBox.Clear();
            email_proveedorTextBox.Clear();
            direccion_proveedorTextBox.Clear();
            poblacion_proveedorTextBox.Clear();
            provincia_proveedorTextBox.Clear();
            codigo_postal_proveedorTextBox.Clear();
            pais_proveedorTextBox.Clear();
            imagen_proveedorPictureBox.Image = null;
            comentarios_proveedorTextBox.Clear();
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (proveedorBindingSource.Position > 0)
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
            if (proveedorBindingSource.Position < proveedorBindingSource.Count - 1)
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

        // Método para buscar un proveedor
        private bool buscarProveedor(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in proveedorBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if ((criterioBusqueda == "Razón social" && row["Razon_social"].ToString() == valorBusqueda)
                    || (criterioBusqueda == "CIF" && row["Cif_proveedor"].ToString() == valorBusqueda))
                {
                    //Se mueve el BindingSource a la posición encontrada
                    proveedorBindingSource.Position = proveedorBindingSource.List.IndexOf(row);
                    return true;
                }
            }
            return false;
        }

        // Método para validar el formulario
        private bool validarFormulario()
        {
            bool valido = true;

            // Se valida la razón social
            if (String.IsNullOrWhiteSpace(razon_socialTextBox.Text))
            {
                errorProvider1.SetError(razon_socialTextBox, "Se debe introducir la razón social del proveedor");
                valido = false;
            }

            // Se valida el CIF
            if (!cifValido(cif_proveedorTextBox.Text))
            {
                errorProvider1.SetError(cif_proveedorTextBox, "Se debe introducir el CIF del proveedor (Formato: X00000000)");
                valido = false;
            }

            // Se valida el email
            if (string.IsNullOrWhiteSpace(email_proveedorTextBox.Text) || !emailValido(email_proveedorTextBox.Text))
            {
                errorProvider1.SetError(email_proveedorTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                valido = false;
            }

            // Se valida la dirección
            if (string.IsNullOrWhiteSpace(direccion_proveedorTextBox.Text))
            {
                errorProvider1.SetError(direccion_proveedorTextBox, "Se debe introducir la dirección del proveedor");
                valido = false;
            }

            // Se valida la población
            if (string.IsNullOrWhiteSpace(poblacion_proveedorTextBox.Text))
            {
                errorProvider1.SetError(poblacion_proveedorTextBox, "Se debe introducir la población del proveedor");
                valido = false;
            }

            // Se valida la provincia
            if (string.IsNullOrWhiteSpace(provincia_proveedorTextBox.Text))
            {
                errorProvider1.SetError(provincia_proveedorTextBox, "Se debe introducir la provincia del proveedor");
                valido = false;
            }

            // Se valida el código postal
            if (string.IsNullOrWhiteSpace(codigo_postal_proveedorTextBox.Text) || !codigoPostalValido(codigo_postal_proveedorTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_proveedorTextBox, "Se debe introducir el código postal del proveedor (5 dígitos)");
                valido = false;
            }

            // Se valida el país
            if (string.IsNullOrWhiteSpace(pais_proveedorTextBox.Text))
            {
                errorProvider1.SetError(pais_proveedorTextBox, "Se debe introducir el país del proveedor");
                valido = false;
            }
            return valido;

        }

        // Método para verificar el formato del CIF
        private bool cifValido(string cif)
        {
            //Se verifica que el CIF tenga 9 caracteres
            if (cif.Length != 9) return false;

            // Se verifica que el primer carácter es una letra válida
            char primerCaracter = cif[0];
            if (!"ABCDEFGHJKLMNPQRSUVW".Contains(primerCaracter)) return false;

            // Se verifica que los siguietnes 8 caracteres son números
            string numeros = cif.Substring(1, 8);
            if (!numeros.All(char.IsDigit)) return false;

            // Se verifica que el último carácter es un número o una letra
            char ultimoCaracter = cif[8];
            if (!char.IsDigit(ultimoCaracter) && !char.IsLetter(ultimoCaracter)) return false;

            // Si todas las verificaciones on correctas, el CIF cumple el formato establecido
            return true;
        }

        //Método para comprobar validar un correo electrónico
        private bool emailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(email_proveedorTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                return false;
            }
            else
            {
                try
                {
                    var mailAddress = new MailAddress(email);
                    errorProvider1.SetError(email_proveedorTextBox, "");
                    return true;
                }
                catch (FormatException ex)
                {
                    errorProvider1.SetError(email_proveedorTextBox, "El formato debe ser: usuario@dominio.ext");
                    return false;
                }
            }
        }

        //Método para comprobar que el código postal son cinco dígitos
        private bool codigoPostalValido(String codigoPostal)
        {
            return codigoPostal.Length == 5 && codigoPostal.All(char.IsDigit);
        }


        private void razon_socialTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(razon_socialTextBox.Text))
            {
                errorProvider1.SetError(razon_socialTextBox, "Se debe introducir la razón social del proveedor");
            }
            else
            {
                errorProvider1.SetError(razon_socialTextBox, "");
            }
        }

        private void cif_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!cifValido(cif_proveedorTextBox.Text))
            {
                errorProvider1.SetError(cif_proveedorTextBox, "Se debe introducir el CIF del proveedor (Formato:X00000000)");
            }
            else
            {
                errorProvider1.SetError(cif_proveedorTextBox, "");
            }
        }

        private void email_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_proveedorTextBox.Text) || !emailValido(email_proveedorTextBox.Text))
            {
                errorProvider1.SetError(email_proveedorTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
            }
            else
            {
                errorProvider1.SetError(email_proveedorTextBox, "");
            }
        }

        private void direccion_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccion_proveedorTextBox.Text))
            {
                errorProvider1.SetError(direccion_proveedorTextBox, "Se debe introducir la dirección del proveedor");
            }
            else
            {
                errorProvider1.SetError(direccion_proveedorTextBox, "");
            }

        }

        private void poblacion_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(poblacion_proveedorTextBox.Text))
            {
                errorProvider1.SetError(poblacion_proveedorTextBox, "Se debe introducir la población del proveedor");
            }
            else
            {
                errorProvider1.SetError(poblacion_proveedorTextBox, "");
            }
        }

        private void provincia_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(provincia_proveedorTextBox.Text))
            {
                errorProvider1.SetError(provincia_proveedorTextBox, "Se debe introducir la provincia del proveedor");
            }
            else
            {
                errorProvider1.SetError(provincia_proveedorTextBox, "");
            }
        }

        private void codigo_postal_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigo_postal_proveedorTextBox.Text) || !codigoPostalValido(codigo_postal_proveedorTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_proveedorTextBox, "Se debe introducir el código postal del proveedor (5 dígitos)");
            }
            else
            {
                errorProvider1.SetError(codigo_postal_proveedorTextBox, "");
            }
        }

        private void pais_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pais_proveedorTextBox.Text))
            {
                errorProvider1.SetError(pais_proveedorTextBox, "Se debe introducir el país del proveedor");
            }
            else
            {
                errorProvider1.SetError(pais_proveedorTextBox, "");
            }
        }

        private void razon_socialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Evento que borra el texto predeterminado del email
        private void email_proveedorTextBox_Enter(object sender, EventArgs e)
        {
            if (email_proveedorTextBox.Text == "usuario@dominio.ext")
            {
                email_proveedorTextBox.Text = string.Empty;
                email_proveedorTextBox.ForeColor = Color.Black;
            }
        }

        //Evento que reestablece el texto predeterminado del email
        private void email_proveedorTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_proveedorTextBox.Text))
            {
                email_proveedorTextBox.Text = "usuario@dominio.ext";
                email_proveedorTextBox.ForeColor = Color.Gray;
            }
        }

        private void FormProveedores_KeyDown(object sender, KeyEventArgs e)
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

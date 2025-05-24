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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HuellaAnimalia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Se configura la conexión del tableadapter
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";
            this.clienteTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos en la tabla cliente
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);

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
            actualizarClientesIndice();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();

        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveFirst();
            actualizarClientesIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
            actualizarClientesIndice();
            actualizarEstadoBotonesNavegacion();
        }

        //Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
            actualizarClientesIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button4_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
            actualizarClientesIndice();
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
            nombre_clienteTextBox.Select();

            // Se agrega un nuevo registro vacío al BindingSource
            clienteBindingSource.AddNew();

            // Se limpian los campos del formulario para poder introducir nuevos datos
            limpiarFormulario();

            // Se establece valor por defecto en el país
            pais_clienteTextBox.Text = "España";

            //Se carga el textro preestablecido en el email
            email_clienteTextBox.Text = "usuario@dominio.ext";
            email_clienteTextBox.ForeColor = Color.Gray;
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene clientes para eliminar
            if (clienteBindingSource.Current != null)
            {
                // Se solicita confirmación antes de eliminar el cliente
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        clienteBindingSource.RemoveCurrent(); // Se elimina el cliente actual
                        clienteBindingSource.EndEdit(); // Se confirman los cambios
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar el cliente");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún cliente para eliminar");
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
            nombre_clienteTextBox.Select();
           
        }

        // Guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edición de BindingSource y se guarda en la base de datos
                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(database1DataSet.Cliente);
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
            InformeClientes informe = new InformeClientes();
            informe.ShowDialog();

        }

        //Botón buscar
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
            bool encontrado = buscarCliente(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ningún cliente con esos datos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelEstado.Text = "Cliente encontrado con éxito";
                temporizador();
                return;
            }
        }

        // Botón Aceptar
        private void button_aceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validarFormulario())
            {
                try
                {
                    //Se termina la edición y se habilitan los botones salvo el de aceptar y cancelar
                    clienteBindingSource.EndEdit();
                    habilitarButtons();
                    habilitarButtonGuardar();
                    button_aceptar.Enabled = false;
                    button_cancelar.Enabled = false;
                    comboBoxBuscar.Enabled = true;
                    textBoxBuscar.Enabled = true;
                    deshabilitarEditText();

                    // Se muestra un mensaje de éxito de la operación
                    labelEstado.Text = "Cliente creado o editado correctamente.";
                    temporizador();

                    // Se actualiza el contador de clientes
                    actualizarClientesIndice();

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
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la operación?","Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Se limpian los errorProvider que haya
                errorProvider1.Clear();

                // Se cancela la edición
                clienteBindingSource.CancelEdit();

                //Se habilitan todos los botones y se deshabilita cancelar y aceptar
                habilitarButtons();

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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable cambios = database1DataSet.Cliente.GetChanges();
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
                        clienteBindingSource.EndEdit();
                        clienteTableAdapter.Update(database1DataSet.Cliente);
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

        private void imagen_clientePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { imagen_clientePictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { imagen_clientePictureBox.Image = null; }
        }

        // Método para actualizar el conteo de clientes
        private void actualizarClientesIndice()
        {
            labelCliente.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int clienteActual = clienteBindingSource.Position + 1;
            int totalClientes = clienteBindingSource.Count;
            labelCliente.Text = $"Cliente {clienteActual} de {totalClientes}";
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
            nombre_clienteTextBox.Enabled = true;
            apellidos_clienteTextBox.Enabled = true;
            telefono_clienteTextBox.Enabled = true;
            dni_clienteTextBox.Enabled = true;
            fechaNacDateTimePicker.Enabled= true;
            email_clienteTextBox.Enabled = true;
            direccion_clienteTextBox.Enabled = true;
            poblacion_clienteTextBox.Enabled = true;
            provincia_clienteTextBox.Enabled = true;
            codigo_postal_clienteTextBox.Enabled = true;
            pais_clienteTextBox.Enabled = true;
            imagen_clientePictureBox.Enabled = true;
            comentarios_clienteTextBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            nombre_clienteTextBox.Enabled = false;
            apellidos_clienteTextBox.Enabled = false;
            telefono_clienteTextBox.Enabled = false;
            dni_clienteTextBox.Enabled = false;
            fechaNacDateTimePicker.Enabled = false;
            email_clienteTextBox.Enabled = false;
            direccion_clienteTextBox.Enabled = false;
            poblacion_clienteTextBox.Enabled = false;
            provincia_clienteTextBox.Enabled = false;
            codigo_postal_clienteTextBox.Enabled = false;
            pais_clienteTextBox.Enabled = false;
            imagen_clientePictureBox.Enabled = false;
            comentarios_clienteTextBox.Enabled = false;
        }

        // Método para vaciar todos los editText
        private void limpiarFormulario()
        {
            nombre_clienteTextBox.Clear();
            apellidos_clienteTextBox.Clear();
            telefono_clienteTextBox.Clear();
            dni_clienteTextBox.Clear();
            fechaNacDateTimePicker.Value = DateTime.Now;
            email_clienteTextBox.Clear();
            direccion_clienteTextBox.Clear();
            poblacion_clienteTextBox.Clear();
            provincia_clienteTextBox.Clear();
            codigo_postal_clienteTextBox.Clear();
            pais_clienteTextBox.Clear();
            imagen_clientePictureBox.Image = null;
            comentarios_clienteTextBox.Clear();
        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (clienteBindingSource.Position > 0)
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
            if (clienteBindingSource.Position < clienteBindingSource.Count - 1)
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

        // Método para validar el formulario
        private bool validarFormulario()
        {
            bool valido = true;

            // Se valida el nombre
            if (String.IsNullOrWhiteSpace(nombre_clienteTextBox.Text))
            {
                errorProvider1.SetError (nombre_clienteTextBox, "Se debe introducir el nombre del usuario");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(nombre_clienteTextBox, "");
            }

            // Se valida el apellido
            if (string.IsNullOrWhiteSpace(apellidos_clienteTextBox.Text))
            {
                errorProvider1.SetError(apellidos_clienteTextBox, "Se deben introducir los apellidos del usuario");
                valido = false;
            }

            //Se valida el teléfono
            if (string.IsNullOrWhiteSpace(telefono_clienteTextBox.Text) || !telefonoValido(telefono_clienteTextBox.Text))
            {
                errorProvider1.SetError(telefono_clienteTextBox, "Se debe introducir el número de teléfono del ususario (9 dígitos)");
                valido = false;
            }

            //Se valida el dni
            if (!dniValido(dni_clienteTextBox.Text))
            {
                errorProvider1.SetError(dni_clienteTextBox, "Se debe introducir un con formato 00000000X");
                valido = false;
            }

            // Se valida la fecha de nacimiento
            if (!fechaValida(fechaNacDateTimePicker.Value))
            {
                errorProvider1.SetError(fechaNacDateTimePicker, "La fecha introducida debe ser anterior a la actual");
                valido = false;
            }

            // Se valida el email
            if (string.IsNullOrWhiteSpace(email_clienteTextBox.Text) || !emailValido(email_clienteTextBox.Text))
            {
                errorProvider1.SetError(email_clienteTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                valido = false;
            }

            // Se valida la dirección
            if (string.IsNullOrWhiteSpace(direccion_clienteTextBox.Text))
            {
                errorProvider1.SetError(direccion_clienteTextBox, "Se debe introducir la dirección del usuario");
                valido = false;
            }

            // Se valida la población
            if (string.IsNullOrWhiteSpace(poblacion_clienteTextBox.Text))
            {
                errorProvider1.SetError(poblacion_clienteTextBox, "Se debe introducir la población del usuario");
                valido = false;
            }

            // Se valida la provincia
            if (string.IsNullOrWhiteSpace(provincia_clienteTextBox.Text))
            {
                errorProvider1.SetError(provincia_clienteTextBox, "Se debe introducir la provincia del usuario");
                valido = false;
            }

            // Se valida el código postal
            if (string.IsNullOrWhiteSpace(codigo_postal_clienteTextBox.Text) || !codigoPostalValido(codigo_postal_clienteTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_clienteTextBox, "Se debe introducir el código postal del usuario (5 dígitos)");
                valido = false;
            }
            
            // Se valida el país
            if (string.IsNullOrWhiteSpace(pais_clienteTextBox.Text))
            {
                errorProvider1.SetError(pais_clienteTextBox, "Se debe introducir el país del usuario");
                valido = false;
            }
            return valido;

        }

        //Método para comprobar que el teléfono tiene 9 caracteres y todos son números
        private bool telefonoValido(string telefono)
        {
            return telefono.Length == 9 && telefono.All(char.IsDigit);
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

        //Método para comprobar validar un correo electrónico
        private bool emailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(email_clienteTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                return false;
            }
            else
            {
                try
                {
                    var mailAddress = new MailAddress(email);
                    errorProvider1.SetError(email_clienteTextBox, "");
                    return true;
                }
                catch (FormatException ex)
                {
                    errorProvider1.SetError(email_clienteTextBox, "El formato debe ser: usuario@dominio.ext");
                    return false;
                }
            }
        }

        //Método para comprobar que la fecha de nacimiento es anterior a la actual
        private bool fechaValida(DateTime fechaNacimiento)
        {
            return fechaNacimiento < DateTime.Now.Date;
        }

        //Método para comprobar que el código postal son cinco dígitos
        private bool codigoPostalValido(String codigoPostal)
        {
            return codigoPostal.Length == 5 && codigoPostal.All(char.IsDigit);
        }

        // Método para buscar un cliente
        private bool buscarCliente(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in clienteBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if ((criterioBusqueda == "DNI" && row["Dni_cliente"].ToString() == valorBusqueda)
                    || (criterioBusqueda == "Teléfono" && row["Telefono_cliente"].ToString() == valorBusqueda))
                {
                    //Se mueve el BindingSource a la posición encontrada
                    clienteBindingSource.Position = clienteBindingSource.List.IndexOf(row);
                    return true;
                }
            }
            return false;
        }

        



        private void labelCliente_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagen_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefono_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre_clienteTextBox.Text))
            {
                errorProvider1.SetError(nombre_clienteTextBox, "Se debe introducir el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(nombre_clienteTextBox, "");
            }
        }

        private void apellidos_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(apellidos_clienteTextBox.Text))
            {
                errorProvider1.SetError(apellidos_clienteTextBox, "Se deben introducir los apellidos del usuario");
            }
            else
            {
                errorProvider1.SetError(apellidos_clienteTextBox, "");
            }
        }


        private void telefono_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telefono_clienteTextBox.Text) || !telefonoValido(telefono_clienteTextBox.Text))
            {
                errorProvider1.SetError(telefono_clienteTextBox, "Se debe introducir el número de teléfono del ususario (9 dígitos)");
            }
            else
            {
                errorProvider1.SetError(telefono_clienteTextBox, "");
            }
        }

        private void dni_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!dniValido(dni_clienteTextBox.Text))
            {
                errorProvider1.SetError(dni_clienteTextBox, "Se debe introducir un con formato 00000000X");
            }
            else
            {
                errorProvider1.SetError(dni_clienteTextBox, "");
            }
        }

        private void fechaNacDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (!fechaValida(fechaNacDateTimePicker.Value))
            {
                errorProvider1.SetError(fechaNacDateTimePicker, "La fecha introducida debe ser anterior a la actual");
            }
            else
            {
                errorProvider1.SetError(fechaNacDateTimePicker, "");
            }
        }

        private void email_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_clienteTextBox.Text) || !emailValido(email_clienteTextBox.Text))
            {
                errorProvider1.SetError(email_clienteTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
            }
            else
            {
                errorProvider1.SetError(email_clienteTextBox, "");
            }
        }

        private void direccion_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccion_clienteTextBox.Text))
            {
                errorProvider1.SetError(direccion_clienteTextBox, "Se debe introducir la dirección del usuario");
            }
            else
            {
                errorProvider1.SetError(direccion_clienteTextBox, "");
            }

        }

        private void poblacion_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(poblacion_clienteTextBox.Text))
            {
                errorProvider1.SetError(poblacion_clienteTextBox, "Se debe introducir la población del usuario");
            }
            else
            {
                errorProvider1.SetError(poblacion_clienteTextBox, "");
            }
        }

        private void provincia_clienteTextBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(provincia_clienteTextBox.Text))
            {
                errorProvider1.SetError(provincia_clienteTextBox, "Se debe introducir la provincia del usuario");
            }
            else
            {
                errorProvider1.SetError(provincia_clienteTextBox, "");
            }
        }

        private void codigo_postal_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigo_postal_clienteTextBox.Text) || !codigoPostalValido(codigo_postal_clienteTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_clienteTextBox, "Se debe introducir el código postal del usuario (5 dígitos)");
            }
            else
            {
                errorProvider1.SetError(codigo_postal_clienteTextBox, "");
            }
        }

        private void pais_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pais_clienteTextBox.Text))
            {
                errorProvider1.SetError(pais_clienteTextBox, "Se debe introducir el país del usuario");
            }
            else
            {
                errorProvider1.SetError(pais_clienteTextBox, "");
            }
        }

        //Evento que borra el textopredeterminado del email
        private void email_clienteTextBox_Enter(object sender, EventArgs e)
        {
            if (email_clienteTextBox.Text == "usuario@dominio.ext")
            {
                email_clienteTextBox.Text = string.Empty;
                email_clienteTextBox.ForeColor = Color.Black;
            }
        }

        //Evento que reestablece el textopredeterminado del email
        private void email_clienteTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_clienteTextBox.Text))
            {
                email_clienteTextBox.Text = "usuario@dominio.ext";
                email_clienteTextBox.ForeColor = Color.Gray;
            }
        }

        private void pais_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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

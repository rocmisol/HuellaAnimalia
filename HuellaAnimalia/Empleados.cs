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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Empleado' Puede moverla o quitarla según sea necesario.
            // CONFIGURA LA CONEXIÓN DINÁMICA A LA BASE DE DATOS
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";

            // Asigna la nueva cadena de conexión al TableAdapter
            this.empleadoTableAdapter.Connection.ConnectionString = connectionString;

            // CARGA LOS DATOS DESDE LA RUTA DINÁMICA
            this.empleadoTableAdapter.Fill(this.database1DataSet.Empleado);


            // TextBox deshabilitados al iniciar la aplicación
            deshabilitarEditText();

            // Botón aceptar, cancelar y guardar deshabilitados al iniciar la aplicación
            button_aceptar.Enabled = false;
            button_aceptar.BackgroundImage = Properties.Resources.icon_acept_grey;
            button_cancelar.Enabled = false;
            button_cancelar.BackgroundImage = Properties.Resources.icon_cancel_grey;
            deshabilitarButtonGuardar();

            // Se vacía el labelEstado
            labelEstado.Text = "";

            // Se actualiza el label del contador de empleados
            actualizarEmpleadosIndice();

            // Se cargan los roles en el combobox
            cargarDatosRol();

            //Se actualizan los botones de navegación
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a primero
        private void button_primero_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.MoveFirst();
            actualizarEmpleadosIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a anterior
        private void button_anterior_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.MovePrevious();
            actualizarEmpleadosIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a siguiente
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.MoveNext();
            actualizarEmpleadosIndice();
            actualizarEstadoBotonesNavegacion();
        }

        // Botón ir a último
        private void button_ultimo_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.MoveLast();
            actualizarEmpleadosIndice();
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
            nombre_empleadoTextBox.Select();

            // Se agrega un nuevo registro vacío al BindingSource
            empleadoBindingSource.AddNew();

            // Se limpian los campos del formulario para poder introducir nuevos datos
            limpiarFormulario();

            // Se establece valor por defecto en el país
            pais_empleadoTextBox.Text = "España";

            //Se carga el textro preestablecido en el email
            email_empleadoTextBox.Text = "usuario@dominio.ext";
            email_empleadoTextBox.ForeColor = Color.Gray;
        }

        // Botón eliminar
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba si el BindingSource tiene empleados para eliminar
            if (empleadoBindingSource.Current != null)
            {
                // Se solicita confirmación antes de eliminar el empleado
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        empleadoBindingSource.RemoveCurrent(); // Se elimina el empleado actual
                        empleadoBindingSource.EndEdit(); // Se confirman los cambios
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar el empleado");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún empleado para eliminar");
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
            nombre_empleadoTextBox.Select();
        }

        // Botón guardar
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se termina la edición de BindingSource y se guarda en la base de datos
                empleadoBindingSource.EndEdit();
                empleadoTableAdapter.Update(database1DataSet.Empleado);
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
            InformeEmpleados informe = new InformeEmpleados();
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
            //Criterio de búsqueda seleccionado en el comboBox (DNI o Apellidos)
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
            bool encontrado = buscarEmpleado(criterioBusqueda, valorBusqueda);
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado ningún empleado con esos datos", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelEstado.Text = "Empleado encontrado con éxito";
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
                    empleadoBindingSource.EndEdit();
                    habilitarButtons();
                    habilitarButtonGuardar();
                    button_aceptar.Enabled = false;
                    button_cancelar.Enabled = false;
                    comboBoxBuscar.Enabled = true;
                    textBoxBuscar.Enabled = true;
                    deshabilitarEditText();

                    // Se muestra un mensaje de éxito de la operación
                    labelEstado.Text = "Empleado creado o editado correctamente.";
                    temporizador();

                    // Se actualiza el contador de empleados
                    actualizarEmpleadosIndice();

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
                empleadoBindingSource.CancelEdit();

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

        // Método para actualizar el conteo de empleados
        public void actualizarEmpleadosIndice()
        {
            labelEmpleado.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            int empleadoActual = empleadoBindingSource.Position + 1;
            int totalEmpleados = empleadoBindingSource.Count;
            labelEmpleado.Text = $"Empleado {empleadoActual} de {totalEmpleados}";
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
            nombre_empleadoTextBox.Enabled = true;
            apellidos_empleadoTextBox.Enabled = true;
            telefono_empleadoTextBox.Enabled = true;
            dni_empleadoTextBox.Enabled = true;
            fecha_nac_empleadoDateTimePicker.Enabled = true;
            email_empleadoTextBox.Enabled = true;
            direccion_empleadoTextBox.Enabled = true;
            poblacion_empleadoTextBox.Enabled = true;
            provincia_empleadoTextBox.Enabled = true;
            codigo_postal_empleadoTextBox.Enabled = true;
            pais_empleadoTextBox.Enabled = true;
            usuario_empleadoTextBox.Enabled = true;
            contrasenia_empleadoTextBox.Enabled = true;
            rol_empleadoComboBox.Enabled = true;
        }

        // Método para deshabilitar los editText
        private void deshabilitarEditText()
        {
            nombre_empleadoTextBox.Enabled = false;
            apellidos_empleadoTextBox.Enabled = false;
            telefono_empleadoTextBox.Enabled = false;
            dni_empleadoTextBox.Enabled = false;
            fecha_nac_empleadoDateTimePicker.Enabled = false;
            email_empleadoTextBox.Enabled = false;
            direccion_empleadoTextBox.Enabled = false;
            poblacion_empleadoTextBox.Enabled = false;
            provincia_empleadoTextBox.Enabled = false;
            codigo_postal_empleadoTextBox.Enabled = false;
            pais_empleadoTextBox.Enabled = false;
            usuario_empleadoTextBox.Enabled = false;
            contrasenia_empleadoTextBox.Enabled = false;
            rol_empleadoComboBox.Enabled = false;
        }

        // Método para vaciar todos los editText
        private void limpiarFormulario()
        {
            nombre_empleadoTextBox.Clear();
            apellidos_empleadoTextBox.Clear();
            telefono_empleadoTextBox.Clear();
            dni_empleadoTextBox.Clear();
            fecha_nac_empleadoDateTimePicker.Value = DateTime.Now;
            email_empleadoTextBox.Clear();
            direccion_empleadoTextBox.Clear();
            poblacion_empleadoTextBox.Clear();
            provincia_empleadoTextBox.Clear();
            codigo_postal_empleadoTextBox.Clear();
            pais_empleadoTextBox.Clear();
            usuario_empleadoTextBox.Clear();
            contrasenia_empleadoTextBox.Clear();
            rol_empleadoComboBox.SelectedItem = null;

        }

        // Método para actualizar el estado de los botones de navegación
        private void actualizarEstadoBotonesNavegacion()
        {
            // Se deshabilita botón Primero y Anterior si es el primer registro
            if (empleadoBindingSource.Position > 0)
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
            if (empleadoBindingSource.Position < empleadoBindingSource.Count - 1)
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

        // Método para buscar un empleado
        private bool buscarEmpleado(string criterioBusqueda, string valorBusqueda)
        {
            //Se realiza la búsqueda en el BindingSource del cliente
            foreach (DataRowView row in empleadoBindingSource.List)
            {
                //Se compara según el criterio de búsqueda utilizado
                if ((criterioBusqueda == "DNI" && row["Dni_empleado"].ToString() == valorBusqueda)
                    || (criterioBusqueda == "Nº empleado" && row["Id_empleado"].ToString() == valorBusqueda))
                {
                    //Se mueve el BindingSource a la posición encontrada
                    empleadoBindingSource.Position = empleadoBindingSource.List.IndexOf(row);
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
            if (String.IsNullOrWhiteSpace(nombre_empleadoTextBox.Text))
            {
                errorProvider1.SetError(nombre_empleadoTextBox, "Se debe introducir el nombre del empleado");
                valido = false;
            }

            // Se valida el apellido
            if (string.IsNullOrWhiteSpace(apellidos_empleadoTextBox.Text))
            {
                errorProvider1.SetError(apellidos_empleadoTextBox, "Se deben introducir los apellidos del empleado");
                valido = false;
            }

            //Se valida el teléfono
            if (string.IsNullOrWhiteSpace(telefono_empleadoTextBox.Text) || !telefonoValido(telefono_empleadoTextBox.Text))
            {
                errorProvider1.SetError(telefono_empleadoTextBox, "Se debe introducir el número de teléfono del empleado (9 dígitos)");
                valido = false;
            }

            //Se valida el dni
            if (!dniValido(dni_empleadoTextBox.Text))
            {
                errorProvider1.SetError(dni_empleadoTextBox, "Se debe introducir un con formato 00000000X");
                valido = false;
            }

            // Se valida la fecha de nacimiento
            if (!fechaValida(fecha_nac_empleadoDateTimePicker.Value))
            {
                errorProvider1.SetError(fecha_nac_empleadoDateTimePicker, "La fecha introducida debe ser anterior a la actual");
                valido = false;
            }

            // Se valida el email
            if (string.IsNullOrWhiteSpace(email_empleadoTextBox.Text) || !emailValido(email_empleadoTextBox.Text))
            {
                errorProvider1.SetError(email_empleadoTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                valido = false;
            }

            // Se valida la dirección
            if (string.IsNullOrWhiteSpace(direccion_empleadoTextBox.Text))
            {
                errorProvider1.SetError(direccion_empleadoTextBox, "Se debe introducir la dirección del empleado");
                valido = false;
            }

            // Se valida la población
            if (string.IsNullOrWhiteSpace(poblacion_empleadoTextBox.Text))
            {
                errorProvider1.SetError(poblacion_empleadoTextBox, "Se debe introducir la población del empleado");
                valido = false;
            }

            // Se valida la provincia
            if (string.IsNullOrWhiteSpace(provincia_empleadoTextBox.Text))
            {
                errorProvider1.SetError(provincia_empleadoTextBox, "Se debe introducir la provincia del empleado");
                valido = false;
            }

            // Se valida el código postal
            if (string.IsNullOrWhiteSpace(codigo_postal_empleadoTextBox.Text) || !codigoPostalValido(codigo_postal_empleadoTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_empleadoTextBox, "Se debe introducir el código postal del empleado (5 dígitos)");
                valido = false;
            }

            // Se valida el país
            if (string.IsNullOrWhiteSpace(pais_empleadoTextBox.Text))
            {
                errorProvider1.SetError(pais_empleadoTextBox, "Se debe introducir el país del empleado");
                valido = false;
            }

            // Se valida el usuario
            if (string.IsNullOrWhiteSpace(usuario_empleadoTextBox.Text))
            {
                errorProvider1.SetError(usuario_empleadoTextBox, "Se debe introducir el suario del empleado");
                valido = false;
            }

            // Se valida la contrasenia
            if (string.IsNullOrWhiteSpace(contrasenia_empleadoTextBox.Text))
            {
                errorProvider1.SetError(contrasenia_empleadoTextBox, "Se debe introducir la contraseña del empleado");
                valido = false;
            }

            // Se valida el rol
            if (rol_empleadoComboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rol_empleadoComboBox.Text))
            {
                errorProvider1.SetError(rol_empleadoComboBox, "Se debe introducir el rol del empleado");
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
                errorProvider1.SetError(email_empleadoTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
                return false;
            }
            else
            {
                try
                {
                    var mailAddress = new MailAddress(email);
                    errorProvider1.SetError(email_empleadoTextBox, "");
                    return true;
                }
                catch (FormatException ex)
                {
                    errorProvider1.SetError(email_empleadoTextBox, "El formato debe ser: usuario@dominio.ext");
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


        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nombre_empleadoTextBox.Text))
            {
                errorProvider1.SetError(nombre_empleadoTextBox, "Se debe introducir el nombre del empleado");
            }
            else
            {
                errorProvider1.SetError(nombre_empleadoTextBox, "");
            }
        }

        private void apellidos_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(apellidos_empleadoTextBox.Text))
            {
                errorProvider1.SetError(apellidos_empleadoTextBox, "Se deben introducir los apellidos del empleado");
            }
            else
            {
                errorProvider1.SetError(apellidos_empleadoTextBox, "");
            }
        }

        private void telefono_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telefono_empleadoTextBox.Text) || !telefonoValido(telefono_empleadoTextBox.Text))
            {
                errorProvider1.SetError(telefono_empleadoTextBox, "Se debe introducir el número de teléfono del empleado (9 dígitos)");
            }
            else
            {
                errorProvider1.SetError(telefono_empleadoTextBox, "");
            }
        }

        private void dni_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!dniValido(dni_empleadoTextBox.Text))
            {
                errorProvider1.SetError(dni_empleadoTextBox, "Se debe introducir un con formato 00000000X");
            }
            else
            {
                errorProvider1.SetError(dni_empleadoTextBox, "");
            }
        }

        private void fecha_nac_empleadoDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            // Se valida la fecha de nacimiento
            if (!fechaValida(fecha_nac_empleadoDateTimePicker.Value))
            {
                errorProvider1.SetError(fecha_nac_empleadoDateTimePicker, "La fecha introducida debe ser anterior a la actual");
            }
            else
            {
                errorProvider1.SetError(fecha_nac_empleadoDateTimePicker, "");
            }
        }

        private void email_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_empleadoTextBox.Text) || !emailValido(email_empleadoTextBox.Text))
            {
                errorProvider1.SetError(email_empleadoTextBox, "Se debe introducir un email con un formato válido: usuario@dominio.ext");
            }
            else
            {
                errorProvider1.SetError(email_empleadoTextBox, "");
            }
        }

        private void direccion_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccion_empleadoTextBox.Text))
            {
                errorProvider1.SetError(direccion_empleadoTextBox, "Se debe introducir la dirección del empleado");
            }
            else
            {
                errorProvider1.SetError(direccion_empleadoTextBox, "");
            }
        }

        private void poblacion_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(poblacion_empleadoTextBox.Text))
            {
                errorProvider1.SetError(poblacion_empleadoTextBox, "Se debe introducir la población del empleado");
            }
            else
            {
                errorProvider1.SetError(poblacion_empleadoTextBox, "");
            }
        }

        private void provincia_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(provincia_empleadoTextBox.Text))
            {
                errorProvider1.SetError(provincia_empleadoTextBox, "Se debe introducir la provincia del empleado");
            }
            else
            {
                errorProvider1.SetError(provincia_empleadoTextBox, "");
            }
        }

        private void codigo_postal_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigo_postal_empleadoTextBox.Text) || !codigoPostalValido(codigo_postal_empleadoTextBox.Text))
            {
                errorProvider1.SetError(codigo_postal_empleadoTextBox, "Se debe introducir el código postal del empleado (5 dígitos)");
            }
            else
            {
                errorProvider1.SetError(codigo_postal_empleadoTextBox, "");
            }
        }

        private void pais_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pais_empleadoTextBox.Text))
            {
                errorProvider1.SetError(pais_empleadoTextBox, "Se debe introducir el país del empleado");
            }
            else
            {
                errorProvider1.SetError(pais_empleadoTextBox, "");
            }
        }

        private void usuario_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario_empleadoTextBox.Text))
            {
                errorProvider1.SetError(usuario_empleadoTextBox, "Se debe introducir el suario del empleado");
            }
            else
            {
                errorProvider1.SetError(usuario_empleadoTextBox, "");
            }
        }

        private void contrasenia_empleadoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contrasenia_empleadoTextBox.Text))
            {
                errorProvider1.SetError(contrasenia_empleadoTextBox, "Se debe introducir la contraseña del empleado");
            }
            else
            {
                errorProvider1.SetError(contrasenia_empleadoTextBox, "");
            }
        }

        private void rol_empleadoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (rol_empleadoComboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rol_empleadoComboBox.Text))
            {
                errorProvider1.SetError(rol_empleadoComboBox, "Se debe introducir el rol del empleado");
            }
            else
            {
                errorProvider1.SetError(rol_empleadoComboBox, "");
            }
        }

        private void Empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable cambios = database1DataSet.Empleado.GetChanges();

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
                        empleadoBindingSource.EndEdit();
                        empleadoTableAdapter.Update(database1DataSet.Empleado);
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

        private void cargarDatosRol()
        {
            //Consulta los valores únicos del BindingSource principal
            var rolesUnicos = (from DataRowView row in empleadoBindingSource.List select row["Rol_empleado"].ToString()).Distinct().ToList();

            // Asigna los valores al ComboBox
            rol_empleadoComboBox.Items.Clear();
            rol_empleadoComboBox.Items.AddRange(rolesUnicos.ToArray());
        }

        private void rol_empleadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEmpleado_Click(object sender, EventArgs e)
        {

        }

        //Evento que borra el textopredeterminado del email
        private void email_empleadoTextBox_Enter(object sender, EventArgs e)
        {
            if (email_empleadoTextBox.Text == "usuario@dominio.ext")
            {
                email_empleadoTextBox.Text = string.Empty;
                email_empleadoTextBox.ForeColor = Color.Black;
            }
        }

        //Evento que reestablece el textopredeterminado del email
        private void email_empleadoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_empleadoTextBox.Text))
            {
                email_empleadoTextBox.Text = "usuario@dominio.ext";
                email_empleadoTextBox.ForeColor = Color.Gray;
            }
        }

        private void Empleados_KeyDown(object sender, KeyEventArgs e)
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

        private void imagen_empleadoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { imagen_empleadoPictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { imagen_empleadoPictureBox.Image = null; }
        }
    }
}

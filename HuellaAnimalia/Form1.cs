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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se copia la base de datos si no existe
            string origenBD = Path.Combine(Application.StartupPath, "Database1.mdf");
            string destinoCarpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia");
            string destinoBD = Path.Combine(destinoCarpeta, "Database1.mdf");

            if (!Directory.Exists(destinoCarpeta))
            {
                Directory.CreateDirectory(destinoCarpeta);
            }

            if (!File.Exists(destinoBD))
            {
                File.Copy(origenBD, destinoBD);
            }

            // Se configura la conexión del tableadapter
            string rutaBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "HuellaAnimalia", "Database1.mdf");
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={rutaBD};Integrated Security=True;Connect Timeout=30";
            this.empleadoTableAdapter.Connection.ConnectionString = connectionString;

            // Se cargan los datos del empleado
            this.empleadoTableAdapter.Fill(this.database1DataSet.Empleado);

            usuario_empleadoTextBox.Text = "Usuario";
            usuario_empleadoTextBox.ForeColor = Color.Gray;

            contrasenia_empleadoTextBox.Text = "Contraseña";
            contrasenia_empleadoTextBox.ForeColor = Color.Gray;
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            // Se comprueba que los campos no están vacíos
            if (string.IsNullOrEmpty(usuario_empleadoTextBox.Text) || string.IsNullOrEmpty(contrasenia_empleadoTextBox.Text))
                {
                    MessageBox.Show("Por favor, introduce el usuario y la contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            try
            {
                //Se busca el usuario en la base de datos
                Database1DataSet.EmpleadoRow fila = GetUsuarioEmpleado(usuario_empleadoTextBox.Text);

                if (fila != null)
                {
                    // Si la contraseña es correcta, guarda el rol en las configuraciones
                    if (fila.Contrasenia_empleado == contrasenia_empleadoTextBox.Text)
                    {
                        // Se guarda el usuario y el rol
                        Properties.Settings.Default.Usuario_empleado = fila.Usuario_empleado;
                        Properties.Settings.Default.Rol_empleado = fila.Rol_empleado;
                        Properties.Settings.Default.Nombre_empleado = fila.Nombre_empleado;
                        Properties.Settings.Default.Save();

                        // Se redirige al formulario principal (Form2)
                        Form2 form2 = new Form2();
                        form2.Show(); // Se muestra el formulario principal
                        this.Hide(); // Se oculta el formulario de login
                    }
                    else
                    {
                        // Si la contraseña es incorrecta se muestra un mensaje
                        MessageBox.Show("Contraseña incorrecta", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Usuario incorrecto
                    MessageBox.Show("Usuario incorrecto", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error al acceder a la base de datos del programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que devuleve la fila de usuario si se encuentra en la base de datos
        private Database1DataSet.EmpleadoRow GetUsuarioEmpleado (string usuario)
        {
            int indice = empleadoBindingSource.Find("Usuario_empleado", usuario);
            if (indice != -1)
            {
                return (Database1DataSet.EmpleadoRow)database1DataSet.Empleado.Rows [indice];
            }
            return null;
        }

        private void usuario_empleadoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Evento que borra el texto predeterminado del usuario
        private void usuario_empleadoTextBox_Enter(object sender, EventArgs e)
        {
            if (usuario_empleadoTextBox.Text == "Usuario")
            {
                usuario_empleadoTextBox.Text = string.Empty;
                usuario_empleadoTextBox.ForeColor = Color.Black;
            }
        }

        //Evento que reestablece el texto predeterminado del usuario
        private void usuario_empleadoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario_empleadoTextBox.Text))
            {
                usuario_empleadoTextBox.Text = "Usuario";
                usuario_empleadoTextBox.ForeColor = Color.Gray;
            }
        }

        //Evento que borra el texto predeterminado de la contraseña
        private void contrasenia_empleadoTextBox_Enter(object sender, EventArgs e)
        {
            if (contrasenia_empleadoTextBox.Text == "Contraseña")
            {
                contrasenia_empleadoTextBox.Text = string.Empty;
                contrasenia_empleadoTextBox.ForeColor = Color.Black;
                contrasenia_empleadoTextBox.PasswordChar = '*';
            }
        }

        //Evento que reestablece el texto predeterminado de la contraseña
        private void contrasenia_empleadoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contrasenia_empleadoTextBox.Text))
            {
                contrasenia_empleadoTextBox.Text = "Contraseña";
                contrasenia_empleadoTextBox.ForeColor = Color.Gray;
                contrasenia_empleadoTextBox.PasswordChar = '\0';
            }
        }

        private void contrasenia_empleadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se cierra la aplicación
            Application.Exit();
        }
    }
}

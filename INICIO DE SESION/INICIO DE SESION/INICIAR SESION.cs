
using System;
using System.Windows.Forms;

namespace INICIO_DE_SESION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "ADMIN";
            string claveCorrecta = "2026";

            string usuario = textBox1.Text.Trim();
            string clave = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show(
                    "Ingrese el usuario y la contraseña.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.Equals(usuario, usuarioCorrecto,
                    StringComparison.OrdinalIgnoreCase) &&
                clave == claveCorrecta)
            {
                MessageBox.Show(
                    "Inicio de sesión correcto.",
                    "Bienvenido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Aquí puedes abrir el formulario principal.
                // Ejemplo: new Form2().Show();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
    }
}

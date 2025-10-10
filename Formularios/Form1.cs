using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Formloggin : System.Windows.Forms.Form
    {
        public Formloggin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txusuario.Text;
            string contrasena = txcontraseña.Text;

            string usuarioValido = "admin";
            string contrasenaValida = "1234";

            if (usuario == usuarioValido && contrasena == contrasenaValida)
            {
                Inicio ventana = new Inicio();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcontraseña.Clear();
                txusuario.Focus();
            }
        }
    }
}

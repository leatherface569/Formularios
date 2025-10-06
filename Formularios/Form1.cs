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
            string user = txusuario.Text;
            string password = txcontraseña.Text;
            if(user.Trim().ToLower()=="elpepe"&&password.Trim().ToLower()=="1234")
            {
                Inicio ventana = new Inicio();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fallaste");
            }
        }
    }
}

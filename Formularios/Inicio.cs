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
    public partial class Inicio : Form
    {
        Acciones Acciones = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnregresaraloggin_Click(object sender, EventArgs e)
        {
            Formloggin ventana = new Formloggin();
            ventana.Show();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Acciones.AgregarNombres(txboxnombre.Text))
            {
                MessageBox.Show("Nombre agregado correctamente");
                txboxnombre.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar nombre");
            }
        }
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource = null;
            var nombres = Acciones.ObtenerNombre();
            if (nombres.Count > 0)
            dgvNombres.DataSource = nombres.Select(x => new { Nombre = x }).ToList();
            else
            MessageBox.Show("No hay nombres para mostrar");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(Acciones.EliminarNombre(txbeliminar.Text))
                MessageBox.Show("Nombre eliminado con exito");
            else
                MessageBox.Show("No se pudo eliminar nombre");
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar nombres en Excel";
                saveFileDialog.FileName = "Nombres.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;
                    if (Acciones.ExportarNombresAExcel(rutaArchivo))
                        MessageBox.Show("Exportación exitosa");
                    else
                        MessageBox.Show("Error al exportar");
                }
            }
        }
    }
}

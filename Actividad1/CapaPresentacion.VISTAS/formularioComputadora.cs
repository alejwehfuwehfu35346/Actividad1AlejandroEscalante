using System;
using System.Windows.Forms;
using BusinessServicesLayer;

namespace PresentationLayer
{
    public partial class FormularioComputadora : Form
    {
        private readonly ComputadoraBss computadoraBss;

        public FormularioComputadora(ComputadoraBss computadoraBss)
        {
            InitializeComponent();
            this.computadoraBss = computadoraBss;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Capturar los datos del formulario
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            DateTime fechaFabricacion = dtpFechaFabricacion.Value;

            // Crear una nueva instancia de Computadora
            Computadora computadora = new Computadora
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                FechaFabricacion = fechaFabricacion
            };

            // Insertar la computadora utilizando la capa de negocio
            computadoraBss.Insertar(computadora);

            // Mostrar un mensaje de éxito
            MessageBox.Show("La computadora se ha insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Otros eventos y métodos del formulario según sea necesario
    }
}
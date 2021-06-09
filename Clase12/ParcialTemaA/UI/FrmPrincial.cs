using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPrincial : Form
    {
        public FrmPrincial()
        {
            InitializeComponent();
        }

        Libreria objLibreria = new Libreria();
        Factura objFactura = new Factura();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbLibros.DataSource = objLibreria.Libros;
            //this.cmbLibros.DisplayMember = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro objLibro = (Libro)cmbLibros.SelectedItem;
            int cantidad = (int)nupCantidadLibros.Value;


            objFactura.AgregarDetalle(objLibro, cantidad);

            this.lboxDetalles.DataSource = null;

            this.lboxDetalles.DataSource = objFactura.Detalles;

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Total de la factura: " + objFactura.Total().ToString());
                FrmDetalleDeLaFactura objFormularioSecundario = new FrmDetalleDeLaFactura();
                objFormularioSecundario.Factura = objFactura;

                objFormularioSecundario.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}

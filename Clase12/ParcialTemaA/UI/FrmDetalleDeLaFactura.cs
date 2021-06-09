using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace UI
{
    public partial class FrmDetalleDeLaFactura : Form
    {
        public FrmDetalleDeLaFactura()
        {
            InitializeComponent();
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        private void FrmDetalleDeLaFactura_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = factura.Detalles;
            this.txtApellidoCliente.Text = factura.Cliente.Apellido;
            this.txtNombreCliente.Text = factura.Cliente.Nombre;
        }
    }
}

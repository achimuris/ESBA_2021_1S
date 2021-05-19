using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.TipoDeCliente objGestorTipoDeCliente = new BLL.TipoDeCliente();
            cmbTipoCliente.DataSource = objGestorTipoDeCliente.DevolverTipos();
            cmbTipoCliente.DisplayMember = "descripcion_tipo";
            cmbTipoCliente.ValueMember = "id_tipo";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BLL.TipoDeCliente objGestorTipoDeCliente = new BLL.TipoDeCliente();
            objGestorTipoDeCliente.Descripcion = txtNombreTipoCliente.Text;

            if (objGestorTipoDeCliente.CrearTipo() == 1)
            {
                MessageBox.Show("Se creó correctamente el nuevo Tipo de Cliente");
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void dgvTiposDeClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValorComboBox_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            mensaje = "Indice: " + cmbTipoCliente.SelectedIndex + "\n";
            mensaje = mensaje + "Valor: " + cmbTipoCliente.SelectedValue + "\n";
            mensaje = mensaje + "Item: " + cmbTipoCliente.SelectedItem + "\n";

            MessageBox.Show(mensaje);
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();

            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellido = txtApellido.Text;

            MessageBox.Show("Código por defecto del cliente: " + objCliente.Codigo);

            objCliente.TipoDeCliente = ObtenerTipoDeClienteSeleccionado();

   
            if (objCliente.CrearCliente() > 0)
            {
                MessageBox.Show("¡El cliente se ha creado de forma exitosa con el código: !" + objCliente.Codigo);
            }
            else
            {
                MessageBox.Show("¡Algo pasó!");
            }

        }

        private TipoDeCliente ObtenerTipoDeClienteSeleccionado()
        {
            TipoDeCliente objTipoDeCliente = new TipoDeCliente();
            objTipoDeCliente.Codigo = (int)cmbTipoCliente.SelectedValue;
            objTipoDeCliente.Descripcion = cmbTipoCliente.Text;


            return objTipoDeCliente;
        }
    }
}

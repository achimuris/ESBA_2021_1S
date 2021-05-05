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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.TipoDeCliente objGestorTipoDeCliente = new BLL.TipoDeCliente();
            dgvTiposDeClientes.DataSource = objGestorTipoDeCliente.DevolverTipos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BLL.TipoDeCliente objGestorTipoDeCliente = new BLL.TipoDeCliente();
            objGestorTipoDeCliente.Descripcion = "Básico";

            if (objGestorTipoDeCliente.CrearTipo() == 1)
            {
                MessageBox.Show("Se creó correctamente el nuevo Tipo de Cliente");
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }

        }
    }
}

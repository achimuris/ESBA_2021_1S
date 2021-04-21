using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;


namespace APP_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {

            Clases.Empresa objEmpresa = new Clases.Empresa();

            Empleado objPepe = new Empleado();


            objPepe.Nombre = txtNombreEmpleado.Text;


            objPepe.BonoPorResultado = obtenerBonoPorResultado();
            objPepe.Categoria = obtenerCategoria();


            MessageBox.Show("El sueldo final de " + objPepe.Nombre + " es de $" + objEmpresa.CalcularSueldo(objPepe));

        }

        private Categoria obtenerCategoria()
        {
            Categoria objCategoria;

            if (cboxCategorias.Text == "1 - Cadete")
            {
                objCategoria = new Cadete();
            }
            else
            {
                objCategoria = new Gerente();
            }

            return objCategoria;
        }

        private BonoPorResultado obtenerBonoPorResultado()
        {
            BonoPorResultado objBono = null;

            if (rbtnBonoPorPresentismoFijo.Checked)
            {
                objBono = new BonoPorResultadoFijo();
            }

            if (rbtnBonoPorPresentismoVariable.Checked)
            {
                objBono = new BonoPorResultadoVariable();
            }

            if (rbtnBonoPorPresentismoNADA.Checked)
            {
                objBono = null;
            }

            return objBono;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnBonoPorPresentismoFijo.Checked = true;
            cboxCategorias.SelectedIndex = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Factura
    {

        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }


        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public double Total()
        {
            double total = 0;

            if (Detalles == null || Detalles.Count==0)
            {
                throw new Exception("No se puede facturar algo que no tiene detalles");
            }

            foreach (DetalleFactura detalle in this.Detalles)
            {
                total += detalle.SubTotal();
            }

            return total;
        }

        public void AgregarDetalle(Libro unLibro, int unaCantidad)
        {
            DetalleFactura objDetalle = new DetalleFactura();
            objDetalle.Cantidad = unaCantidad;
            objDetalle.Libro = unLibro;

            this.Detalles.Add(objDetalle);
        }

        private List<DetalleFactura> detalleFacturas;

        public List<DetalleFactura> Detalles
        {
            get { return detalleFacturas; }
            set { detalleFacturas = value; }
        }

        public Factura()
        {
            this.detalleFacturas = new List<DetalleFactura>();
            Cliente objCliente = new Cliente();
            objCliente.Nombre = "Lionel Andrés";
            objCliente.Apellido = "Messi";
            objCliente.DNI = 465489;

            this.Cliente = objCliente;

        }

    }
}
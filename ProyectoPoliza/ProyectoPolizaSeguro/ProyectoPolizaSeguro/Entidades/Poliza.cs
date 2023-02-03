using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Entidades
{
    public class Poliza
    {
        public Asegurado IdPoliza { get; set; }
        public Producto IdProducto { get; set; }
        public TipoProducto IdTipoProducto { get; set; }
        public bool Estado { get; set; }

        public Poliza()
        {
            IdTipoProducto = new TipoProducto();
            IdProducto = new Producto();
            IdPoliza = new Asegurado();
        }

    }
}

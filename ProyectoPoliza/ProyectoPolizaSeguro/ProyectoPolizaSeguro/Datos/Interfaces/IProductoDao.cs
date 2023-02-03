using ProyectoPolizaSeguro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Datos.Interfaces
{
    internal interface IProductoDao
    {
        List<Producto> RecuperarPorId(int id);   
    }
}

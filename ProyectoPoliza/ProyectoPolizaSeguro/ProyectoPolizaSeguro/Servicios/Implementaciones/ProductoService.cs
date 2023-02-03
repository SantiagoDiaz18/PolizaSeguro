using ProyectoPolizaSeguro.Datos.Dao;
using ProyectoPolizaSeguro.Datos.Interfaces;
using ProyectoPolizaSeguro.Entidades;
using ProyectoPolizaSeguro.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Servicios.Implementaciones
{
    internal class ProductoService : IProductoService
    {
        private IProductoDao oDao;

        public ProductoService()
        {
            oDao = new ProductoDao();
        }
        public List<Producto> TraerPorId(int id)
        {
            return oDao.RecuperarPorId(id);
        }
    }
}

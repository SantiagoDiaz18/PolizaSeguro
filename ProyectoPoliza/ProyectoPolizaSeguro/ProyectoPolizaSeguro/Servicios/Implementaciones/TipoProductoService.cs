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
    internal class TipoProductoService : ITipoProductoService
    {
        private ITipoProductoDao oDao;

        public TipoProductoService()
        {
            oDao = new TipoProductoDao();
        }
        public List<TipoProducto> TraerPorId(int id)
        {
            return oDao.RecuperarPorId(id);
        }
    }
}

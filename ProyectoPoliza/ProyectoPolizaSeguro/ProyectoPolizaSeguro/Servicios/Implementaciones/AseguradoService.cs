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
    internal class AseguradoService : IAseguradoService
    {
        private IAseguradoDao oDao;

        public AseguradoService()
        {
            oDao = new AseguradoDao();
        }

        public int EliminarAsegurado(int id)
        {
            return oDao.Eliminar(id);
        }

        public List<Asegurado> TraerPorId(int id)
        {
            return oDao.RecuperarPorId(id);
        }
    }
}

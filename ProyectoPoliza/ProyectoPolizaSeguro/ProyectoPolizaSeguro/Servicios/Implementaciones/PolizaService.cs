using ProyectoPolizaSeguro.Datos.Dao;
using ProyectoPolizaSeguro.Datos.Interfaces;
using ProyectoPolizaSeguro.Entidades;
using ProyectoPolizaSeguro.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Servicios
{
    internal class PolizaService : IPolizaService
    {
        private IPolizaDao oDao;

        public PolizaService()
        {
            oDao = new PolizaDao();
        }
        public List<Poliza> TraerPorId(int id)
        {
            return oDao.RecuperarPorId(id);
        }
    }
}

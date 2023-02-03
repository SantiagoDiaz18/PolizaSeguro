using ProyectoPolizaSeguro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Servicios.Interfaces
{
    internal interface IPolizaService
    {
        List<Poliza> TraerPorId(int id);
    }
}

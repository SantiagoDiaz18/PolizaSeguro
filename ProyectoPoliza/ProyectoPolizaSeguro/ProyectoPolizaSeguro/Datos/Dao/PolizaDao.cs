using ProyectoPolizaSeguro.Datos.Interfaces;
using ProyectoPolizaSeguro.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Datos.Dao
{
    internal class PolizaDao : IPolizaDao
    {
        public List<Poliza> RecuperarPorId(int id)
        {
                Poliza oPoliza = new Poliza();
                List<Poliza> lista = new List<Poliza>();
                string consulta = "Select IdProducto, IdTipoProducto " +
                    "from Poliza WHERE Estado = 1 and IdPoliza=" + id.ToString();
                
                DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
                if (tabla.Rows.Count > 0)
                {

                    oPoliza.IdProducto.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                    oPoliza.IdTipoProducto.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["IdTipoProducto"]);
                    
                    lista.Add(oPoliza);
                }
                return lista;
            }
    }
}

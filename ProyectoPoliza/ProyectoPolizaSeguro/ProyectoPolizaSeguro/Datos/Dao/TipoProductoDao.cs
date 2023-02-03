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
    internal class TipoProductoDao : ITipoProductoDao
    {
        public List<TipoProducto> RecuperarPorId(int id)
        {
            TipoProducto oTipoProducto = new TipoProducto();
            List<TipoProducto> lista = new List<TipoProducto>();
            string consulta = "Select Nombre " +
                "from TipoProducto WHERE IdTipoProducto=" + id.ToString();

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {


                oTipoProducto.IdTipoProducto = id;
                oTipoProducto.Nombre = tabla.Rows[0]["Nombre"].ToString();


                lista.Add(oTipoProducto);
            }
            return lista;
        }
    }
}

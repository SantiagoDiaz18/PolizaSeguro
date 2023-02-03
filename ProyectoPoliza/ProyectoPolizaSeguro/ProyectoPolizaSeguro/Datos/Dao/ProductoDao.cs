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
    internal class ProductoDao : IProductoDao
    {
        public List<Producto> RecuperarPorId(int id)
        {
            Producto oProducto = new Producto();
            List<Producto> lista = new List<Producto>();
            string consulta = "Select Nombre " +
                "from Producto WHERE IdProducto=" + id.ToString();

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {

              
                oProducto.IdProducto = id;
                oProducto.Nombre = tabla.Rows[0]["Nombre"].ToString();
               

                lista.Add(oProducto);
            }
            return lista;
        }
    }
}

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
    internal class AseguradoDao : IAseguradoDao
    {
        public int Eliminar(int id)
        {
            string consulta = "UPDATE Asegurados SET Estado=0 WHERE idAsegurado=" + id.ToString();
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public List<Asegurado> RecuperarPorId(int id)
        {
            Asegurado oAsegurado = new Asegurado();
            List<Asegurado> lista = new List<Asegurado>();
            string consulta = "Select IdAsegurado, Dni, Nombre, FechaNacimiento " +
                "from Asegurados WHERE Estado = 1 and IdPoliza=" + id.ToString();

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {

                oAsegurado.IdAsegurado = Convert.ToInt32(tabla.Rows[0]["IdAsegurado"]);
                oAsegurado.Dni = Convert.ToInt32(tabla.Rows[0]["Dni"]);
                oAsegurado.Nombre = tabla.Rows[0]["Nombre"].ToString();
                oAsegurado.FechaNacimiento = Convert.ToDateTime(tabla.Rows[0]["FechaNacimiento"]);
                oAsegurado.Estado = true;

                lista.Add(oAsegurado);
            }
            return lista;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPolizaSeguro.Entidades
{
    public class Asegurado
    {
        public int IdPoliza { get; set; }
        public int IdAsegurado  { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }

        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;

            // Comprueba que el mes de la fecha de nacimiento es mayor 
            // que el mes de la fecha actual:
            if (FechaNacimiento.Month > DateTime.Today.Month)
            {
                --edad;
            }

            return edad;
        }
    }
}

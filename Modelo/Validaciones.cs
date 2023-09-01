using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Validaciones
    {
        public bool ValidarVacio(string valor, string campo)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("el campo " + campo + " se encuentra vacío");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarNumero(string input, ref int valor, string campo)
        {
            bool flag = false;

            if (!int.TryParse(input, out valor))
            {
                Console.WriteLine("Por favor, ingresar un valor numérico en el campo " + campo + ".");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Por favor, ingresar un valor positivo");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
        public bool ValidarFecha(string fecha, ref DateTime salida, string campo)
        {
            bool flag = false;

            if (!DateTime.TryParse(fecha, out salida))
            {
                Console.WriteLine("El dato no es una fecha valida en el campo " + campo +".");
            }
            else if (salida > DateTime.Now)
            {
                Console.WriteLine("La fecha no debe ser mayor a hoy en el campo " + campo + ".");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public bool ValidarTipoNum(ref int valor, string campo)
        {
            bool flag = false;

            if (valor != 1 || valor != 2 || valor != 3)
            {
                Console.WriteLine("Por favor, ingresar un valor válido del " + campo + ".");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}

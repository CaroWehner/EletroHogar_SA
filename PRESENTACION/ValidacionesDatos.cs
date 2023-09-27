using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class ValidacionesDatos
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
                Console.WriteLine("El dato no es una fecha valida en el campo: " + campo + ".");
            }
            else if (salida <= new DateTime(1910, 01, 01) || salida > DateTime.Today)
            {
                Console.WriteLine("La fecha es inválida en el campo: " + campo + ".");
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

            if (valor != 1 && valor != 2 && valor != 3)
            {
                Console.WriteLine("Por favor, ingresar un valor válido del " + campo + ".");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        /*public bool ValidarID (string input)
        {
            bool flag = true;
            if(!(input.Length == 32))
            {
                //los tipos de dato GUID tienen 32 caracteres
                Console.WriteLine("El ID debe tener 32 caracteres.");
            }
            else if (IDsolonum(input) == false)
            {
                Console.WriteLine("El ID contiene dígitos especiales y solo debe contener números");
            }
            else if(Guid.TryParse(input, out Guid idvalidado))
            {
                Console.WriteLine("El ID contiene un formato válido.");
            }
            else
            {
                flag = false;
                Console.WriteLine("El ID no contiene un formato válido");
            }

            return flag;
        }
        */
        //verifica que el ID solo tenga números y no guiones (para luego verificar que tenga 32 números en el método de arriba)
        public bool IDsolonum(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
        internal static bool ValidarVacioid(string idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}

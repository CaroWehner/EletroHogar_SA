using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesUsuario
    {
        public bool CantCaracteres(string valor, int min, int max, string campo)
        {
            bool flag = false;
            if (valor.Length < min || valor.Length > max)
            {
                Console.WriteLine($"El campo {campo} debe tener entre {min} y {max} caracteres");
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}

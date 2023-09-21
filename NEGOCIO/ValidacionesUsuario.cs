using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesUsuario
    {

        public bool ValidarNombreUsuario(string nombreUsuario, string nombre, string apellido, int min, int max)
        {
            if (nombreUsuario.Length >= min && nombreUsuario.Length <= max)
            {
                // Verifica que el nombre de usuario no contenga ni el nombre ni el apellido
                if (!nombreUsuario.Contains(nombre) && !nombreUsuario.Contains(apellido))
                {
                    Console.WriteLine("Nombre de usuario válido.");
                    return true;
                }
                else
                {
                    Console.WriteLine("El nombre de usuario no puede contener ni su nombre ni su apellido.");
                }
            }
            else
            {
                Console.WriteLine("El nombre de usuario debe tener entre 8 y 15 caracteres.");
            }

            return false; // La validación falló
        }
        public static void ValidarexpiraciónContraseña (DateTime  FechaContraseña)
        {
            DateTime Hoy = DateTime.Today; 
            DateTime fechaHoy = Convert.ToDateTime(Hoy);
            DateTime fechaContraseña = Convert.ToDateTime(FechaContraseña);
            TimeSpan difFechas = fechaHoy - fechaContraseña;
            int días = difFechas.Days;
            while (días > 30)
            {
                Console.WriteLine("Su contraseña a expirado, por favor ingrese una nueva contraseña");
                string NuevaContra = Console.ReadLine();
                //Agregar validación para contraseña
            }
            
            



        }
    }
}
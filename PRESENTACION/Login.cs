using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Negocio;

namespace PRESENTACION
{
    public class Login
    {
        public string IngresarUsuario()
        {
            bool flag = false;
            string inputNombreUsuario;
            do
            {
                Console.Write("Ingresar Nombre de Usuario: ");
                inputNombreUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputNombreUsuario, "Nombre del Usuario");

            } while (flag == false);
            return inputNombreUsuario;

        }

        public string IngresarContraseña()
        {
            bool flag = false;
            string inputContraseña;
            do
            {
                Console.Write("Ingresar Contraseña: ");
                inputContraseña = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputContraseña, "Contraseña");
            } while (flag == false);

            return inputContraseña;
        }

        public string BuscarContraseña(UsuarioModel usuarioEncontrado, string inputContraseña)
        {
            string msj = "";
            if (usuarioEncontrado.contraseña != inputContraseña)
            {
                msj = "Contraseña invalida";
            }

            return msj;
        }
    }
}

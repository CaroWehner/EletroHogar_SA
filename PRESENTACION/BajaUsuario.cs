using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class BajaUsuario
    {
        public UsuarioModel DarBajaUsuario()
        {
            string idUsuario;
            bool flag;
            do
            {
                Console.Write("Ingresar el id del usuario a dar de baja: ");
                idUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(idUsuario, "ID Usuario");

            } while (flag == false);

            Menu menu = new Menu();
            UsuarioModel usuario = menu.BuscarUsuario(idUsuario);
            usuario.estado = "INACTIVO";
            return usuario;
        }
    }
}

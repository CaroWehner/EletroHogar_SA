using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Modelo;
using System.Data.SqlTypes;

namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string inputTareasAdministrador;
            int tareasAdministrador = 0;

            Console.WriteLine("Bienvenidos al sistema de Eletro Hogar S.A.");
            //List<UsuarioModel> usuarios = new List<UsuarioModel>();

            UsuarioModel usuario = new UsuarioModel();
            usuario.UsuarioAdmin("Carolina", "Wehner", "Uzal 1234", "carowehner2001@gmail.com", new DateTime(2001, 05, 23), "AdminCW", 1, 43245128, "CAI20232");
            // DATOS DE CADA UNO

            //UsuarioModel usuario1 = new UsuarioModel(); // Crear una instancia de UsuarioModel
            string inputNombreUsuario = usuario.IngresarUsuario();

            string mensaje = usuario.BuscarPerfil(usuario, usuario.host);

            string inputContraseña = usuario.IngresarContraseña();

            string msj = usuario.BuscarContraseña(usuario, usuario.contraseña);


            /*Si es perfil administrador dar las opcion de dar de alta un usuario:
            do
            {
                Console.Write("Ingrese el número de tarea que se quiere realizar: ");
                inputTareasAdministrador = Console.ReadLine();

                Validaciones validador = new Validaciones(); 
                flag = validador.ValidarNumero(inputTareasAdministrador, ref tareasAdministrador, "Tareas Administrador");

            } while (flag == false);
            */

            UsuarioModel usuarioModel = new UsuarioModel();
            UsuarioModel usuario2 = usuarioModel.AltaUsuario();

           
        }
    }
}

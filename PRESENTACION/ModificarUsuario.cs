using Modelo;
using Negocio;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class ModificarUsuario
    {

        public UsuarioModel ModiUsuario()
        {
            string idUsuario;
            bool flag;
            do
            {
                Console.Write("Ingresar el id del usuario a modificar: ");
                idUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(idUsuario, "ID Usuario");

            } while (flag == false);

            Menu menu = new Menu();
            UsuarioModel usuario = menu.BuscarUsuario(idUsuario);
            return usuario;
        }

        public UsuarioModel ModUsuario()
        {
            bool CtrlG = true;
            do
            {
                Console.WriteLine("Seleccione que tarea va a realizar");
                Console.WriteLine("1: Modificar Contraseña");
                Console.WriteLine("2: Modificar Estado");
                Console.WriteLine("3: Baja usuario");
                Console.WriteLine("4: Salir");

                string opcG = Console.ReadLine().ToUpper();

                switch (opcG)
                {
                    case "1":
                        cambiarContraseña();
                        break;

                    case "2":
                        cambiarEstado();

                        break;

                    case "3":
                        bajaUsuario();
                        break;

                    case "4":
                        Console.WriteLine("Esta volviendo al menú principal");
                        CtrlG = false;
                        break;

                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                        break;
                }
            } while (CtrlG);


            void  cambiarContraseña()
            {             

                Console.WriteLine("Ingrese la nueva constraseña");

                string nuevaContraseña = Console.ReadLine();
                 
                Console.WriteLine("Se guardo la nueva contraseña con exito");
               
            }

            void cambiarEstado()
            {

            }

            void bajaUsuario()
            {

            }

            UsuarioModel usuario = new UsuarioModel();

            return usuario;
        }
    }
}


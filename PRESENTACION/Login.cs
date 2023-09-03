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

        public static string IngresarContraseña()
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
        //Busca que la contraseña sea valida y verifica que no este expirada
        public static void BuscarContraseña(UsuarioModel usuarioEncontrado, string inputContraseña, DateTime FechaContra)
        {
            bool Control = true;
            int contador = 0;
            do
            { 
            if (usuarioEncontrado.contraseña != inputContraseña)
            {
                Console.WriteLine("Contraseña invalida, ingrese nuevamente su contraseña");
                    inputContraseña = Login.IngresarContraseña();
                    contador = contador + 1; 
            }
            if (usuarioEncontrado.contraseña == inputContraseña)
             {
              Control = false;
             }
            if (contador == 3)
             {
              Environment.Exit(0);
             }
                
            } while (Control);
            DateTime Hoy = DateTime.Today;
            TimeSpan difFechas = Hoy - FechaContra;
            double dif = difFechas.TotalDays;
            Console.WriteLine("Hola" + dif);
            if (dif >= 30)
            {
                Console.WriteLine("Su contraseña a expirado, por favor ingrese una nueva contraseña");
                string NuevaContra = Console.ReadLine();
                // pendiente agregar validador de contraseña
                usuarioEncontrado.contraseña= NuevaContra;
                usuarioEncontrado.fechacontraseña = Hoy;
                Console.WriteLine("Se ha cambiado su contraseña");
            }
        }
    }
}


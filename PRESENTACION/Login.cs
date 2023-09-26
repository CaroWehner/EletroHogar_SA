using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Negocio;

namespace PRESENTACION
{
    public class LoginInicio
    {
        public void IntentosLogin(UsuarioModel usuario, string inputNombreUsuario)
        {
            int contador = 0;

            do
            {
                IngresarUsuario();
                if (usuario.usuario != inputNombreUsuario)
                {
                    Console.WriteLine("El nombre de usuario no es el mismo que ingresó anteriormente");
                    contador--;
                }
                IngresarContraseña();

            } while (contador < 4);

            Console.WriteLine("Usted excedió la cantidad máxima de intentos y su Usuario ha pasado a estado INACTIVO");
            //buscar usuario y pasarlo a INACTIVO 
        }
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
        //Busca que la contraseña sea valida y verifica que no este expirada - MM 
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
            bool flag = false;
            if (dif >= 30)
            {
                Console.WriteLine("Su contraseña a expirado, por favor ingrese una nueva contraseña: ");
                string NuevaContra = Console.ReadLine();
                while (flag == false) 
                { 
                    if (usuarioEncontrado.contraseña == NuevaContra)
                    {
                        Console.WriteLine("La nueva contraseña no puede ser igual a la anterior" +
                                         System.Environment.NewLine + "Por favor vuelva a introducir una contraseña válida: ");

                        NuevaContra = Console.ReadLine();

                    }
                    else
                    {
                       flag = true;
                    }
                    
                }
                ValidacionesUsuario.ValidarContraseña(NuevaContra);
                usuarioEncontrado.contraseña= NuevaContra;
                usuarioEncontrado.fechacontraseña = Hoy;
                Console.WriteLine("Se ha cambiado su contraseña");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Negocio;

namespace Modelo
{
    public class UsuarioModel
    {
        
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaBaja { get; set; }
        public string usuario { get; set; }
        public Int32 host { get; set; }
        public Int32 dni { get; set; }
        public string contraseña { get; set; }


        public UsuarioModel()
        {

        }
        public UsuarioModel(Guid Id, string Nombre, string Apellido, string Direccion, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime FechaBaja, string Usuario, Int32 Host, Int32 Dni, string Contraseña)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            direccion = Direccion;
            email = Email;
            fechaAlta = FechaAlta;
            fechaNacimiento = FechaNacimiento;
            fechaBaja = FechaBaja;
            usuario = Usuario;
            host = Host;
            dni = Dni;
            contraseña = Contraseña;
        }

        List<UsuarioModel> usuarios = new List<UsuarioModel>();
        public UsuarioModel UsuarioAdmin(string Nombre, string Apellido, string Direccion, string Email, DateTime FechaNacimiento, string Usuario, Int32 Host, Int32 Dni, string Contraseña)
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.id = Guid.NewGuid();
            usuario.nombre = Nombre;
            usuario.apellido = Apellido;
            usuario.direccion = Direccion;
            usuario.email = Email;
            usuario.fechaAlta = DateTime.Now;
            usuario.fechaNacimiento = FechaNacimiento;
            usuario.fechaBaja = new DateTime(2999, 12, 31); 
            usuario.usuario = Usuario;
            usuario.host = Host;
            usuario.dni = Dni;
            usuario.contraseña = Contraseña;

            usuarios.Add(usuario);

            return usuario;
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

        public string IngresarUsuario()
        {
            bool flag = false;
            string inputNombreUsuario;
            do
            {
                Console.Write("Ingresar Nombre de Usuario: ");
                inputNombreUsuario = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                flag = validador.ValidarVacio(inputNombreUsuario, "Nombre del Usuario");
                
                if (BuscarUsuario(inputNombreUsuario) == null)
                {
                    Console.WriteLine("Usuario no existe, se debera dar de alta con un Administrado.");
                    flag = false;
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);
            return inputNombreUsuario;
        }
        public UsuarioModel BuscarUsuario(string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }

        public string BuscarPerfil(UsuarioModel usuarioEncontrado, int inputhost)
        {
            string msj = "";
            if (usuarioEncontrado.host == 1)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Administrador";
            }
            else if (usuarioEncontrado.host == 2)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Supervisor";
            }
            else if (usuarioEncontrado.host == 3)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Vendedor";
            }

            return msj;
        }


        public string IngresarContraseña()
        {
            bool flag = false;
            string inputContraseña;
            do
            {
                Console.Write("Ingresar Contraseña: ");
                inputContraseña = Console.ReadLine();
                Validaciones validador = new Validaciones();
                flag = validador.ValidarVacio(inputContraseña, "Contraseña");
            } while (flag == false);
            return inputContraseña;
        }

        public UsuarioModel AltaUsuario()
        {
            bool flag = false;
            string inputNombre;
            string inputApellido;
            string inputDireccion;
            string inputTelefono;
            int telefono = 0;
            string inputEmail;
            string inputFechaNacimiento;
            DateTime fechaNacimiento = DateTime.Now;
            string inputPerfil;
            int perfil = 0;
            string inputDni;
            int dni = 0;
            string NombreUsuario;
            string inputContra;
            int minCaracteresUsuario = 8;
            int maxCaracteresUsuario = 15;

                do
                {
                    Console.Write("Ingresar el nombre: ");
                    inputNombre = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarVacio(inputNombre, "Nombre");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar el apellido: ");
                    inputApellido = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarVacio(inputApellido, "Apellido");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar la dirección: ");
                    inputDireccion = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarVacio(inputDireccion, "Dirección");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar un teléfono: ");
                    inputTelefono = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarNumero(inputTelefono, ref telefono, "Telefono");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar un mail: ");
                    inputEmail = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarVacio(inputEmail, "Email");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar tu fecha de nacimiento: ");
                    inputFechaNacimiento = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarFecha(inputFechaNacimiento, ref fechaNacimiento, "Fecha de Nacimiento");
                } while (flag == false);

                do
                {
                    Console.Write("El Nombre de Usuario debe tener entre 8 a 15 caracteres y no debe tener su nombre o apellido dentro del mismo.");
                    Console.Write("Ingresar Nombre de Usuario: ");
                    NombreUsuario = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarVacio(NombreUsuario, "Nombre");

                    ValidacionesUsuario validadorUsuario = new ValidacionesUsuario();
                    flag = validadorUsuario.CantCaracteres(NombreUsuario, minCaracteresUsuario, maxCaracteresUsuario, "Nombre");

                    //AGREGAR VALIDACION DE NOMBRE Y APELLIDO

                } while (flag == false);

                do
                {
                    Console.Write("1- Perfil Administrador");
                    Console.Write("2- Perfil Supervisor");
                    Console.Write("3- Perfil Vendedor");
                    Console.Write("Seleccionar la opcion correspondiente del Perfil: ");
                    inputPerfil = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarNumero(inputPerfil, ref perfil, "Perfil");
                    flag = validador.ValidarTipoNum(ref perfil, "Perfil");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar su DNI: ");
                    inputDni = Console.ReadLine();
                    Validaciones validador = new Validaciones();
                    flag = validador.ValidarNumero(inputDni, ref dni, "Dirección");
                } while (flag == false);

                do
                {
                    Console.Write("Ingresar su Contraseña: ");
                    inputContra = Console.ReadLine();

                    //AGREGAR VALIDACIONES DE CONTRASEÑA

                } while (flag == false);

            UsuarioModel usuario = new UsuarioModel();
            usuario.id = Guid.NewGuid();
            usuario.nombre = inputNombre;
            usuario.apellido = inputApellido;
            usuario.direccion = inputDireccion;
            usuario.email = inputEmail;
            usuario.fechaAlta = DateTime.Now;
            usuario.fechaNacimiento = fechaNacimiento;
            usuario.fechaBaja = new DateTime(2999, 12, 31);
            usuario.usuario = NombreUsuario;
            usuario.host = perfil;
            usuario.dni = dni;
            usuario.contraseña = inputContra;

            usuarios.Add(usuario);
            return usuario;
        }

    } 
}

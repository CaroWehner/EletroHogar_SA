using Modelo;
using System;
using System.Collections.Generic;
using PRESENTACION;
using NEGOCIO;
using System.Net;

namespace Presentacion
{
    public class Program
    {
        public static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        //UsuarioModel usuario = new UsuarioModel();
        private static LoginInicio loginIn = new LoginInicio();
        static void Main(string[] args)
        {
            UsuarioModel usuario = new Administrador();
            //List<UsuarioModel> usuarios = new List<UsuarioModel>();

            Console.WriteLine("Bienvenidos al sistema de Eletro Hogar S.A.");
            
            MetodosUsuarios usu = new MetodosUsuarios();
            usuario = usu.CrearUsuario("1","Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", new DateTime(2001, 05, 23), "AdministradoraCW", 1, 43245128, "CAI20232");
            usuarios.Add(usuario);
            usuario = usu.CrearUsuario("2", "Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", new DateTime(1994, 07, 12), "AdministradoraEZ", 1, 38491201, "CAI20232");
            usuarios.Add(usuario);
            usuario = usu.CrearUsuario("3", "Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", new DateTime(1999, 04, 20), "AdministradorPG", 1, 41823861, "CAI20232");
            usuarios.Add(usuario);
            // DATOS DE CADA UNO

            //declaro variable para definir el perfil para el menú
            int PerfilMenu = 0;

            string inputNombreUsuario = loginIn.IngresarUsuario();
            //usuario = usuarios.Find(u => u.usuario == inputNombreUsuario);
            if (usuarios.Find(u => u.usuario == inputNombreUsuario) == null)
            {
                Console.WriteLine("Usuario no existe, se debera dar de alta con un Administrador.");

            }
            else
            {
                MetodosUsuarios perfil = new MetodosUsuarios();
                string mensaje = perfil.BuscarPerfil(usuario, usuario.host);
                Console.WriteLine(mensaje);
                PerfilMenu = usuario.host;
            }
            string inputContraseña = LoginInicio.IngresarContraseña();
            LoginInicio.BuscarContraseña(usuario, inputContraseña, usuario.fechacontraseña);


            //Agrego menu según perfil del usuario
            if (PerfilMenu == 1)
            {
                Menu.MenuAdm();
            }
            if (PerfilMenu == 2)
            {
                Menu.MenuSupervisor();
            }
            else
            {
                Menu.MenuVendedor();
            }

        }


        public UsuarioModel BuscarUsuario(string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }

        public void ListarUsuarios()
        {
            bool flag = false;
            ValidacionesDatos validador = new ValidacionesDatos();
            Console.WriteLine("ingrese el id del usuario: ");
            string id = Console.ReadLine();
            flag = validador.ValidarVacio(id, "Id Usuario");
            //flag = ValidacionesDatos.ValidarID(id);
            BuscarUsuario(id);

            if (flag == true)
            {
                if (usuarios.Count > 0)
                {
                    foreach (UsuarioModel UM in usuarios)
                    {
                        Console.WriteLine("El usuario con Id " + id + " es: " + BuscarUsuario(id));
                    }
                }
                else
                {
                    Console.WriteLine("No existen usuarios con el id seleccionado");
                }

            }
        }

    }
}

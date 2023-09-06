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
        //List<UsuarioModel> usuarios = new List<UsuarioModel>();
        //UsuarioModel usuario = new UsuarioModel();

        static void Main(string[] args)
        {
            UsuarioModel usuario = new UsuarioModel();
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            Console.WriteLine("Bienvenidos al sistema de Eletro Hogar S.A.");

            MetodosUsuarios usu = new MetodosUsuarios();
            usuario = usu.CrearUsuario("Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", new DateTime(2001, 05, 23), "AdministradoraCW", 1, 43245128, "CAI20232");
            usuarios.Add(usuario);
            usuario = usu.CrearUsuario("Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", new DateTime(1994, 07, 12), "AdministradoraEZ", 1, 38491201, "CAI20232");
            usuarios.Add(usuario);
            usuario = usu.CrearUsuario("Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", new Datetime(1999, 04, 20), "AdministradorPG", 1, 41823861, "CAI20232");
            // DATOS DE CADA UNO

            //declaro variable para definir el perfil para el menú
            int PerfilMenu = 0;

            Login login = new Login();
            string inputNombreUsuario = login.IngresarUsuario();
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
            string inputContraseña = Login.IngresarContraseña();
            Login.BuscarContraseña(usuario, inputContraseña, usuario.fechacontraseña);


            //Agrego menu según perfil del usuario
            if (PerfilMenu==1)
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

        /*public UsuarioModel BuscarUsuario(string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }*/

        public UsuarioModel BuscarUsuario (string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }
    }
}

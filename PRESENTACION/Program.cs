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
            // DATOS DE CADA UNO


            Login login = new Login();
            string inputNombreUsuario = login.IngresarUsuario();
            //usuario = usuarios.Find(u => u.usuario == inputNombreUsuario);
            if (usuarios.Find(u => u.usuario == inputNombreUsuario) == null)
            {
                Console.WriteLine("Usuario no existe, se debera dar de alta con un Administrado.");
               
            }
            else
            {
                MetodosUsuarios perfil = new MetodosUsuarios();
                string mensaje = perfil.BuscarPerfil(usuario, usuario.host);
                Console.WriteLine(mensaje);
            }
            string inputContraseña = login.IngresarContraseña();
            string msj = login.BuscarContraseña(usuario, usuario.contraseña);


            //AGREGAR INTERFAZ DE MENU, DEL LADOD DE ADMIN DEJO EL ALTA DE UN USUARIO

            AltaUsuario alta = new AltaUsuario();
            usuario = alta.DarAltaUsuario();
            usuarios.Add(usuario);



        }

        /*public UsuarioModel BuscarUsuario(string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }*/


    }
}

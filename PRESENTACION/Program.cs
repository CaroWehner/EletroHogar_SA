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

        static void Main(string[] args)
        {
            UsuarioModel usuario = new UsuarioModel();

            Console.WriteLine("Bienvenidos al sistema de Eletro Hogar S.A.");

            MetodosUsuarios usu = new MetodosUsuarios();
            usuario = usu.CrearUsuario("Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", new DateTime(2001, 05, 23), "AdministradoraCW", 1, 43245128, "CAI20232");
            Menu.usuarios.Add(usuario);
            usuario = usu.CrearUsuario("Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", new DateTime(1994, 07, 12), "AdministradoraEZ", 1, 38491201, "CAI20232");
            Menu.usuarios.Add(usuario);
            usuario = usu.CrearUsuario("Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", new DateTime(1999, 04, 20), "AdministradorPG", 1, 41823861, "CAI20232");
            Menu.usuarios.Add(usuario);
            usuario = usu.CrearUsuario("Manuel", "Monasterio", "Bollini 3451", "1198765432", "manuelm@gmail.com", new DateTime(1998, 04, 14), "AdministradorMM", 1, 41048142, "CAI20232");
            Menu.usuarios.Add(usuario);

            //declaro variable para definir el perfil para el menú
            int PerfilMenu = 0;

            Login login = new Login();
            string inputNombreUsuario = login.IngresarUsuario();
            bool flag = false;
            do
            {

                if (Menu.usuarios.Find(u => u.usuario == inputNombreUsuario) != null)
                {
                    UsuarioModel usuario1 = Menu.usuarios.Find(p => p.usuario == inputNombreUsuario);
                    MetodosUsuarios perfil = new MetodosUsuarios();
                    string mensaje = perfil.BuscarPerfil(usuario1, usuario1.host);
                    Console.WriteLine(mensaje);
                    PerfilMenu = usuario1.host;
                    string inputContraseña = Login.IngresarContraseña();
                    Login.BuscarContraseña(usuario1, inputContraseña, usuario1.fechacontraseña);
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Usuario no existe, se debera dar de alta con un Administrador.");
                    inputNombreUsuario = login.IngresarUsuario();
                    flag = false;
                }
            } while (flag == false);

            //Agrego menu según perfil del usuario
            if (PerfilMenu == 1)
            {
                Menu.MenuAdm();
            }
            else if (PerfilMenu == 2) //MM - se modifico else if
            {
                Menu.MenuSupervisor();
            }
            else if (PerfilMenu == 3) //MM - se modifico para que no entre por error termine el programa
            {
                Menu.MenuVendedor();
            }

        }

    }
}

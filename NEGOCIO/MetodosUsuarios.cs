using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class MetodosUsuarios
    {

        public UsuarioModel CrearUsuario(string Nombre, string Apellido, string Direccion, string telefono, string Email, DateTime FechaNacimiento, string Usuario, Int32 Host, Int32 Dni, string Contraseña)
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.id = Guid.NewGuid();
            usuario.nombre = Nombre;
            usuario.apellido = Apellido;
            usuario.direccion = Direccion;
            usuario.telefono = telefono;
            usuario.email = Email;
            usuario.fechaAlta = DateTime.Now;
            usuario.fechaNacimiento = FechaNacimiento;
            usuario.fechaBaja = new DateTime(2999, 12, 31);
            usuario.usuario = Usuario;
            usuario.host = Host;
            usuario.dni = Dni;
            usuario.contraseña = Contraseña;

            return usuario;
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



    }
}

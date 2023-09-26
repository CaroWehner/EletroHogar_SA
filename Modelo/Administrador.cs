using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modelo
{
    public class Administrador : UsuarioModel
    {
        public Administrador()
        {
        }

        public Administrador(string Id, string Nombre, string Apellido, string Direccion,string telefono, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime FechaBaja, string Usuario, Int32 Host, Int32 Dni, string Contraseña, string Estado) : base(Id, Nombre, Apellido, Direccion, telefono, Email, FechaAlta, FechaNacimiento, FechaBaja, Usuario, Host, Dni,Contraseña, Estado) 
        {
           
        }

    } 
}

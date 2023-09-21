using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Modelo
{
    public class UsuarioModel
    {

        //// ATRIBUTOS

        //private int _id;
        //private string _nombre;
        //private string _apellido;
        //private string _direccion;
        //private string _telefono;
        //private string _email;
        //private DateTime _fechaNacimiento;
        //private DateTime _fechaAlta;
        //private DateTime _fechaBaja;
        //private string _usuario;
        //private int _host;
        //private int _dni;
        //private string _contraseña;


        //// PROPIEDADES
        //public Guid Id { get => _id; set => _id = value; }
        //public string Nombre { get => _nombre; set => _nombre = value; }
        //public string Apellido { get => _apellido; set => _apellido = value; }
        //public string Direccion { get => _direccion; set => _direccion = value; }
        //public string Telefono { get => _telefono; set => _telefono = value; }
        //public string Email { get => _email; set => _email = value; }
        //public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        //public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        //public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        //public string Usuario { get => _usuario; set => _usuario = value; }
        //public int Host { get => _host; set => _host = value; }
        //public int Dni { get => _dni; set => _dni = value; }
        //public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaBaja { get; set; }
        public string usuario { get; set; }
        public Int32 host { get; set; }
        public Int32 dni { get; set; }
        public string contraseña { get; set; }
        public DateTime fechacontraseña { get; set; }
        public UsuarioModel(Guid Id, string Nombre, string Apellido, string Direccion, string Telefono, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime FechaBaja, string Usuario, Int32 Host, Int32 Dni, string Contraseña)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            direccion = Direccion;
            telefono = Telefono;
            email = Email;
            fechaAlta = FechaAlta;
            fechaNacimiento = FechaNacimiento;
            fechaBaja = FechaBaja;
            usuario = Usuario;
            host = Host;
            dni = Dni;
            contraseña = Contraseña;
            fechacontraseña = DateTime.Today;
        }
    public UsuarioModel()
        {
        }

        public List<UsuarioModel> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public bool Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    } 
}

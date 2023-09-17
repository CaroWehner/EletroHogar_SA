using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class Menu
    {
        public static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        public static void MenuAdm()
        {
            bool CtrlAdm = true;
            do
            {
                Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                Console.WriteLine("1: Gestión de usuarios");
                Console.WriteLine("2: Proveedores");
                Console.WriteLine("3: Productos");
                Console.WriteLine("4: Reportes");
                Console.WriteLine("5: Salir");
                string opcAdm = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcAdm)
                {
                    case "1":
                        bool CtrlG = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta usuario");
                            Console.WriteLine("2: Modificación usuario");
                            Console.WriteLine("3: Baja usuario");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcG = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcG)
                            {
                                case "1":
                                    string inputPerfil;
                                    int perfil = 0;
                                    bool flag;
                                    AltaUsuario alta = new AltaUsuario();
                                    do
                                    {
                                        Console.WriteLine("1- Perfil Administrador");
                                        Console.WriteLine("2- Perfil Supervisor");
                                        Console.WriteLine("3- Perfil Vendedor");
                                        Console.Write("Ingrese el perfil correspondiente para el nuevo usuario:  ");
                                        inputPerfil = Console.ReadLine();
                                        ValidacionesDatos validador = new ValidacionesDatos();
                                        flag = validador.ValidarNumero(inputPerfil, ref perfil, "Perfil");
                                        flag = validador.ValidarTipoNum(ref perfil, "Perfil");
                                    } while (flag == false);

                                    if (perfil == 1)
                                    {
                                        UsuarioModel usuario = new Administrador();
                                        usuario = alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else if (perfil == 2)
                                    {
                                        UsuarioModel usuario = new Supervisores();
                                        usuario = alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else if (perfil == 3)
                                    {
                                        UsuarioModel usuario = new Vendedor();
                                        usuario = alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se pudo dar de alta");
                                    }
                                    break;
                                case "2":
                                    //Ingresar modificación usuario
                                    UsuarioModel usuario1 = new UsuarioModel();
                                    ModificarUsuario mod = new ModificarUsuario();
                                    usuario1 = mod.ModUsuario(usuario1);
                                    break;
                                case "3":
                                    //Ingresar baja usuario
                                    BajaUsuario baja = new BajaUsuario();
                                    UsuarioModel usuario3 = new UsuarioModel();
                                    usuario3 = baja.DarBajaUsuario();
                                    usuario3.estado = "INACTIVO";
                                    //pasar a INACTIVO
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlG = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                                    break;
                            }
                        } while (CtrlG);
                        break;
                    case "2":
                        bool CtrlProv = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta usuario proveedor");
                            Console.WriteLine("2: Modificación usuario proveedor");
                            Console.WriteLine("3: Baja usuario proveedor");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProv = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProv)
                            {
                                case "1":
                                    //Ingresar alta proveedor
                                    break;
                                case "2":
                                    //Ingresar modificación proveedor
                                    break;
                                case "3":
                                    //Ingresar baja proveedor
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProv = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProv);
                        break;
                    case "3":
                        bool CtrlProd = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta producto");
                            Console.WriteLine("2: Modificación producto");
                            Console.WriteLine("3: Baja producto");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProd = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProd)
                            {
                                case "1":
                                    //Ingresar alta producto
                                    break;
                                case "2":
                                    //Ingresar modificación producto
                                    break;
                                case "3":
                                    //Ingresar baja producto
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProd);
                        break;
                    case "4":
                        bool CtrlRep = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Reporte de stock crítico");
                            Console.WriteLine("2: Reporte de ventas por vendedor");
                            Console.WriteLine("3: Reporte de productos más vendido por categoría");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcRep = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcRep)
                            {
                                case "1":
                                    //llamar procedimiento reporte de stock critico
                                    break;
                                case "2":
                                    //llamar procedimiento reporte de ventas
                                    break;
                                case "3":
                                    //llamar procedimiento reporte de productos mas vendidos
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlRep);
                        break;
                    case "5":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        // Console.ReadKey(); - MM comenté para arreglar bug de no mostrar menu
                        CtrlAdm = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        //Console.ReadKey(); - MM comenté para arreglar bug de no mostrar menu
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlAdm);
        }
        public static void MenuSupervisor()
        {
            bool CtrlSup = true;
            do
            {
                Console.WriteLine("Supervisor, seleccione que tarea va a realizar");
                Console.WriteLine("1: Productos");
                Console.WriteLine("2: Devoluciones");
                Console.WriteLine("3: Reportes");
                Console.WriteLine("4: Salir");
                string opcAdm = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcAdm)
                {
                    case "1":
                        bool CtrlProd = true;
                        do
                        {
                            Console.WriteLine("Supervisor, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta producto");
                            Console.WriteLine("2: Modificación producto");
                            Console.WriteLine("3: Baja producto");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProd = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProd)
                            {
                                case "1":
                                    //Ingresar alta producto
                                    break;
                                case "2":
                                    //Ingresar modificación producto
                                    break;
                                case "3":
                                    //Ingresar baja producto
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProd);
                        break;
                    case "2":
                        //Llamar metodo devolucion
                        break;
                    case "3":
                        bool CtrlRep = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Reporte de stock crítico");
                            Console.WriteLine("2: Reporte de ventas por vendedor");
                            Console.WriteLine("3: Reporte de productos más vendido por categoría");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcRep = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcRep)
                            {
                                case "1":
                                    //llamar procedimiento reporte de stock critico
                                    break;
                                case "2":
                                    //llamar procedimiento reporte de ventas
                                    break;
                                case "3":
                                    //llamar procedimiento reporte de productos mas vendidos
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlRep);
                        break;
                    case "4":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        CtrlSup = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlSup);
        }
        public static void MenuVendedor()
        {
            bool CtrlVend = true;
            do
            {
                Console.WriteLine("Vendedor, seleccione que tarea va a realizar");
                Console.WriteLine("1: Venta");
                Console.WriteLine("2: Reporte de ventas por vendedor ");
                Console.WriteLine("3: Salir");
                string opcVend = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcVend)
                {
                    case "1":
                        //Llamar metodo venta
                    case "2":
                        //Llamar reporte
                        break;
                    case "3":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        CtrlVend = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlVend);
        }
        public UsuarioModel BuscarUsuario(string idUsuario)
        {
            idUsuario = Guid.NewGuid().ToString();
            return Menu.usuarios.Find(u => u.usuario == idUsuario);
        }
    }
}
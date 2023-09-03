using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class Menu
    {
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
                            Console.WriteLine("1: Alta usuario supervisor");
                            Console.WriteLine("2: Modificación usuario supervisor");
                            Console.WriteLine("3: Baja usuario supervisor");
                            Console.WriteLine("4: Alta usuario vendedor");
                            Console.WriteLine("5: Modificación usuario vendedor");
                            Console.WriteLine("6: Baja usuario vendedor");
                            Console.WriteLine("7: Volver al menú principal");
                            string opcG = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcG)
                            {
                                case "1":
                                    //Ingresar alta usuario supervisor
                                    break;
                                case "2":
                                    //Ingresar modificación usuario supervisor
                                    break;
                                case "3":
                                    //Ingresar baja usuario supervisor
                                    break;
                                case "4":
                                    //Ingresar alta usuario vendedor
                                    break;
                                case "5":
                                    //Ingresar modificación usuario vendedor
                                    break;
                                case "6":
                                    //Ingresar baja usuario vendedor
                                    break;
                                case "7":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlG = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
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
                        Console.ReadKey();
                        CtrlAdm = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        Console.ReadKey();
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
    }
}
using AccesoDatos.Utilidades;
using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http;

namespace AccesoDatos
{
    public static class ProveedoresDatos
    {
       
        public static List<Proveedores> ListarProveedores()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Proveedores> listadoProveedores = JsonConvert.DeserializeObject<List<Proveedores>>(contentStream);
                return listadoProveedores;
            }
        }
    }
}
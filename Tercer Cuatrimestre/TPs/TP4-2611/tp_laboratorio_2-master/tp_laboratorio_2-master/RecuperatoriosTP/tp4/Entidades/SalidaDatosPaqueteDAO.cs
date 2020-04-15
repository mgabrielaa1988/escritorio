using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesPrincipales
{
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        #region "Metodos"
        /// <summary>
        /// Insert: Encargado de la conexión con la base de datos para poder ingresar un elemento de tipo Paquete a la base de datos, en caso de algun error, lanzará una excepcion.
        /// Si se cambia de maquina, se recomienda cambiar la configuracion de propiedades debido al cambio de servidor (más que nada por desconocer qué servidor se usará para testear este programa)
        /// </summary>
        /// <param name="p">Elemento de clase Paquete se que intentará ingresar a la base de datos</param>
        /// <returns>Boolean que indica si se logró agregar el elemento a la base de datos</returns>
        public static bool Insert(Paquete p)
        {
            Boolean retorno = false;

            try
            {
                PaqueteDAO._conexion.Open();
                PaqueteDAO._comando = new SqlCommand("INSERT into [correo-sp-2017].[dbo].[Paquetes]([direccionEntrega],[trackingID],[alumno]) VALUES ('" + p.DireccionEntrega + "','" + p.TrackingID + "','Segado Emilio')", PaqueteDAO._conexion);

                int registrosAfectados = PaqueteDAO._comando.ExecuteNonQuery();

                if (registrosAfectados > 0)
                { retorno = true; }
            }
            catch (Exception e)
            { throw e; }
            finally
            { PaqueteDAO._conexion.Close(); }

            return retorno;
        }

        /// <summary>
        /// Constructor por defecto encargado de configurar la conexión con el servidor de base de datos
        /// </summary>
        static PaqueteDAO()
        { PaqueteDAO._conexion = new SqlConnection(ClasesPrincipales.Properties.Settings.Default.conexion); }
        #endregion
    }
}

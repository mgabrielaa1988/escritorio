using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        /// <summary>
        /// Constructor por defecto encargado de configurar la conexión con el servidor de base de datos
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO._conexion = new SqlConnection(Entidades.Properties.Settings.Default.Conexion);
        }

        /// <summary>
        /// Ejecuta un comando INSERT de los datos del paquete a una base de datos.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            try
            {
                PaqueteDAO._comando.CommandText = string.Format("INSERT INTO Paquetes(direccionEntrega, trackingID, alumno) values('{0}', '{1}', '{2}')",
                    p.DireccionEntrega, p.TrackingID, "Gabriela.Aragon.2A");
                PaqueteDAO._conexion.Open();
                PaqueteDAO._comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                PaqueteDAO._conexion.Close();
            }
            return retorno;
        }
    }
}

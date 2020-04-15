using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.Data;

namespace ConsoleApp1
{
    public class Televisor
    {
        int codigo;
        string marca;
        double precio;
        int pulgadas;
        string pais;

        public Televisor(int codigo, string marca, double precio, int pulgadas, string pais)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }

        public Televisor() { }

        public bool Insertar()
        {
            bool retorno = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("INSERT INTO Televisores values({0},'{1}',{2},{3},'{4}')",this.codigo,this.marca,this.precio,this.pulgadas,this.pais);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;    
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                retorno = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public static bool Modificar(Televisor televisor)
        {
            bool retorno = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("UPDATE Televisores SET marca='{0}',precio={1},pulgadas={2},pais='{3}') WHERE codigo = {4}",televisor.marca,televisor.precio,televisor.pulgadas,televisor.marca, televisor.codigo);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public static bool Borrar(Televisor televisor)
        {
            bool retorno = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("DELETE Televisores WHERE codigo = {0}", televisor.codigo);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }
    }
}

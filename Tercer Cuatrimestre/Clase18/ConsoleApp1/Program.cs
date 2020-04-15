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
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion); 
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Televisores";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            List<Televisor> televisores = new List<Televisor>();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0] + "--" + dataReader[1] + "--" + dataReader[2] + "--" + dataReader[3] + "--" + dataReader[4] + "--");
                Televisor t = new Televisor(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetDouble(2), dataReader.GetInt32(3), dataReader.GetString(4));
                //televisores.Add( new Televisor((int)dataReader[0],dataReader[1].ToString(),(double)dataReader[2],(int)dataReader[3],dataReader[4].ToString()));
                televisores.Add(t);
            }
            connection.Close();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Televisor>));
            XmlTextWriter tw= new XmlTextWriter(@"Televisores.xml",Encoding.UTF32);
            XmlTextReader tr = new XmlTextReader(@"Televisores.xml");
            serializer.Serialize(tw, televisores);
            tw.Close();

            List<Televisor> lista = (List<Televisor>)serializer.Deserialize(tr);
            connection.Close();
            Console.ReadLine();

            connection.Open();
            dataReader = command.ExecuteReader();
            DataTable table = new DataTable("Televisores");
            table.Load(dataReader);

            table.WriteXmlSchema(@"Televisores_Esquema.xml");
            table.WriteXml(@"Televisores_Datos.xml");

            DataTable dataTable = new DataTable();
            dataTable.ReadXmlSchema(@"Televisores_Esquema.xml");
            dataTable.WriteXml(@"Televisores_Datos.xml");

            connection.Close();
            Console.ReadLine();
        }
    }
}

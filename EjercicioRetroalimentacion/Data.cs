using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRetroalimentacion
{
    public class Data
    {
        public string ConnectionString
        {
            get
            {
                return "Data Source=CC1PC16-17;Initial Catalog=AdventureWorks2016;Integrated Security=True";
            }
        }

        public SqlConnection getConnection()
        {
            var conexion = new SqlConnection(ConnectionString);
                conexion.Open();
                return conexion;
            
        }

        public Customers obtenertodos()
        {
            using (var conexion = getConnection() )
            {
                String Otodos = "";
                Otodos = Otodos + "SELECT [CategoryID] " + "\n";
                Otodos = Otodos + "      ,[CategoryName] " + "\n";
                Otodos = Otodos + "      ,[Description] " + "\n";
                Otodos = Otodos + "      ,[Picture] " + "\n";
                Otodos = Otodos + "  FROM [dbo].[Categories]";



                using (var command = new SqlCommand(Otodos, conexion))
                {
                    //lisas customer <Customers = new list
                    //> 
                }
            }
        }
    }
}

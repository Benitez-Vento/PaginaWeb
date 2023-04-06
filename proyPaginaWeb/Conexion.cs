using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace proyPaginaWeb
{
    public class Conexion
    {
        //Propiedades

        //Metodos
        public SqlConnection conectarToBdMarketAzure()
        {
            /* 
             * "Data Source=mgarcia202310.database.windows.net;Initial Catalog=bdmarket;User ID=Administrador;Password=Pa$$w0rd"  
            */

            //Instanciar el generador de cadenas de conexion
            SqlConnectionStringBuilder generadorCadenas = new SqlConnectionStringBuilder();
            //Enviar los parametros de conexion
            generadorCadenas.DataSource = "mgarcia202310.database.windows.net"; //servidor de BD
            generadorCadenas.InitialCatalog = "bdmarket"; //Base de Datos
            generadorCadenas.UserID = "Administrador"; //Usuario
            generadorCadenas.Password = "Pa$$w0rd"; //Clave
            //Obtener la cadena generada
            string cadena = generadorCadenas.ConnectionString;

            //Generar una conexion a la BD
            SqlConnection conexion = new SqlConnection(cadena);

            //Retornar la conexion
            return conexion;
        }

    }
}
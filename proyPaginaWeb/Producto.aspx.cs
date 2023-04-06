using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace proyPaginaWeb
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Instanciar la clase Conexion
            Conexion conexion = new Conexion();

            //Creando el SQL Connection a bdMarket en Azure
            SqlConnection cnx = conexion.conectarToBdMarketAzure();

            //Abrir la conexion
            cnx.Open();

            //Crear un comando SQL
            SqlCommand cmd = cnx.CreateCommand();

            //Establecer el tipo de comando
            cmd.CommandType = CommandType.Text;

            //Establecer la instruccion SQL
            cmd.CommandText = "select * from producto where descripcion like '%'+ @valor +'%';";

            //Transferir un valor al parametro
            cmd.Parameters.AddWithValue("@valor", txtValorBuscar.Text);

            //Instanciar un DataAdapter
            SqlDataAdapter daProducto = new SqlDataAdapter();

            //Asignar el comando SQL al DataAdapter
            daProducto.SelectCommand = cmd;

            //Instanciar un DataTable
            DataTable dtProducto = new DataTable();

            //Llenar de registros en el DataTable
            daProducto.Fill(dtProducto);

            //Mostrar en los registros en el DGV
            gvProductos.DataSource = dtProducto;

            //*** Para el GridView ***
            gvProductos.DataBind();

            //Cerrar la conexion
            cnx.Close();

        }
    }
}
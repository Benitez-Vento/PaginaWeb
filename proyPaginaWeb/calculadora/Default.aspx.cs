using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyPaginaWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //Leer los valores de las cajas de texto
            double n1 = Convert.ToDouble(txtNum1.Text);
            double n2 = Convert.ToDouble(txtNum2.Text);

            //Leer el operador de la lista
            string ope = lstOperador.Text;

            //Operar
            double res = 0;
            if(ope=="+")
            {
                res = n1 + n2;
            }else if (ope == "-")
            {
                res= n1 - n2;
            }else if(ope == "x")
            {
                res = n1 * n2;
            }else if (ope == "/")
            {
                res = n1 / n2;
            }
            //Imprimir el resultado
            txtResultado.Text = res.ToString();
        }
    }
}
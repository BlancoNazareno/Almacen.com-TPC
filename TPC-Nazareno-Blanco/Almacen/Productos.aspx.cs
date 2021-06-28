using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;                            /*ver porqué no conecta*/

namespace Almacen
{
    public partial class Productos : System.Web.UI.Page
    {
        public List<Producto> ListaProductos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio Producto = new ProductoNegocio();


            try
            {
                ListaProductos = Producto.Listar();

                Session.Add("ListaProductos", ListaProductos); 
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());  
                Response.Redirect("Error.aspx");
            }
        }
    }
}
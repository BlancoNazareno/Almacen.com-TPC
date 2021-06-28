using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Negocio
{
    class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Producto> lista = new List<Producto>();
            datos.setearQuery("Select P.ID, P.Descripcion, M.ID as IDMarca, M.Descripcion as Marca, Prov.ID as IDProveedor, Prov.Descripcion as Proveedor, P.Precio_Compra, P.Precio_Venta, P.Stock_Minimo" +
            "from PRODUCTO as P" +
            "join MARCA as M on M.ID = P.ID_Marca" +
            "join PROVEEDOR as Prov on Prov.ID = P.ID_Proveedor");

            try
            {
                datos.ejecutarLector();
                datos.lector = datos.comando.ExecuteReader();

                while (datos.lector.Read())
                {


                    Producto aux;
                    aux = new Producto();
                    aux.ID = (string)datos.lector["ID"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.ID = (string)datos.lector["IDMarca"];
                    aux.Marca.Descripcion = (string)datos.lector["Marca"];

                    aux.Proveedor = new Proveedor();
                    aux.Proveedor.ID = (string)datos.lector["IDProveedor"];
                    aux.Proveedor.Descripcion = (string)datos.lector["Proveedor"];

                    aux.PrecioCompra = (SqlMoney)datos.lector["Precio_Compra"];
                    aux.PrecioVenta = (SqlMoney)datos.lector["Precio_Venta"];
                    aux.StockMinimo = (int)datos.lector["Stock_Minimo"];

                    lista.Add(aux);

                }

                datos.lector.Close();
                datos.conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public void Agregar (Producto nuevo)
        {
          
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearQuery("Insert into PRODUCTO(ID, Descripcion, ID_Marca, ID_Proveedor, Precio_Compra, Precio_Venta, Stock_Minimo) values (@ID, @Descripcion, @IDMarca, @IDProveedor, @PrecioCompra, @PrecioVenta, @StockMinimo)"); 
                                                               
                datos.agregarParametro("@ID", nuevo.ID);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@IDMarca", nuevo.Marca.ID);
                datos.agregarParametro("@IDProveedor", nuevo.Proveedor.ID);
                datos.agregarParametro("@PrecioCompra", nuevo.PrecioCompra);
                datos.agregarParametro("@PrecioVenta", nuevo.PrecioVenta);
                datos.agregarParametro("@StockMinimo", nuevo.StockMinimo);

                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Modificar (Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update PRODUCTO set Descripcion = @Descripcion, ID_Marca = @IDMarca, ID_Proveedor = @IDProveedor, Precio_Compra = @PrecioCompra, Precio_Venta = @PrecioVenta, Stock_Minimo = @StockMinimo where ID = @ID");


                datos.agregarParametro("@ID", producto.ID);
                datos.agregarParametro("@Descripcion", producto.Descripcion);
                datos.agregarParametro("@IDMarca", producto.Marca.ID);
                datos.agregarParametro("@IDProveedor", producto.Proveedor.ID);
                datos.agregarParametro("@PreciCompra", producto.PrecioCompra);
                datos.agregarParametro("@PrecioVenta", producto.PrecioVenta);
                datos.agregarParametro("@StockMinimo", producto.StockMinimo);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Delete PRODUCTO where ID = @ID");

                datos.agregarParametro("@ID", producto.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

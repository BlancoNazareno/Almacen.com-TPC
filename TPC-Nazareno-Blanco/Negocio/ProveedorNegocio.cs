using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    class ProveedorNegocio
    {
        public List<Proveedor> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Proveedor> lista = new List<Proveedor>();
            datos.setearQuery("Select ID, Descripcion from PROVEEDOR");

            try
            {
                datos.ejecutarLector();
                datos.lector = datos.comando.ExecuteReader();

                while (datos.lector.Read())
                {

                    Proveedor aux;
                    aux = new Proveedor();
                    aux.ID = (string)datos.lector["ID"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

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

        public void Agregar(Proveedor nuevo)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearQuery("Insert into PROVEEDOR(ID, Descripcion) values (@ID, @Descripcion)");

                datos.agregarParametro("@ID", nuevo.ID);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Modificar(Proveedor proveedor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update PROVEEDOR set Descripcion = @Descripcion");


                datos.agregarParametro("@ID", proveedor.ID);
                datos.agregarParametro("@Descripcion", proveedor.Descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Proveedor proveedor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Delete PROVEEDOR where ID = @ID");

                datos.agregarParametro("@ID", proveedor.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

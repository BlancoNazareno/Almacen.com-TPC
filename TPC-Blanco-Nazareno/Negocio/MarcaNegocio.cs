using System;
using System.Collections.Generic;
using System.Text;
using Dominio;


namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marca> lista = new List<Marca>();
            datos.setearQuery("Select ID, Descripcion from MARCA");

            try
            {
                datos.ejecutarLector();
                datos.lector = datos.comando.ExecuteReader();

                while (datos.lector.Read())
                {


                    Marca aux;
                    aux = new Marca();
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

        public void Agregar(Marca nuevo)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearQuery("Insert into MARCA(ID, Descripcion) values (@ID, @Descripcion)");

                datos.agregarParametro("@ID", nuevo.ID);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update MARCA set Descripcion = @Descripcion");


                datos.agregarParametro("@ID", marca.ID);
                datos.agregarParametro("@Descripcion", marca.Descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Delete MARCA where ID = @ID");

                datos.agregarParametro("@ID", marca.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}


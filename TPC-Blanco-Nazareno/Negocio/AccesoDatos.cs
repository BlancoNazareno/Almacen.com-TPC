using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class AccesoDatos
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; }
        public SqlCommand comando { get; set; }

        public AccesoDatos()
        {
            conexion = new SqlConnection("data source = .\\SQLEXPRESS; initial catalog = ALMACEN_DB; integrated security = sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                cerrarConexion();
            }

        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
        internal void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }

            finally
            {
                cerrarConexion();
            }
        }

    }

}
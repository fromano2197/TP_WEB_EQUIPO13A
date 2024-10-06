using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ClienteNegocio
    {
        public void agregar(Cliente nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Clientes(Documento, Nombre, Apellido, Email, Direccion, Ciudad,CP) values (@Dni,@Nombre,@Apellido,@Email,@Direccion,@Ciudad,@CodigoPostal)");
                datos.setearParametro("@Dni", nuevo.Dni);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Direccion", nuevo.Direccion);
                datos.setearParametro("@Ciudad", nuevo.Ciudad);
                datos.setearParametro("@CodigoPostal", nuevo.CodigoPostal);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                datos.cerrarConexion();

            }
        }
    }
}

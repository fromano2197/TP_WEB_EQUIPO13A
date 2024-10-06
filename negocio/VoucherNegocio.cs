using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        public bool buscarVoucher(string CodigoVoucherBuscado)
        {
            AccesoDatos datos = new AccesoDatos();



            try
            {
                datos.setearProcedimiento("storedBuscarVoucher");
                datos.ejecutarLectura();


                Voucher aux = new Voucher();
                while (datos.Lector.Read())
                {

                    aux.CodigoVaucher = datos.Lector["CodigoVoucher"].ToString();

                    if (!(datos.Lector["IdArticulo"] is DBNull))
                    {
                        aux.CodigoArticulo = (int)datos.Lector["IdArticulo"];
                    }
                    else { aux.CodigoArticulo = 0; }

                    if (aux.CodigoVaucher == CodigoVoucherBuscado && aux.CodigoArticulo == 0)
                    {
                        return true;
                    }


                }
                return false;
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
        public Cliente buscarUltimoCliente()
        {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setConsulta("select top 1 * from Clientes order by Id desc");
                datos.ejecutarLectura();

                Cliente aux = new Cliente();
                while (datos.Lector.Read())
                {

                    aux.id = (int)datos.Lector["Id"];



                }
                return aux;
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

        public void ActualizarVoucher(Voucher voucher)
        {
            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    string consultaVoucher = "UPDATE Vouchers SET IdCliente = @IdCliente,FechaCanje = @FechaCanje, IdArticulo = @IdArticulo WHERE CodigoVoucher = @CodigoVoucher;";

                    datos.setConsulta(consultaVoucher);
                    datos.setearParametro("@CodigoVoucher", voucher.CodigoVaucher);
                    datos.setearParametro("@IdCliente", voucher.CodigoCliente);
                    datos.setearParametro("@FechaCanje", voucher.FechaCanje);
                    datos.setearParametro("@IdArticulo", voucher.CodigoArticulo);

                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

    }
}



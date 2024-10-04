using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        public bool buscarVoucher(string CodigoVoucherBuscado) {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearProcedimiento("storedBuscarVoucher");
                datos.ejecutarLectura();

                Voucher aux = new Voucher();
                while (datos.Lector.Read())
                {

                    aux.CodigoVaucher = datos.Lector["CodigoVoucher"].ToString();
                    if(aux.CodigoVaucher == CodigoVoucherBuscado) { return true;
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
    }
    }


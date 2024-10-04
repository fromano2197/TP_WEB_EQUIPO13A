

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using System.Diagnostics.Eventing.Reader;


namespace Web_App
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string voucherBuscado = txtVoucher.Text;
                VoucherNegocio voucher = new VoucherNegocio();
                if (voucher.buscarVoucher(voucherBuscado)) Response.Redirect("ArticuloLista.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
           
        }
    }
}
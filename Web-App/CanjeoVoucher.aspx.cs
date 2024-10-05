﻿using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App
{
    public partial class CanjeoVoucher : System.Web.UI.Page
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
                if (voucher.buscarVoucher(voucherBuscado)) { Response.Redirect("ArticuloLista.aspx", false); }
                else
                {
                    Response.Redirect("errorVoucher.aspx", false);
                };

                
            }

            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
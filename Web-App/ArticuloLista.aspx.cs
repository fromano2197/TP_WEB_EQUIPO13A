﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;


namespace Web_App
{
    public partial class ArticuloLista : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        public string voucher;
        public int codArticulo;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            voucher = Session["voucher"] != null ? Session["voucher"].ToString() : "";
            
            if (!IsPostBack)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                ListaArticulo = negocio.listarConSp();
                repRepeater.DataSource = ListaArticulo;
                repRepeater.DataBind();
            }
        }
        protected void VerDetalle_Click(object sender, EventArgs e)
        {
            
           
            LinkButton btn = (LinkButton)sender;
            string articuloId = btn.CommandArgument;
            
            
            Response.Redirect("Detalle.aspx");
        }

    }
}
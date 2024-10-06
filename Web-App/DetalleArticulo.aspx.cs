using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idArticuloString = Request.QueryString["id"];
                int idArticulo;

                if (!string.IsNullOrEmpty(idArticuloString) && int.TryParse(idArticuloString, out idArticulo))
                {
                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    Articulo articulo = articuloNegocio.listar(idArticulo);

                    if (articulo != null)
                    {
                        lblCodigo.Text = articulo.Codigo;
                        lblNombre.Text = articulo.Nombre;
                        lblDescripcion.Text = articulo.Descripcion;
                        lblMarca.Text = articulo.Marca.Descripcion;
                        lblCategoria.Text = articulo.Categoria.Descripcion;
                        lblPrecio.Text = articulo.Precio.ToString("C");

                        rptImagenes.DataSource = articulo.Imagenes;
                        rptImagenes.DataBind();
                    }
                    else
                    {
                        lblNombre.Text = "Artículo no encontrado.";
                    }
                }
                else
                {
                    lblNombre.Text = "Id de artículo no válido.";
                }
            }
        }


    }
}
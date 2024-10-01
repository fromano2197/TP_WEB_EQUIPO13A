using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; Integrated Security=True;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id IdArticulo, A.Codigo, A.Nombre, A.Descripcion, M.Id IdMarca, M.Descripcion as Marca, C.Id IdCategoria, ISNULL(C.Descripcion, 'Sin categoría') AS Categoria, I.ImagenUrl, A.Precio " +
                              "from ARTICULOS A " +
                              "left join MARCAS M on A.IdMarca = M.Id " +
                              "left join CATEGORIAS C on A.IdCategoria = C.Id " +
                              "left join IMAGENES I ON A.Id = I.IdArticulo";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

               while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    if (lector["IdCategoria"] is DBNull)
                    {
                        aux.Categoria.Id = -1;
                    } else
                    {
                        aux.Categoria.Id = (int)lector["IdCategoria"]; 
                    }
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.UrlImagen = new Imagen();
                    if (!(lector["ImagenUrl"] is DBNull)) {

                        aux.UrlImagen.ImagenUrl = (string)lector["ImagenUrl"];
                    }
                    
                    aux.Precio = (Decimal)lector["Precio"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("delete from ARTICULOS where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagen = new ImagenNegocio();

            try
            {
                datos.setConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (' " + nuevo.Codigo + "','" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();

                if(nuevo.UrlImagen.ImagenUrl != null)
                {

                    imagen.agregar(nuevo.UrlImagen.ImagenUrl);

                }
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select distinct A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, ISNULL(C.Descripcion, 'Sin categoría') AS Categoria, I.ImagenUrl, A.Precio " +
                              "from ARTICULOS A " +
                              "left join MARCAS M on A.IdMarca = M.Id " +
                              "left join CATEGORIAS C on A.IdCategoria = C.Id " +
                              "left join IMAGENES I ON A.Id = I.Id WHERE ";

                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += " A.Precio >" + filtro;
                                break;
                            case "Menor a":
                                consulta += "A.Precio <" + filtro;
                                break;
                            default:
                                consulta += "A.Precio =" + filtro;
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Nombre  like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Descripcion  like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion  like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "M.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion  like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "C.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    default:
                        break;
                }
                datos.setConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = new Imagen();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {

                        aux.UrlImagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.Precio = (Decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Articulo articulo)
        {
            ActualizarArticulo(articulo);

            if (articulo.UrlImagen != null)
            {
                ActualizarImagen(articulo.Id, articulo.UrlImagen.ImagenUrl);
            }
        }

        private void ActualizarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    string consultaArticulo = "UPDATE ARTICULOS  SET Codigo = @Codigo,Nombre = @Nombre,Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria,Precio = @Precio WHERE Id = @Id;";

                    datos.setConsulta(consultaArticulo);
                    datos.setearParametro("@Codigo", articulo.Codigo);
                    datos.setearParametro("@Nombre", articulo.Nombre);
                    datos.setearParametro("@Descripcion", articulo.Descripcion);
                    datos.setearParametro("@IdMarca", articulo.Marca.Id);
                    datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                    datos.setearParametro("@Precio", articulo.Precio);
                    datos.setearParametro("@Id", articulo.Id);

                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void ActualizarImagen(int articuloId, string imagenUrl)
        {
            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    string consultaImagen = "UPDATE IMAGENES SET ImagenUrl = @ImagenUrl  WHERE Id = @Id;";

                    datos.setConsulta(consultaImagen);
                    datos.setearParametro("@ImagenUrl", imagenUrl ?? (object)DBNull.Value);
                    datos.setearParametro("@Id", articuloId);

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

    


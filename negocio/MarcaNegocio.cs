﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
			List<Marca> lista = new List<Marca>();
			AccesoDatos datos = new AccesoDatos();


			try
			{
				datos.setConsulta("Select Id, Descripcion from MARCAS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Marca aux = new Marca();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					lista.Add(aux);
					
				}
				return lista;
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

        public void agregarMarca(Marca descripcionMarca)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.setConsulta("INSERT INTO MARCAS (descripcion) VALUES (@descripcion)");
                datos.setearParametro("@descripcion", descripcionMarca.Descripcion);
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

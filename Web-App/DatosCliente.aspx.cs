﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App
{
    public partial class DatosCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                litAlerta.Text = string.Empty;
               
                if (string.IsNullOrWhiteSpace(txtDni.Text) || !Regex.IsMatch(txtDni.Text, @"^\d+$"))
                {
                    MostrarMensaje("El DNI es obligatorio y debe ser un número válido.");
                    return;
                }

                int dni;
                if (!int.TryParse(txtDni.Text, out dni) || dni <= 0)
                {
                    MostrarMensaje("El DNI debe ser un número mayor que cero.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MostrarMensaje("El nombre es obligatorio.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MostrarMensaje("El apellido es obligatorio.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                {
                    MostrarMensaje("El email es obligatorio y debe tener un formato válido.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MostrarMensaje("La dirección es obligatoria.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtCiudad.Text))
                {
                    MostrarMensaje("La ciudad es obligatoria.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text) || !Regex.IsMatch(txtCodigoPostal.Text, @"^\d+$"))
                {
                    MostrarMensaje("El código postal es obligatorio y debe ser un número válido.");
                    return;
                }

                Cliente nuevo = new Cliente();
                ClienteNegocio negocio = new ClienteNegocio();

                nuevo.Dni=txtDni.Text;
                nuevo.Nombre=txtNombre.Text;
                nuevo.Apellido=txtApellido.Text;
                nuevo.Email=txtEmail.Text;
                nuevo.Direccion=txtDireccion.Text;
                nuevo.Ciudad=txtCiudad.Text;
                nuevo.CodigoPostal=int.Parse(txtCodigoPostal.Text);

                negocio.agregar(nuevo);

                litAlerta.Text = @"<div class='alert alert-success' role='alert'>
                          <h4 class='alert-heading'>¡Datos cargados con éxito!</h4>
                          <p>¡Gracias por completar tus datos y canjear tu voucher! Hemos registrado tu información</p>
                          <hr>
                          <p class='mb-0'>Si tienes alguna pregunta o necesitas asistencia, no dudes en contactarnos. ¡Esperamos que disfrutes de tu canje!</p>
                      </div>";

                ClientScript.RegisterStartupScript(this.GetType(), "RedirectionScript", "setTimeout(function(){ window.location.href = 'Default.aspx'; }, 3000);", true);
            }
            catch (Exception Ex)
            {
                MostrarMensaje("Ocurrió un error: " + Ex.Message);
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            litAlerta.Text = $"<div class='alert alert-warning'>{mensaje}</div>";
        }
    }

}
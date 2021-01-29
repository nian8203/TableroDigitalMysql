using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace TableroDigitalV001
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            LoginClass lc = new LoginClass();
            Personas p = new Personas();

            string correo = txtCorreo.Text;
            string password = txtPassword.Text;

            if (correo == "" || password == "")
            {
                Response.Write("<script>alert("+"'Todos los campos son requeridos'"+");</script>");
            }
            else if (lc.validarCorreo(correo, password))
            {
                Response.Write("<script>alert(" + "'Bienvenido'" + ");</script>");
                Response.Redirect("~/pages/home.aspx");
                
            }
            else 
            {
                txtPassword.Focus();
                Response.Write("<script>alert(" + "'Datos incorrectos'" + ");</script>");
            }




            //AdministrarDatos ad = new AdministrarDatos();
            //string nombre = txtCorreo.Text;
            //string id = txtPassword.Text;

            //if (nombre == "" || id == "")
            //{
            //    Response.Write(" <script>alert(" + "'Debe llenar todos los campos'" + ")</script>");
            //}
            //else
            //if (ad.logeadoNombre(nombre) && ad.logeadoId(id))
            //{
            //    Response.Redirect("~/pages/home.aspx");
            //}
            //else
            //{
            //    Response.Write(" <script>alert(" + "'Usuario o Contraseña Incorrecto'" + ")</script>");
            //    txtCorreo.Text = "";
            //}

        }
    }
}
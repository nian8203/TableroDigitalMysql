using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace TableroDigitalV001.pages
{
    public partial class home : System.Web.UI.Page
    {
        AdministrarDatos ad = new AdministrarDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ValidarSession();
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            List<Alumnos> imprimirDatos = ad.ListarAlumnos();
            gvListarAlumnos.DataSource = imprimirDatos;
            gvListarAlumnos.DataBind();
        }

        protected void BtnListarP_Click(object sender, EventArgs e)
        {
            List<Personas> imprimirDatos = ad.ListarPersonas();
            gvListarPersonas.DataSource = imprimirDatos;
            gvListarPersonas.DataBind();
        }

        private void ValidarSession()
        {
            if (Session["usuarioEncontrado"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}
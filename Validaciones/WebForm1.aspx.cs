using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validaciones
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string concatenarNombre()
        {
            string nombreCompleto;
            nombreCompleto = TextBox1.Text + " " + TextBox2.Text;
            return nombreCompleto.ToUpper();
        }

        private string concatenarPerfil()
        {
            string perfilCompleto="";
            if (CheckBox1.Checked)
            {
                perfilCompleto += CheckBox1.Text + " ";
            }
            if (CheckBox2.Checked)
            {
                perfilCompleto +=CheckBox2.Text + " ";
            }
            if (CheckBox3.Checked)
            {
                perfilCompleto += CheckBox3.Text + "";
            }
            return perfilCompleto;
        }

        private void crearCampoOcultoNombre (string nombre)
        {
            ClientScriptManager campo = Page.ClientScript;
            campo.RegisterHiddenField("OcultoNombre", nombre);
        }

        private void crearCampoOcultoPerfil (string perfil)
        {
            ClientScriptManager campo = Page.ClientScript;
            campo.RegisterHiddenField("OcultoPerfil", perfil);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            nombreCompleto.InnerHtml = "<br><b>" + concatenarNombre() + "</b>";
            perfilCompleto.InnerHtml = "<b>" + concatenarPerfil() + "</b>";

            crearCampoOcultoNombre(concatenarNombre());
            crearCampoOcultoPerfil(concatenarPerfil());

            Button1.Text = "oCULTOS";
      
        }
    }
}
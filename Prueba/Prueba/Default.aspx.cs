using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CRUD_Sencillo
{
    public partial class Default : System.Web.UI.Page
    {
        Registro reg = new Registro();
        string html = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (reg.Consultar().Rows.Count > 0)
            {
                html += "<table class='table table-striped table-bordered'>";
                html += "<thead><tr><td>Nombre</td><td>Apellidos</td><td>email</td><td>sexo</td></tr></thead>";
                html += "<tbody>";
                foreach (DataRow dbRow in reg.Consultar().Rows)
                {
                    html += "<tr>";
                    html += "<td>" + dbRow["Nombre"].ToString() + "</td>";
                    html += "<td>" + dbRow["Apellidos"].ToString() + "</td>";
                    html += "<td>" + dbRow["email"].ToString() + "</td>";
                    html += "<td>" + dbRow["sexo"].ToString() + "</td>";
                    html += "</tr>";
                }
                html += "</tbody>";
                html += "</table>";
            }
            else
            {
                html += "<table class='table table-striped table-bordered'>";
                html += "<tr><td>No hay registros</td></tr>";
                html += "</table>";
            }
            Literal1.Text = html;
            CmbRegistro.DataSource = reg.Consultar();
            CmbRegistro.DataTextField = "Nombre";
            CmbRegistro.DataValueField = "Nombre";
            CmbRegistro.DataBind();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCiudad.Text != "" & TxtNombre.Text != "" & TxtTelefono.Text != "" & TxtCiudad0.Text != "" & TxtCiudad1.Text != "")
            {
                if (reg.Insertar(TxtNombre.Text, TxtTelefono.Text, TxtCiudad.Text, TxtCiudad0.Text, TxtCiudad1.Text))
                {
                    LblGuardar.Text = "El registro se guardo correctamente";
                    TxtCiudad.Text = "";
                    TxtTelefono.Text = "";
                    TxtNombre.Text = "";
                    TxtCiudad0.Text = "";
                    TxtCiudad1.Text = "";
                }
                else
                {
                    LblGuardar.Text = "El registro no se pudo guardar";
                }
            }
            else
            {
                LblGuardar.Text = "Por favor completa los campos";
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CmbRegistro.Text != "")
            {
                if (reg.Eliminar(CmbRegistro.Text))
                {
                    LblEliminar.Text = "El registro se elimino correctamente";
                    CmbRegistro.DataSource = reg.Consultar();
                    CmbRegistro.DataTextField = "Nombre";
                    CmbRegistro.DataValueField = "Nombre";
                    CmbRegistro.DataBind();
                }
                else
                {
                    LblEliminar.Text = "El registro no se pudo eliminar";
                }
            }
        }
    }
}
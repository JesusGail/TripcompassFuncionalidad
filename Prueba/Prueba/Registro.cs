using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CRUD_Sencillo
{
    public class Registro
    {
        bool ejecuto;
        BaseDato bd = new BaseDato();

        public DataTable Consultar()
        {
            DataTable dt;
            bd.Conectar();
            bd.CrearComando("SELECT * FROM Guia");
            dt = bd.EjecutarDataTable();
            bd.Desconectar();
            return dt;
        }

        public bool Insertar(string nom, string ape, string em, string sex,string pass)
        {
            bd.Conectar();
            bd.CrearComando("INSERT INTO Guia(Nombre,Apellidos,email,sexo,contrasena) VALUES(@nom,@ape,@em,@sex,@pass);");
            bd.AsignarParametro("@nom", SqlDbType.VarChar, nom);
            bd.AsignarParametro("@ape", SqlDbType.VarChar, ape);
            bd.AsignarParametro("@em", SqlDbType.VarChar, em);
            bd.AsignarParametro("@sex", SqlDbType.VarChar, sex);
            bd.AsignarParametro("@pass", SqlDbType.VarChar, pass);
            if (bd.EjecutarConsulta() > 0)
            {
                ejecuto = true;
            }
            else
            {
                ejecuto = false;
            }
            return ejecuto;
        }

        public bool Eliminar(string nom)
        {
            bd.Conectar();
            bd.CrearComando("DELETE FROM Guia WHERE Nombre = @nom;");
            bd.AsignarParametro("@nom", SqlDbType.VarChar, nom);
            if (bd.EjecutarConsulta() > 0)
            {
                ejecuto = true;
            }
            else
            {
                ejecuto = false;
            }
            return ejecuto;
        }
    }
}
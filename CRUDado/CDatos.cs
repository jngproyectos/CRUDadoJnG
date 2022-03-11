using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUDado
{
    public class CDatos
    {
        public DataSet selectPersona()
        {
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new
                        SqlCommand("spPersona", Conexion))
                    {
                        Conexion.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new
                            SqlParameter("@Action", "R"));
                        da.SelectCommand = cmd;
                        da.Fill(ds, "Persona");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return ds;
            }
        }
        public void CRUDPersona(CEntidad pEntidad, string pAction)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using(SqlCommand cmd = new
                        SqlCommand("spPersona", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new
                            SqlParameter("@Action", pAction));
                        if (pAction == "C")
                        {
                            cmd.Parameters.Add(new
                                SqlParameter("@Nom", pEntidad.Nombre));
                            cmd.Parameters.Add(new
                               SqlParameter("@Ape", pEntidad.Apellido));
                            cmd.Parameters.Add(new
                               SqlParameter("@Cor", pEntidad.Correo));
                        }
                        else if (pAction == "U")
                        {
                            cmd.Parameters.Add(new
                               SqlParameter("@Id", pEntidad.Id));
                            cmd.Parameters.Add(new
                                SqlParameter("@Nom", pEntidad.Nombre));
                            cmd.Parameters.Add(new
                               SqlParameter("@Ape", pEntidad.Apellido));
                            cmd.Parameters.Add(new
                               SqlParameter("@Cor", pEntidad.Correo));
                        }
                        else if (pAction == "D")
                        {
                            cmd.Parameters.Add(new
                               SqlParameter("@Id", pEntidad.Id));
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

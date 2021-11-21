using COBRANZA.AdminDB;
using COBRANZA.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COBRANZA.CLIENTES
{
    public class TAccesoDatosClientes
    {
        //Constuir un objeto e intanciarlo
        TModelClientes objCliente = new TModelClientes();
        TParametrosdeConexion objParamsql = new TParametrosdeConexion();
        //Constructor

        public TAccesoDatosClientes()
        {

        }

        public DataTable Consultar(int Id)
        {
            using (SqlConnection objCon = new SqlConnection(objParamsql.getStringCon()))
            {
                try
                {
                    objCon.Open();
                    SqlCommand query = new SqlCommand($"select * from CLIENTES where ID = {Id}");
                    DataTable dtClientes = new DataTable();
                    objCon.Close();
                    if (dtClientes.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in dtClientes.Rows)
                        {
                            objCliente.Id = Convert.ToInt32(Fila["ID"].ToString());
                            objCliente.Identidad = Fila["IDENTIDAD"].ToString();
                            objCliente.Direccion = Fila["DIRECCION"].ToString();
                            objCliente.Telefono = Fila["TELEFONO"].ToString();
                            objCliente.Correo = Fila["CORREO"].ToString();
                            objCliente.Municipio = Fila["MUNICIPIO"].ToString();
                            objCliente.UsuarioCreacion = Fila["FECHA_CREACION"].ToString();
                            objCliente.UsuarioModificacion = Fila["FECHA_MODIFICACION"].ToString();

                        }

                    }
                    objCon.Close();
                }
                catch (Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }


            return default;

        }
        public bool Guardar(TAccesoDatosClientes prmCliente)
        {
            return false;

        }

        public bool Actualizar(TAccesoDatosClientes prmCliente)
        {
            return false;

        }

        public bool Anular(int IdCliente)
        {
            return false;

        }

    }
}

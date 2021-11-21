using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se agrega esta referencia para crear la conexion
using System.Data.SqlClient;

namespace COBRANZA.AdminDB
{
    public class TParametrosdeConexion
    {
        //Creamos un objeto que nos permitira configurar la cadena conexion y lo instanciamos
        private SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();
        //Declaramos el constructor y tiene el mismo nombre de la clase y es public
        public TParametrosdeConexion (){
            //En este punto se genera un error porque la \ no la reconoce entocnes se le agrega \\ para que reconosca una ya que es un caracter especial   
            //objBuilder.DataSource = "LAPTOP-4GBTKOL2\SQLEXPRESS";
            objBuilder.DataSource = "LAPTOP-4GBTKOL2\\SQLEXPRESS";
            objBuilder.InitialCatalog = "DBCOBRANZA";
            objBuilder.UserID = "sa";
            objBuilder.Password = "1251";
        }
        
        //Retorna la cadena de conexion (pasa los parametros de la conexion del metodo anterior)
        public string getStringCon ()
        {
            return objBuilder.ConnectionString;
        }

    }
}

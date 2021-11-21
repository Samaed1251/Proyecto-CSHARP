using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZA.Modelo;
using COBRANZA.CLIENTES;
using System.Data;

namespace COBRANZA.CLIENTES
{
    
    class TCapaNegociosClientes
    {
        TAccesoDatosClientes objAD_Clientes = new TAccesoDatosClientes();

        public DataTable Consultar (string Id) {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return objAD_Clientes.Consultar(valId);
            else
                return default;
        }

    }
}
 
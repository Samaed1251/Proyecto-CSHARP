using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZA.Modelo
{
    public class TModelClientes
    {
        //Atributos
        public int Id { set; get; }   
        public string Identidad { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }
        public string Municipio { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public DateTime FechaCreacion { set; get; }
        public DateTime FechaModificacion { set; get; }
        public string UsuarioCreacion { set; get; }
        public string UsuarioModificacion { set; get; }

    }
}

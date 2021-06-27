using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    class Vendedor
    {
        public string ID { get; set; }
        public string NombreApellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public SqlInt16 NivelPermiso { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Vendedor
    {
        public string ID { get; set; }
        public string NombreApellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public SqlInt16 NivelPermiso { get; set; }
    }
}

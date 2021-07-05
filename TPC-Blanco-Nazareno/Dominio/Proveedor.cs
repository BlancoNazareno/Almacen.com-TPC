using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Proveedor
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

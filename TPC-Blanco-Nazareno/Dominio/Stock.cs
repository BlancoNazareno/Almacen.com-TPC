using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Stock
    {
        public Producto Producto { get; set; }
        public int CantidadStock { get; set; }
    }
}

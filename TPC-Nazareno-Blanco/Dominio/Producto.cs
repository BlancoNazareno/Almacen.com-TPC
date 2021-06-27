using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Producto
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Proveedor Proveedor { get; set; }
        public SqlMoney PrecioCompra { get; set; }
        public SqlMoney PrecioVenta { get; set; }
        public int StockMinimo { get; set; }

    }
}

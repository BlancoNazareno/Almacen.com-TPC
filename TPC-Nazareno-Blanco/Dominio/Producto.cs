using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    class Producto
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string ID_Marca { get; set; }
        public string Descripcion_Marca { get; set; }
        public string ID_Proveedor { get; set; }
        public string Descripcion_Proveedor { get; set; }
        public SqlMoney Precio_Compra { get; set; }
        public SqlMoney Precio_venta { get; set; }
        public int Stock_Minimo { get; set; }

    }
}

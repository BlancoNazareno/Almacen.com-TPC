using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    class Venta
    {
        public int ID { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public Stock Stock { get; set; }
        public SqlMoney MontoFacturado { get; set; }
        public SqlMoney MontoGanancia { get; set; }
        public SqlDateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public bool SentidoMovimiento { get; set; }
    }
}

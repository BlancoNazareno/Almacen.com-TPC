using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    class MovimientoMercaderia
    {
        public int ID { get; set; }
        public Vendedor Vendedor { get; set; }
        public Producto Producto { get; set; }
        public Stock Stock { get; set; }
        public SqlDateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public bool SentidoMovimiento { get; set; }
    }
}

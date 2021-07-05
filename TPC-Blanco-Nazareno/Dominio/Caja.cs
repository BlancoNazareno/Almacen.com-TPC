using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Caja
    {
        public int ID { get; set; }
        public SqlMoney MontoFacturado { get; set; }
        public SqlMoney MontoGanancia { get; set; }
    }
}

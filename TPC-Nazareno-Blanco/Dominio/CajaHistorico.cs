﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
    class CajaHistorico
    {
        public int ID { get; set; }
        public SqlMoney MontoFacturado { get; set; }
        public SqlMoney MontoGanancia { get; set; }

        public SqlDateTime Fecha { get; set; }
    }
}
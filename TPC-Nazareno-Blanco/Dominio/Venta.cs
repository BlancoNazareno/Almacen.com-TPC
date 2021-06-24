﻿using System;
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
        public string ID_Vendedor { get; set; }
        public string Descripcion_Vendedor { get; set; }
        public string ID_Cliente { get; set; }

        public string Descripcion_Cliente { get; set; }
        public string ID_Producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public SqlMoney Monto_Facturado { get; set; }
        public SqlMoney Monto_Ganancia { get; set; }
        public SqlDateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public bool Sentido_Movimiento { get; set; }
    }
}

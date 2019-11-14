using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdcontrolBal
    {
        public int BalId { get; set; }
        public int BalClienteId { get; set; }
        public int BalProyectoId { get; set; }
        public int BalCotiId { get; set; }
        public string BalProdId { get; set; }
        public int? BalCantOrdenada { get; set; }
        public int? BalCantRecibida { get; set; }
        public int? BalCantDevuelta { get; set; }

        public virtual DdbalanceCc BalCliente { get; set; }
        public virtual Ddcliente BalClienteNavigation { get; set; }
        public virtual DdcotiEncabezado BalCoti { get; set; }
        public virtual DdmaeInventario BalProd { get; set; }
        public virtual Ddproyecto BalProyecto { get; set; }
    }
}

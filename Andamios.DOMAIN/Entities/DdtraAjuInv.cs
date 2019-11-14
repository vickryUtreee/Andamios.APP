using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdtraAjuInv
    {
        public int TraAjuId { get; set; }
        public int? TraAjuCodId { get; set; }
        public string TraAjuProdId { get; set; }
        public int? TraAjuCantidad { get; set; }
        public DateTime? TraAjuFechaCrea { get; set; }
        public string TraAjuUsuCrea { get; set; }

        public virtual DdtipoTraAju TraAjuCod { get; set; }
        public virtual DdmaeInventario TraAjuProd { get; set; }
    }
}

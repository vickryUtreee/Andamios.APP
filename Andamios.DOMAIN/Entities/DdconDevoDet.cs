using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconDevoDet
    {
        public int ConDevoDetId { get; set; }
        public int? ConDevoDetEnId { get; set; }
        public string ConDevoProdId { get; set; }
        public int? ConDevoCantidad { get; set; }

        public virtual DdconDevoEnc ConDevoDetEn { get; set; }
        public virtual DdmaeInventario ConDevoProd { get; set; }
    }
}

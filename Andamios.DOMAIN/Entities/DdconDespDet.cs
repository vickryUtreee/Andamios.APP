using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconDespDet
    {
        public int ConDespDetId { get; set; }
        public int? ConDespEnDetId { get; set; }
        public string ConDespDetProdId { get; set; }
        public int? ConDespDetCantOrd { get; set; }

        public virtual DdmaeInventario ConDespDetProd { get; set; }
        public virtual DdconDespEnc ConDespEnDet { get; set; }
    }
}

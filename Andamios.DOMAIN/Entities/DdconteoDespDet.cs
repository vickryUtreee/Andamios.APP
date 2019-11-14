using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconteoDespDet
    {
        public int ContDespDetId { get; set; }
        public int? ContDespDetEncId { get; set; }
        public string ContDespProdId { get; set; }
        public int? ContDespCantProdOrd { get; set; }
        public int? ContDespCantProyecto { get; set; }

        public virtual DdconteoDespEnc ContDespDetEnc { get; set; }
        public virtual DdmaeInventario ContDespProd { get; set; }
    }
}

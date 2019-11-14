using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdingInvDet
    {
        public int TraDeIngId { get; set; }
        public int TraDeEnIngId { get; set; }
        public string TraDeProdId { get; set; }
        public int? TraDeCantidad { get; set; }
        public decimal? TraDeCosto { get; set; }

        public virtual DdingInvEnc TraDeEnIng { get; set; }
        public virtual DdmaeInventario TraDeProd { get; set; }
    }
}

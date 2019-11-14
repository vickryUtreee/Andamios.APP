using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdingInvEnc
    {
        public DdingInvEnc()
        {
            DdingInvDet = new HashSet<DdingInvDet>();
        }

        public int TraEnIngId { get; set; }
        public int? TraEnCodSupId { get; set; }
        public int? TraEnCodAgeId { get; set; }
        public string TraEnNumEmbarque { get; set; }
        public string TraEnFactAge { get; set; }
        public DateTime? TraEnFecFactAge { get; set; }
        public string TraEnOrdenCompra { get; set; }
        public DateTime? TraEnFecCrea { get; set; }
        public string TraEnUsuCrea { get; set; }

        public virtual Ddsuplidor TraEnCodAge { get; set; }
        public virtual Ddsuplidor TraEnCodSup { get; set; }
        public virtual ICollection<DdingInvDet> DdingInvDet { get; set; }
    }
}

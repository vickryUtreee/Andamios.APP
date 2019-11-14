using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdreciboCc
    {
        public DdreciboCc()
        {
            DddepositoCoti = new HashSet<DddepositoCoti>();
            DddetalleReciboCc = new HashSet<DddetalleReciboCc>();
            DdpagoNoAp = new HashSet<DdpagoNoAp>();
        }

        public int CcreciboId { get; set; }
        public int CcreciboCliId { get; set; }
        public DateTime CcreciboFecha { get; set; }
        public DateTime CcreciboFecCrea { get; set; }
        public string CcreciboUsuCrea { get; set; }
        public DateTime CcreciboFecMod { get; set; }
        public string CcreciboUsuMod { get; set; }
        public decimal CcreciboCheque { get; set; }
        public decimal CcreciboEfectivo { get; set; }
        public decimal CcreciboTransferencia { get; set; }
        public decimal CcreciboTarjetaCredito { get; set; }
        public string CcreciboConcepto { get; set; }
        public string CcreciboEstatus { get; set; }

        public virtual Ddcliente CcreciboCli { get; set; }
        public virtual ICollection<DddepositoCoti> DddepositoCoti { get; set; }
        public virtual ICollection<DddetalleReciboCc> DddetalleReciboCc { get; set; }
        public virtual ICollection<DdpagoNoAp> DdpagoNoAp { get; set; }
    }
}

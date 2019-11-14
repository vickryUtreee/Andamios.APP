using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DddepositoCoti
    {
        public int CcdepReciboId { get; set; }
        public int CcdepReciboCliId { get; set; }
        public int CcdepReciboOrigId { get; set; }
        public int CcdepReciboProyectoId { get; set; }
        public decimal CcdepCotiCheque { get; set; }
        public decimal CcdepCotiEfectivo { get; set; }
        public decimal CcdepCotiTransferencia { get; set; }
        public decimal CcdepCotiTarjetaCredito { get; set; }

        public virtual Ddcliente CcdepReciboCli { get; set; }
        public virtual DdreciboCc CcdepReciboOrig { get; set; }
        public virtual Ddproyecto CcdepReciboProyecto { get; set; }
    }
}

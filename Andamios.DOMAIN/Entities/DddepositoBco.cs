using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DddepositoBco
    {
        public int CcdepositoId { get; set; }
        public DateTime CcdepositoFecha { get; set; }
        public decimal CcdepositoBanco { get; set; }
        public decimal CcdepositoEfectivo { get; set; }
        public decimal CcdepositoCheque { get; set; }
        public decimal CcdepositoTransferencia { get; set; }
        public decimal CcdepositoTarjeta { get; set; }
        public string CcdepositoEstatus { get; set; }

        public virtual Ddbanco CcdepositoBancoNavigation { get; set; }
    }
}

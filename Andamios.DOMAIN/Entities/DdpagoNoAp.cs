using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdpagoNoAp
    {
        public int CcpagoId { get; set; }
        public int CcpagoReciboId { get; set; }
        public int CcpagoClienteId { get; set; }
        public int CcpagoProyectoId { get; set; }
        public DateTime CcpagoFecha { get; set; }
        public decimal CcpagoCheque { get; set; }
        public decimal CcpagoEfectivo { get; set; }
        public decimal CcpagoTransferencia { get; set; }
        public decimal CcpagoTarjetaCredito { get; set; }

        public virtual Ddcliente CcpagoCliente { get; set; }
        public virtual Ddproyecto CcpagoProyecto { get; set; }
        public virtual DdreciboCc CcpagoRecibo { get; set; }
    }
}

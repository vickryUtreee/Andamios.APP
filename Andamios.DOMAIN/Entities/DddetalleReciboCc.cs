using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DddetalleReciboCc
    {
        public int CcdetalleReciboId { get; set; }
        public int CcreciboId { get; set; }
        public string CcdetalleReciboAltMov { get; set; }
        public int CcdetalleReciboAltSec { get; set; }
        public int CcdetalleFacturaId { get; set; }
        public decimal CcdetalleReciboMonto { get; set; }

        public virtual DdmovimientoCc CcdetalleReciboAltMovNavigation { get; set; }
        public virtual DdreciboCc Ccrecibo { get; set; }
    }
}

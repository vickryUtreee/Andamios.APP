using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdmovimientoCc
    {
        public DdmovimientoCc()
        {
            DddetalleReciboCc = new HashSet<DddetalleReciboCc>();
        }

        public string CcmovId { get; set; }
        public string CcmovDesc { get; set; }
        public DateTime CcmovFechaCrea { get; set; }
        public string CcmovUsuCrea { get; set; }
        public string CcmovEstatus { get; set; }

        public virtual ICollection<DddetalleReciboCc> DddetalleReciboCc { get; set; }
    }
}

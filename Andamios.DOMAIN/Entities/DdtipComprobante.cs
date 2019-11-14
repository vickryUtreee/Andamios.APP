using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdtipComprobante
    {
        public DdtipComprobante()
        {
            DdfactEnc = new HashSet<DdfactEnc>();
        }

        public decimal TcompId { get; set; }
        public string TcompSerie { get; set; }
        public decimal? TcompSecuenciaIni { get; set; }
        public decimal? TcompNumerador { get; set; }
        public decimal? TcompSecuenciaFin { get; set; }
        public decimal? TcompCantidadCtrl { get; set; }
        public DateTime? TcompFechaValida { get; set; }
        public string TcompDescripcion { get; set; }
        public string TcompImpuesto { get; set; }
        public string TcompUsuCrea { get; set; }
        public DateTime? TcompFechaCrea { get; set; }
        public string TcompUsuModi { get; set; }
        public DateTime? TcompFechaModi { get; set; }
        public string TcompEstatus { get; set; }

        public virtual ICollection<DdfactEnc> DdfactEnc { get; set; }
    }
}

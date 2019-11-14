using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class Ddbanco
    {
        public Ddbanco()
        {
            DddepositoBco = new HashSet<DddepositoBco>();
        }

        public decimal CcbancoId { get; set; }
        public string CcbancoDescripcion { get; set; }
        public string CcbancoNumCta { get; set; }
        public string CcbancoTipoCta { get; set; }
        public DateTime CcbancoFechaCrea { get; set; }
        public string CcbancoUsuCrea { get; set; }
        public DateTime CcbancoFechaMod { get; set; }
        public string CcbancoUsuMod { get; set; }
        public string CcbancoEstatus { get; set; }

        public virtual ICollection<DddepositoBco> DddepositoBco { get; set; }
    }
}

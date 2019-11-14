using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdtipoTraAju
    {
        public DdtipoTraAju()
        {
            DdtraAjuInv = new HashSet<DdtraAjuInv>();
        }

        public int TraTipoId { get; set; }
        public string TraTipoDesc { get; set; }
        public string TraTipoAjuste { get; set; }
        public DateTime? TraTipoFechaCrea { get; set; }
        public string TratipoUsuCrea { get; set; }
        public string TraTipoEstatus { get; set; }

        public virtual ICollection<DdtraAjuInv> DdtraAjuInv { get; set; }
    }
}

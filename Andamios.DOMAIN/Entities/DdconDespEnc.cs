using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconDespEnc
    {
        public DdconDespEnc()
        {
            DdconDespDet = new HashSet<DdconDespDet>();
            DdfactEnc = new HashSet<DdfactEnc>();
        }

        public int ConDespEnId { get; set; }
        public int ConDespEnConteoId { get; set; }
        public int ConDespEnCotiId { get; set; }
        public string ConDespEnTipo { get; set; }
        public int ConDespEnProyectoId { get; set; }
        public int ConDespEnCliId { get; set; }
        public string ConDespEnOrdenC { get; set; }
        public DateTime? ConDespEnFechaEmision { get; set; }
        public string ConDespEnUsuarioCrea { get; set; }
        public string ConDespEnEstatus { get; set; }

        public virtual Ddcliente ConDespEnCli { get; set; }
        public virtual DdcotiEncabezado ConDespEnCoti { get; set; }
        public virtual Ddproyecto ConDespEnProyecto { get; set; }
        public virtual ICollection<DdconDespDet> DdconDespDet { get; set; }
        public virtual ICollection<DdfactEnc> DdfactEnc { get; set; }
    }
}

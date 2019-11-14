using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconDevoEnc
    {
        public DdconDevoEnc()
        {
            DdconDevoDet = new HashSet<DdconDevoDet>();
        }

        public int ConDevoEnId { get; set; }
        public int ConDevoEnContId { get; set; }
        public int ConDevoEnCotiId { get; set; }
        public string ConDevoEnTipo { get; set; }
        public int ConDevoEnProyectoId { get; set; }
        public int ConDevoEnCliId { get; set; }
        public string ConDevoOrdenC { get; set; }
        public DateTime? ConDevoFechaEmision { get; set; }
        public string ConDevoUsuarioCrea { get; set; }
        public string ConDevoEnEstatus { get; set; }

        public virtual Ddcliente ConDevoEnCli { get; set; }
        public virtual DdconteoDevoEnc ConDevoEnCont { get; set; }
        public virtual DdcotiEncabezado ConDevoEnCoti { get; set; }
        public virtual Ddproyecto ConDevoEnProyecto { get; set; }
        public virtual ICollection<DdconDevoDet> DdconDevoDet { get; set; }
    }
}

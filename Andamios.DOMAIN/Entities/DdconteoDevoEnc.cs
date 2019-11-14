using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconteoDevoEnc
    {
        public DdconteoDevoEnc()
        {
            DdconDevoEnc = new HashSet<DdconDevoEnc>();
            DdconteoDevoDet = new HashSet<DdconteoDevoDet>();
        }

        public int ContDevoEncId { get; set; }
        public int ContDevoEncCoti { get; set; }
        public int ContDevoEncClienteId { get; set; }
        public int ContDevoEncProyectoId { get; set; }
        public int? ContDevoEncOrden { get; set; }
        public DateTime? ContDevoEncFechaCreacion { get; set; }
        public string ContDevoEncUsuCreacion { get; set; }
        public DateTime? ContDevoEncFechaModifica { get; set; }
        public string ContDevoEncUsuModifica { get; set; }
        public string ContDevoEncEstatus { get; set; }

        public virtual Ddcliente ContDevoEncCliente { get; set; }
        public virtual DdcotiEncabezado ContDevoEncCotiNavigation { get; set; }
        public virtual Ddproyecto ContDevoEncProyecto { get; set; }
        public virtual ICollection<DdconDevoEnc> DdconDevoEnc { get; set; }
        public virtual ICollection<DdconteoDevoDet> DdconteoDevoDet { get; set; }
    }
}

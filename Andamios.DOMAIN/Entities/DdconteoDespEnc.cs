using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdconteoDespEnc
    {
        public DdconteoDespEnc()
        {
            DdconteoDespDet = new HashSet<DdconteoDespDet>();
        }

        public int ContDespEncId { get; set; }
        public int ContDespEncCotiId { get; set; }
        public int ContDespEncClienteId { get; set; }
        public int ContDespEncProyectoId { get; set; }
        public string ContDespEncOrden { get; set; }
        public DateTime? ContDespEncFechaCreacion { get; set; }
        public string ContDespEncUserCrea { get; set; }
        public DateTime? ContDespEncFechaModifica { get; set; }
        public string ContDespEncUserModifica { get; set; }
        public string ContDespEncEstatus { get; set; }

        public virtual Ddcliente ContDespEncCliente { get; set; }
        public virtual DdcotiEncabezado ContDespEncCoti { get; set; }
        public virtual Ddproyecto ContDespEncProyecto { get; set; }
        public virtual ICollection<DdconteoDespDet> DdconteoDespDet { get; set; }
    }
}

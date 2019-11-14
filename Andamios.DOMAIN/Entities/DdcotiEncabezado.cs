using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdcotiEncabezado
    {
        public DdcotiEncabezado()
        {
            DdconDespEnc = new HashSet<DdconDespEnc>();
            DdconDevoEnc = new HashSet<DdconDevoEnc>();
            DdconteoDespEnc = new HashSet<DdconteoDespEnc>();
            DdconteoDevoEnc = new HashSet<DdconteoDevoEnc>();
            DdcontrolBal = new HashSet<DdcontrolBal>();
            DdcotiDetalle = new HashSet<DdcotiDetalle>();
            DdfactEnc = new HashSet<DdfactEnc>();
        }

        public int CotiEnId { get; set; }
        public string CotiEnTipo { get; set; }
        public string CotiEnClas { get; set; }
        public int CotiEnClienteId { get; set; }
        public int CotiEnProyectoId { get; set; }
        public string CotiEnOrden { get; set; }
        public string CotiEnUsuarioVendedor { get; set; }
        public string CotiEnUsuarioCreacion { get; set; }
        public string CotiEnUsuarioAnulacion { get; set; }
        public string CotiEnUsuarioActivacion { get; set; }
        public DateTime? CotiEnFechaCreacion { get; set; }
        public DateTime? CotiEnFechaAnulacion { get; set; }
        public DateTime? CotiEnFechaActivacion { get; set; }
        public decimal? CotiEnPorDeposito { get; set; }
        public short? CotiEnDias { get; set; }
        public string CotiEnDescripcion { get; set; }
        public string CotiEnImpuesto { get; set; }
        public string CotiEnCondicionPago { get; set; }
        public string CotiEnTransporte { get; set; }
        public decimal? CotiEnDescuento { get; set; }
        public string CotiEnEstatus { get; set; }

        public virtual Ddcliente CotiEnCliente { get; set; }
        public virtual Ddproyecto CotiEnProyecto { get; set; }
        public virtual ICollection<DdconDespEnc> DdconDespEnc { get; set; }
        public virtual ICollection<DdconDevoEnc> DdconDevoEnc { get; set; }
        public virtual ICollection<DdconteoDespEnc> DdconteoDespEnc { get; set; }
        public virtual ICollection<DdconteoDevoEnc> DdconteoDevoEnc { get; set; }
        public virtual ICollection<DdcontrolBal> DdcontrolBal { get; set; }
        public virtual ICollection<DdcotiDetalle> DdcotiDetalle { get; set; }
        public virtual ICollection<DdfactEnc> DdfactEnc { get; set; }
    }
}

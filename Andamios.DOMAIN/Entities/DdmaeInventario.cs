using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdmaeInventario
    {
        public DdmaeInventario()
        {
            DdconDespDet = new HashSet<DdconDespDet>();
            DdconDevoDet = new HashSet<DdconDevoDet>();
            DdconteoDespDet = new HashSet<DdconteoDespDet>();
            DdconteoDevoDet = new HashSet<DdconteoDevoDet>();
            DdcontrolBal = new HashSet<DdcontrolBal>();
            DdcotiDetalle = new HashSet<DdcotiDetalle>();
            DdfactDet = new HashSet<DdfactDet>();
            DdingInvDet = new HashSet<DdingInvDet>();
            DdtraAjuInv = new HashSet<DdtraAjuInv>();
        }

        public string MinvId { get; set; }
        public string MinvDescripcion { get; set; }
        public short? MinvClase { get; set; }
        public string MinvUnidad { get; set; }
        public string MinvPeso { get; set; }
        public int? MinvTotalIngresado { get; set; }
        public int? MinvTotalRentado { get; set; }
        public int? MinvTotalOrdenado { get; set; }
        public decimal? MinvPrecioVenta { get; set; }
        public decimal? MinvPrecioRentaFija { get; set; }
        public decimal? MinvPrecioRentaDia { get; set; }
        public decimal? MinvCostoAdquisicion { get; set; }
        public string MinvPiezaServicio { get; set; }
        public DateTime? MinvFechaCreacion { get; set; }
        public string MinvUsuarioCreacion { get; set; }
        public string MinvUsuarioModifica { get; set; }
        public DateTime? MinvFechaModifica { get; set; }
        public string MinvRutaImagen { get; set; }
        public string MinvEstatus { get; set; }

        public virtual DdclaseProd MinvClaseNavigation { get; set; }
        public virtual ICollection<DdconDespDet> DdconDespDet { get; set; }
        public virtual ICollection<DdconDevoDet> DdconDevoDet { get; set; }
        public virtual ICollection<DdconteoDespDet> DdconteoDespDet { get; set; }
        public virtual ICollection<DdconteoDevoDet> DdconteoDevoDet { get; set; }
        public virtual ICollection<DdcontrolBal> DdcontrolBal { get; set; }
        public virtual ICollection<DdcotiDetalle> DdcotiDetalle { get; set; }
        public virtual ICollection<DdfactDet> DdfactDet { get; set; }
        public virtual ICollection<DdingInvDet> DdingInvDet { get; set; }
        public virtual ICollection<DdtraAjuInv> DdtraAjuInv { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdfactEnc
    {
        public DdfactEnc()
        {
            DdfactDet = new HashSet<DdfactDet>();
        }

        public int FactEnId { get; set; }
        public string FactEnTipo { get; set; }
        public string FactEnClase { get; set; }
        public int FactEnClienteId { get; set; }
        public int FactEnConduceId { get; set; }
        public int FactEnCotiId { get; set; }
        public string FactEnVendedor { get; set; }
        public string FactEnOrden { get; set; }
        public int FactEnProyectoId { get; set; }
        public decimal FactEnTipoComprobante { get; set; }
        public string FactEnNumeroComprobante { get; set; }
        public DateTime? FactEnFechaEmision { get; set; }
        public DateTime? FactEnFechaConteo { get; set; }
        public DateTime? FactEnFechaValida { get; set; }
        public int? FactEnDias { get; set; }
        public decimal? FactEnImpuesto { get; set; }
        public decimal? FactEnDescGlobal { get; set; }
        public string FactEnUsuarioCrea { get; set; }
        public string FactEnEstatus { get; set; }

        public virtual Ddcliente FactEnCliente { get; set; }
        public virtual DdconDespEnc FactEnConduce { get; set; }
        public virtual DdcotiEncabezado FactEnCoti { get; set; }
        public virtual Ddproyecto FactEnProyecto { get; set; }
        public virtual DdtipComprobante FactEnTipoComprobanteNavigation { get; set; }
        public virtual ICollection<DdfactDet> DdfactDet { get; set; }
    }
}

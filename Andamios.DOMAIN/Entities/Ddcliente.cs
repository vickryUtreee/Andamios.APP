using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class Ddcliente
    {
        public Ddcliente()
        {
            DdbalanceCc = new HashSet<DdbalanceCc>();
            DdconDespEnc = new HashSet<DdconDespEnc>();
            DdconDevoEnc = new HashSet<DdconDevoEnc>();
            DdconteoDespEnc = new HashSet<DdconteoDespEnc>();
            DdconteoDevoEnc = new HashSet<DdconteoDevoEnc>();
            DdcontrolBal = new HashSet<DdcontrolBal>();
            DdcotiEncabezado = new HashSet<DdcotiEncabezado>();
            DddepositoBal = new HashSet<DddepositoBal>();
            DddepositoCoti = new HashSet<DddepositoCoti>();
            DdfactEnc = new HashSet<DdfactEnc>();
            DdpagoNoAp = new HashSet<DdpagoNoAp>();
            Ddproyecto = new HashSet<Ddproyecto>();
            DdreciboCc = new HashSet<DdreciboCc>();
        }

        public int ClienteId { get; set; }
        public string ClienteTipo { get; set; }
        public string ClienteTipoId { get; set; }
        public decimal? ClienteTipoComprobante { get; set; }
        public string ClienteDescripcion { get; set; }
        public int? ClienteSector { get; set; }
        public string ClienteDireccion { get; set; }
        public int? ClienteRegion { get; set; }
        public string ClienteTelOf1 { get; set; }
        public string ClienteTelOf2 { get; set; }
        public string ClienteTelFax { get; set; }
        public string ClienteCorreoElec { get; set; }
        public string ClienteGestorCobros { get; set; }
        public string ClienteCodigoVendedor { get; set; }
        public string ClienteUsuarioRegistro { get; set; }
        public string ClienteUsuarioModifica { get; set; }
        public DateTime? ClienteFechaCreacion { get; set; }
        public DateTime? ClienteFechaModifica { get; set; }
        public string ClienteGerente { get; set; }
        public string ClienteContacto { get; set; }
        public string ClienteContactoCel1 { get; set; }
        public string ClienteContactoCel2 { get; set; }
        public string ClienteEstatus { get; set; }

        public virtual ICollection<DdbalanceCc> DdbalanceCc { get; set; }
        public virtual ICollection<DdconDespEnc> DdconDespEnc { get; set; }
        public virtual ICollection<DdconDevoEnc> DdconDevoEnc { get; set; }
        public virtual ICollection<DdconteoDespEnc> DdconteoDespEnc { get; set; }
        public virtual ICollection<DdconteoDevoEnc> DdconteoDevoEnc { get; set; }
        public virtual ICollection<DdcontrolBal> DdcontrolBal { get; set; }
        public virtual ICollection<DdcotiEncabezado> DdcotiEncabezado { get; set; }
        public virtual ICollection<DddepositoBal> DddepositoBal { get; set; }
        public virtual ICollection<DddepositoCoti> DddepositoCoti { get; set; }
        public virtual ICollection<DdfactEnc> DdfactEnc { get; set; }
        public virtual ICollection<DdpagoNoAp> DdpagoNoAp { get; set; }
        public virtual ICollection<Ddproyecto> Ddproyecto { get; set; }
        public virtual ICollection<DdreciboCc> DdreciboCc { get; set; }
    }
}

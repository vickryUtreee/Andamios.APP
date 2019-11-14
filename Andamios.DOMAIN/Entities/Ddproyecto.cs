using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class Ddproyecto
    {
        public Ddproyecto()
        {
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
        }

        public int ProId { get; set; }
        public int ProClienteId { get; set; }
        public string ProVendedorId { get; set; }
        public string ProNombre { get; set; }
        public string ProDireccion { get; set; }
        public string ProContacto { get; set; }
        public string ProTelContacto { get; set; }
        public string ProCorreoContacto { get; set; }
        public DateTime? ProFechaProyecto { get; set; }
        public decimal? ProDescuentoGlobal { get; set; }
        public string ProUsuarioCreacion { get; set; }
        public DateTime? ProFechaCreacion { get; set; }
        public string ProUsuarioModifica { get; set; }
        public DateTime? ProFechaModifica { get; set; }

        public virtual Ddcliente ProCliente { get; set; }
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
    }
}

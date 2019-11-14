using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdbalanceCc
    {
        public DdbalanceCc()
        {
            DdcontrolBal = new HashSet<DdcontrolBal>();
        }

        public int CcbalId { get; set; }
        public int CcbalClienteId { get; set; }
        public int CcbalProyectoId { get; set; }
        public int CcbalCotiId { get; set; }
        public int CcbalFactId { get; set; }
        public string CcbalFactTipo { get; set; }
        public string CcbalFactClas { get; set; }
        public decimal CcbalMontoFact { get; set; }
        public decimal CcbalRecibidoFact { get; set; }
        public string CcbalBalStatus { get; set; }

        public virtual Ddcliente CcbalCliente { get; set; }
        public virtual ICollection<DdcontrolBal> DdcontrolBal { get; set; }
    }
}

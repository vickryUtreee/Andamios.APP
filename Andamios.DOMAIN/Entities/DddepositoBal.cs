using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DddepositoBal
    {
        public int CcdepBalId { get; set; }
        public int CcdepBalCliId { get; set; }
        public int CcdepBalProyectoId { get; set; }
        public decimal CcdepBalMonto { get; set; }
        public decimal CcdepBalAplicado { get; set; }

        public virtual Ddcliente CcdepBalCli { get; set; }
        public virtual Ddproyecto CcdepBalProyecto { get; set; }
    }
}

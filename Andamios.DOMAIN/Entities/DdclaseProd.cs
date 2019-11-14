﻿using System;
using System.Collections.Generic;

namespace Andamios.DOMAIN.Entities
{
    public partial class DdclaseProd
    {
        public DdclaseProd()
        {
            DdmaeInventario = new HashSet<DdmaeInventario>();
        }

        public short ClaProdId { get; set; }
        public string ClaProdDesc { get; set; }
        public string ClaProdCtrlInventario { get; set; }
        public DateTime? ClaProdFechaCreacion { get; set; }
        public string ClaProdUsuarioCreacion { get; set; }
        public DateTime? ClaProdFechaModifica { get; set; }
        public string ClaProdUsuarioModifica { get; set; }
        public string ClaProdEstatus { get; set; }

        public virtual ICollection<DdmaeInventario> DdmaeInventario { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class TipoComprobante
    {
        public int TipoComprobanteId { get; set; }

        public int ComprobantePagoId { get; set; }
        public ComprobantePago ComprobantePago { get; set; }



    }
}

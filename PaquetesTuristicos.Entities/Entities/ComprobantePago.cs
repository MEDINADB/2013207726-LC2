﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class ComprobantePago 
    {
        public int ComprobantePagoId { get; set; }
        public int Descripcion { get; set; }

        public List<TipoComprobante> TiposComprobante { get; set; }
        public List<VentaPaquete> VentaPaquetes { get; set; }

        public ComprobantePago()
        {
            TiposComprobante = new List<TipoComprobante>();
            VentaPaquetes = new List<VentaPaquete>();

        }
    }
}

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
        public string  Descripcion { get; set; }


        //relaciones
        public TipoComprobante TipoComprobante { get; set; }

        public List<VentaPaquete> VentaPaquetes { get; set; }

        public ComprobantePago()
        {
        
            VentaPaquetes = new List<VentaPaquete>();

        }
    }
}

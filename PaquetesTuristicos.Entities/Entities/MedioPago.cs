﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class MedioPago
    {
        public int MedioPagoId { get; set; }

        public List<VentaPaquete> VentaPaquetes { get; set; }
        public MedioPago()
        {
            VentaPaquetes = new List<VentaPaquete>();
        }
    }
}

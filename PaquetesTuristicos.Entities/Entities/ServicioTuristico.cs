﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class ServicioTuristico
    {
        public int ServicioTuristicoId { get; set; }
        public String  Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Direccion { get; set; }

        public ServicioTuristico(string fecha, DateTime hora,string direccion)
        {
            Fecha = fecha;
            Hora = Hora;
            Direccion = direccion;
        }
        public List<Paquete> Paquetes { get; set; }
        public ServicioTuristico()
        {
            Paquetes = new List<Paquete>();
        }

    }
}

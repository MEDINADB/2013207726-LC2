using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class CategoriaTransporte
    {
        public int CategoriaTransporteId { get; set; }



        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}

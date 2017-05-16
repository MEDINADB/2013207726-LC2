using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public  interface IRepoCategoriaHospedaje
    {
        IEnumerable<CalificacionHospedaje> getCateogiraporHospaje(Hospedaje hospedaje);
    }
}


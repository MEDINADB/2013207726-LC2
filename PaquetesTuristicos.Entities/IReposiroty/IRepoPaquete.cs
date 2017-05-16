using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoPaquete
    {
        IEnumerable<Paquete> getPaqueteporVenta(VentaPaquete ventapaquete);
        IEnumerable<Paquete> getPaqueteporServicio(ServicioTuristico servicioturisco );

    }
}

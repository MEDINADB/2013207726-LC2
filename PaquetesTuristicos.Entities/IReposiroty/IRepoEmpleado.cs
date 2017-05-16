using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoEmpleado
    {
        IEnumerable<Empleado> getEmpleadoporVenta(VentaPaquete ventapaquete);
    }
}

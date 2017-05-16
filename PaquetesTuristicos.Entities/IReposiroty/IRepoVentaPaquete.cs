using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoVentaPaquete
    {
        IEnumerable<VentaPaquete> getVentaporMedio(MedioPago mediopago);
        IEnumerable<VentaPaquete> getVentaporCliente(Cliente cliente);
        IEnumerable<VentaPaquete> getVentaporEmpleado(Empleado empleado);
        IEnumerable<VentaPaquete> getVentaporPaquete(Paquete paquete);

    }
}

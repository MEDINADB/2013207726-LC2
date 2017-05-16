using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    interface IUnityofWork : IDisposable
    {
            IRepoCategoriaHospedaje CategoriaHospedaje { get; } 
            IRepoCategoriaTransporte CategoriaTransporte { get; }
            IRepoComprobantePago ComprobantePago { get; }
            IRepoAlimentacion Alimentacion { get; }
            IRepoCalificacionHospedaje CalificacionHospedaje { get; }
            IRepoCategoriaAlimentacion CategoriaAlimentacion { get; }
            IRepoCliente Cliente { get; }
            IRepoEmpleado Empleado { get; }
            IRepoHospejade Hospejade { get; }
            IRepoMedioPago MedioPago { get; }
            IRepoPaquete Paquete { get; }
            IRepoServicioHospedaje ServicioHospedaje { get; }
            IRepoServicioTuristico ServicioTuristico { get; }
            IRepoTipoComprobante TipoComprobante { get; }
            IRepoTipoHospedaje TipoHospedaje { get; }
            IRepoTipoTransporte TipoTransporte { get; }
            IRepoTransporte Transporte { get; }
            IRepoVentaPaquete VentaPaquete { get; }
            IRepoPersona Persona { get; }
 
            int SaveChange();
    }
}

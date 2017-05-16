using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoHospejade
    {
        IEnumerable<Hospedaje> getHospedajeporTIpo(TipoHospedaje tipohospedaje);
        IEnumerable<Hospedaje> getHospedajeporCalificacion(CalificacionHospedaje calificacionhospedaje);
        IEnumerable<Hospedaje> getHospedajeporCategoria(CategoriaHospedaje categoriahospedaje);
        IEnumerable<ComprobantePago> getHospedajeporServicio(ServicioHospedaje serviciohospedaje);
    }
}

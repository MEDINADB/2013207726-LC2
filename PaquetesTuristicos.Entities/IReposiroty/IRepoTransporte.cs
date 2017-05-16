using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoTransporte
    {
        IEnumerable<Transporte> getTransporteproTipo(TipoTransporte tipotransporte);
        IEnumerable<Transporte> getTransporteporCategoria(CategoriaTransporte Categoriatransporte);


    }
}

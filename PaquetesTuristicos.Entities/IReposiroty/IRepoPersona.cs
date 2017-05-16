using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoPersona
    {
        IEnumerable<Persona> getAdministradorporCelular(Persona persona );

    }
}

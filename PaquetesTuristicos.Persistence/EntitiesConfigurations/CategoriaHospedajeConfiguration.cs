using PaquetesTuristicos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Persistence.EntitiesConfigurations
{
    public class CategoriaHospedajeConfiguration  :  EntityTypeConfiguration<CategoriaHospedaje>
    {

        public CategoriaHospedajeConfiguration()
        {
            //Table Configurations
            ToTable("CategoriasHospedaje");

            HasKey(c => c.CategoriaHospedajeId);

        }
    }
}

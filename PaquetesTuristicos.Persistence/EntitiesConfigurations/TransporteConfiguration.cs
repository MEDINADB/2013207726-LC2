using PaquetesTuristicos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Persistence.EntitiesConfigurations
{
     class TransporteConfiguration : EntityTypeConfiguration<Transporte>
    {
    
        public TransporteConfiguration()
        {
            //Table Configurations
            ToTable("Transportes");

            HasKey(c => c.TransporteId);

            //Relations Configurations
            HasMany(c => c.CategoriasTransporte)   
                .WithRequired(c => c.Transporte);

            HasMany(c => c.TiposTransporte)
                .WithRequired(c => c.Transporte);
        }
    }
}

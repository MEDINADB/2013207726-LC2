using PaquetesTuristicos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Persistence.EntitiesConfigurations
{
      class AlimentacionConfiguration : EntityTypeConfiguration<Alimentacion>
    {
    
           public AlimentacionConfiguration()
        {
            //Table Configurations
            ToTable("Alimentacion");

            HasKey(c => c.AlimentacionId);

            //Relations Configurations
            HasMany(c => c.CategoriasAlimentacion)
                .WithMany(c => c.Alimentacion)
                .Map(m =>
                 {
                     m.ToTable("AlimentacionCategoriasAlimento");
                     m.MapLeftKey("AlimentacionId");  
                     m.MapRightKey("AlimentaionCategoriaId");
                 });
        }
    }
}

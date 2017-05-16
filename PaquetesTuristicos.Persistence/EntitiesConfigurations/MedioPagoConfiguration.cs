﻿using PaquetesTuristicos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Persistence.EntitiesConfigurations
{
   public class MedioPagoConfiguration : EntityTypeConfiguration<MedioPago>
    {
        public MedioPagoConfiguration()
        {
            //Table Configurations
            ToTable("MediosPago");

            HasKey(c => c.MedioPagoId);

        }
    }
}

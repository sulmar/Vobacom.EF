﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.DAL.Configurations;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class HappyWheelsContext : DbContext
    {

        #region

        public DbSet<Station> Stations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Rental> Rentals { get; set; }


        #endregion

        public HappyWheelsContext()
            : base("HappyWheelsConnection")
        {

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations
                .Add(new UserConfiguration())
                .Add(new BikeConfiguration())
                .Add(new StationConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

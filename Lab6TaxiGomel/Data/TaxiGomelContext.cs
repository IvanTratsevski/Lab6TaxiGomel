﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab6TaxiGomel.Models;

namespace Lab6TaxiGomel.Data
{
    public partial class TaxiGomelContext : DbContext
    {
        public TaxiGomelContext()
        {
        }

        public TaxiGomelContext(DbContextOptions<TaxiGomelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Call> Calls { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarModel> CarModels { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;

    public class PartesAutosContext : DbContext
    {
        public PartesAutosContext (DbContextOptions<PartesAutosContext> options)
            : base(options)
        {
        }

        public DbSet<firstApplication.Models.PartesAutos> PartesAutos { get; set; }
    }

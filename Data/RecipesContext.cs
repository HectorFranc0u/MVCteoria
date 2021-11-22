using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;

    public class RecipesContext : DbContext
    {
        public RecipesContext (DbContextOptions<RecipesContext> options)
            : base(options)
        {
        }

        public DbSet<firstApplication.Models.Recipes> Recipes { get; set; }
    }
